// Copyright (C) 2014 dot42
//
// Original filename: MulticastDelegate.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Reflection;
using System.Threading;
using Dot42;

namespace System
{
    abstract partial class MulticastDelegate : Delegate
    {
        // http://csharpindepth.com/Articles/Chapter2/Events.aspx
        //                                        in particular the table on removal 
        //                                        and addition of delegates.

        // MulticastDelegate is immutable per specification.
        //
        // In our implementation, we always have a head (this), and possibly
        // a tail, stored in 'invocationList', its length defined by 
        // 'invocationListLength'.
        // The invocation list will only contain delegates that 
        // do not have an invocation list on their own, i.e. we always have
        // a flat invocation list.
        // We try to minimize the number of new allocations by sharing the 
        // invocation list between instances, if possible. Also, we only 
        // create an invocation list when required. 

        [Include]
        protected int InvocationListLength;

        [Include]
	    protected MulticastDelegate[] InvocationList;

        [Include]
        private int ownsInvocationList;

        protected abstract bool EqualsWithoutInvocationList(object other);
        [DexName("CloneWithNewInvocationList")]
        protected abstract MulticastDelegate CloneWithNewInvocationList(MulticastDelegate[] invocationList, int invocationListLength);

        protected override sealed Delegate CombineImpl(Delegate other)
        {
            if (other == null)
                return this;

            MulticastDelegate o = (MulticastDelegate) other;

            var oInvList = o.InvocationList;
            var oInvLen = o.InvocationListLength;

            o = o.WithoutInvocationList(); // we flatten the list. 

            var newInvList = InvocationList;
            var curInvLen = InvocationListLength;
            int newInvLen = curInvLen + 1 + oInvLen;
            

            bool needNewList = newInvList == null || newInvList.Length < newInvLen;

            // try appending to the current list.
            if (!needNewList)
            {
                if (Interlocked.CompareExchange(ref ownsInvocationList, 0, 1) == 0)
                    needNewList = true;
                else
                {
                    newInvList[curInvLen] = o;
                    for (int i = 0; i < oInvLen; ++i)
                    {
                        newInvList[curInvLen + i + 1] = oInvList[i];
                    }
                }
            }

            if (needNewList)
            {
                // start by 4, duplicate size.
                int len = newInvList == null ? 4 : newInvList.Length;
                while (len < newInvLen)
                    len *= 2;

                MulticastDelegate[] list = new MulticastDelegate[len];

                var curInvList = InvocationList;
                for(int i = 0; i < curInvLen; ++i)
                    list[i] = curInvList[i];

                list[curInvLen] = o;
                
                for (int i = 0; i < oInvLen; ++i)
                    list[curInvLen + 1 + i] = oInvList[i];

                newInvList = list;
            }

            var ret = this.CloneWithNewInvocationList(newInvList, newInvLen);
            ret.ownsInvocationList = 1;
            return ret;
        }

        protected override sealed Delegate RemoveImpl(Delegate other)
        {
            if (ReferenceEquals(other, this))
                return null;

            MulticastDelegate o = (MulticastDelegate)other;

            int idx = LastIndexOf(o);

            if (idx == -1)
                return this;

            var invListLen = InvocationListLength;
            var newNumDelegates = invListLen - o.InvocationListLength;

            if (newNumDelegates == 0)
                return null;

            if (newNumDelegates == 1)
            {
                if (idx == 0)
                    return WithoutInvocationList();
                return InvocationList[idx - 1];
            }

            int newInvListLen = newNumDelegates - 1;
            MulticastDelegate[] newInvList;
            MulticastDelegate head;

            var invList = InvocationList;

            if (idx == 0)
            {
                head = invList[o.InvocationListLength];
                newInvList = RemoveSliceFromInvocationList(invList, invListLen, 0, o.InvocationListLength + 1);
            }
            else
            {
                head = this;
                newInvList = RemoveSliceFromInvocationList(invList, invListLen, idx - 1, o.InvocationListLength + 1);    
            }

            var ret = head.CloneWithNewInvocationList(newInvList, newInvListLen);
            if (newInvList != null && !ReferenceEquals(newInvList, InvocationList))
                ret.ownsInvocationList = 1;
            return ret;
        }

