// Copyright (C) 2014 dot42
//
// Original filename: Activity.cs
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

using System;
using Android.Content;

namespace Android.App
{
    partial class Activity
    {
        /// <summary>
        /// Look for a child view with the given id. If this view has the given id, return this view.
        /// </summary>
        public T FindViewById<T>(int id)
            where T : Android.Views.View
        {
            return (T) FindViewById(id);
        }

        /// <summary>
        /// <para>Runs the specified action on the UI thread. If the current thread is the UI thread, then the action is executed immediately. If the current thread is not the UI thread, the action is posted to the event queue of the UI thread.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// runOnUiThread
        /// </java-name>
        [Dot42.DexImport("runOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 17, IgnoreFromJava = true)]
        public void RunOnUiThread(System.Action action)
        {
        }

        /// <summary>
        /// Change the title associated with this activity. If this is a top-level activity, the title for its window will change. If it is an embedded activity, the parent can do whatever it wants with it. 
        /// </summary>
        public string Title
        {
            get { return (string)JavaGetTitle(); }
            set { SetTitle(value);}
        }

        /// <summary>
        ///  <para>Launch a new activity. You will not receive any information about when the activity exits.</para> <para>Note that if this method is being called from outside of an android.app.Activity Context, then the Intent must include the Intent#FLAG_ACTIVITY_NEW_TASK launch flag. This is because, without being started from an existing Activity, there is no existing task in which to place the new activity and thus it needs to be placed in its own separate task.</para> <para>This method throws ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>startActivity(Intent) </para> <para>PackageManager::resolveActivity </para></para>        
        /// </summary>
        public void StartActivityForResult(Type activityType, int requestCode)
        {
            StartActivityForResult(new Intent(this, activityType), requestCode);
        }
    }
}

