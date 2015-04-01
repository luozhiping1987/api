// Copyright (C) 2014 dot42
//
// Original filename: FieldInfo.cs
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

using Dot42.Internal;
using Java.Lang.Reflect;

namespace System.Reflection
{
    public class FieldInfo : JavaMemberInfo
    {
        private readonly JavaField _field;
        private Type _type;

        public FieldInfo(JavaField field)  :base(field)
        {
            _field = field;
        }

        public override MemberTypes MemberType { get { return MemberTypes.Field; } }
        public override Type DeclaringType { get { return _field.DeclaringClass; } }
        public override string Name { get { return _field.Name; } }

        public Type FieldType
        {
            get
            {
                if (_type == null)
                {
                    var nullableT = _field.GetAnnotation<INullableT>(typeof(INullableT));
                    _type = nullableT == null ? _field.Type : nullableT.Type();
                }
                return _type;
            }
        }

        /// <summary>
        /// Is this an abstract method?
        /// </summary>
        public bool IsAbstract { get { return Modifier.IsAbstract(_field.GetModifiers()); } }

        /// <summary>
        /// Is this an final method?
        /// </summary>
        public bool IsFinal { get { return Modifier.IsFinal(_field.GetModifiers()); } }

        /// <summary>
        /// Is this an private method?
        /// </summary>
        public bool IsPrivate { get { return Modifier.IsPrivate(_field.GetModifiers()); } }

        /// <summary>
        /// Is this an public method?
        /// </summary>
        public bool IsPublic { get { return Modifier.IsPublic(_field.GetModifiers()); } }

        /// <summary>
        /// Is this a static method?
        /// </summary>
        public bool IsStatic { get { return Modifier.IsStatic(_field.GetModifiers()); } }

        /// <summary>
        /// Is this an virtual method?
        /// </summary>
        public bool IsVirtual { get { return !Modifier.IsFinal(_field.GetModifiers()); } }

        /// <summary>
        /// returns true only for enum fields.
        /// </summary>
        // return enum members as literals.
        public bool IsLiteral { get { return IsFinal && DeclaringType.IsEnum; } }

        /// <summary>
        /// returns IsFinal
        /// </summary>
        public bool IsInitOnly { get { return IsFinal; } }

        public void SetValue(object instance, object value)
        {
            // .NET doesn't have accessibility semantics
            if (!_field.IsAccessible()) _field.SetAccessible(true);
            
            _field.Set(instance, value);
        }

        public object GetValue(object instance)
        {
            // .NET doesn't have accessibility semantics
            if (!_field.IsAccessible()) _field.SetAccessible(true);

            return _field.Get(instance);
        }

        public override string ToString()
        {
            return _field.DeclaringClass.JavaGetName() + "::" + _field.Name;
        }

    }
}