        public override Delegate[] GetInvocationList()
        {
            Delegate[] ret = new Delegate[1 + InvocationListLength];
            ret[0] = this.WithoutInvocationList();
            for (int i = 1; i <= InvocationListLength; ++i)
                ret[i] = InvocationList[i - 1];
            return ret;
        }

        private MulticastDelegate WithoutInvocationList()
        {
            if (InvocationListLength == 0)
                return this;
            return CloneWithNewInvocationList(null, 0);
        }

        /// <summary>
	    /// return the class instance or null, if this is a static delegate.
	    /// </summary>
	    public override object Target 
	    {
	        get
	        {
	            FieldInfo field;
                // we need to return the last Target from our invocation list.
                if (InvocationListLength > 0)
	            {
                    var del = InvocationList[InvocationListLength - 1];
	                field = del.GetInstanceField();
	                return field == null ? null : field.GetValue(del);
	            }

                field = this.GetInstanceField();
                return field == null ? null : field.GetValue(this);
            }
	    }

        internal override MethodInfo Method
        {
            get
            {
                // we need to return the last Method from our invocation list.
                if(InvocationListLength > 0)
                    return InvocationList[InvocationListLength-1].GetMethodInfo();
                return GetMethodInfo();
            }
        }

        public override bool Equals(object other)
        {
            // we have to check for same type and same invocation list.
            var o = other as MulticastDelegate;

            if (o == null)
                return false;

            var invListLen = InvocationListLength;
            if (invListLen != o.InvocationListLength)
                return false;

            if (!EqualsWithoutInvocationList(o))
                return false;

            var oInvList = o.InvocationList;
            var invList = InvocationList;

            for (int i = 0; i < invListLen; ++i)
            {
                if (!invList[i].EqualsWithoutInvocationList(oInvList[i]))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            // GetType() maps to the called method.
            return GetType().GetHashCode() * 33 + InvocationListLength;
        }

        private static MulticastDelegate[] RemoveSliceFromInvocationList(MulticastDelegate[] invList, int invListLen, int idx, int length)
        {
            int newInvLen = invListLen - length;
            int trueInvListLen = invList.Length;

            bool canKeepList = newInvLen == idx && (trueInvListLen <= 4 || trueInvListLen/2 <= newInvLen);

            if(canKeepList)
                return invList;

            trueInvListLen = 4;
            while (trueInvListLen < newInvLen)
                trueInvListLen *= 2;

            MulticastDelegate[] newList = new MulticastDelegate[trueInvListLen];

            for (int i = 0; i < idx; ++i)
                newList[i] = invList[i];
            for (int i = idx + length, j = idx; j < newInvLen; ++i, ++j)
                newList[j] = invList[i];

            return newList;
        }

        /// <summary>
        /// Will return an index into [head] + tail, or -1 if not found 
        /// </summary>
        private int LastIndexOf(MulticastDelegate o)
        {
            int oInvLen = o.InvocationListLength;
            var oInvList = o.InvocationList;
            var invList = InvocationList;

            // We need to start comparing from the end.

            // Mono's implementation uses the KMP algorithm, but at a first
            // glance this seems to be overkill for an invocation list. In the
            // typical usage scenario, 'o' will have no invocation list at all.
            // We stick to the naive implementation for now.
            for (int i = InvocationListLength - oInvLen; i >= 0; --i) 
            {
                // 0 = this
                if (i == 0)
                {
                    // compare o itself
                    return this.EqualsWithoutInvocationList(o) ? 0 : -1;
                }
                
                if (!invList[i - 1].EqualsWithoutInvocationList(o))
                    continue;

                for (int j = 0; j < oInvLen; ++j)
                {
                    if (!invList[i + j].EqualsWithoutInvocationList(oInvList[j]))
                        goto next_iteration;
                }

                // found it!
                return i;

            next_iteration: ;
            }

            return -1;
        }
    }
}
