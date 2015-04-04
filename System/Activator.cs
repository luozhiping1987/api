// Copyright (C) 2014 dot42
//
// Original filename: Activator.cs
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

using System.Collections.Generic;
using Dot42.Internal;
using Dot42.Internal.Generics;
using Dot42;

namespace System
{
	public sealed class Activator
	{
        /// <summary>
        /// Create an instance of the given type using it's default constructor.
        /// </summary>
        public static object CreateInstance(Type type)
        {
            if (NullableReflection.TreatAsSystemNullableT(type))
                return null;

            var genericInstance = GenericInstanceFactory.CreateGenericInstance(type);
            if (genericInstance != null) 
                return genericInstance;

            return  type.NewInstance();
        }

        /// <summary>
        /// Create an instance of the given type using the best matching constructor.
        /// </summary>
        public static object CreateInstance(Type type, object[] args)
        {
            if (NullableReflection.TreatAsSystemNullableT(type))
                return null;

            var genericInstance = GenericInstanceFactory.CreateGenericInstance(type, args);
            if (genericInstance != null)
                return genericInstance;

            // collect the correct argument types, find constructor, create instance.
            // TODO: typeof(object)=>null might not work as expected. maybe we need
            //       our own matching logic.
            var argumentTypes = args.Select(a => a == null 
                                                ? typeof (object) 
                                                : a.JavaGetClass());
            var constructor = type.GetConstructor(argumentTypes);

            return constructor.Invoke(args);
        }

        /// <summary>
        /// Create an instance of the given type T using it's default constructor.
        /// </summary>
        public static T CreateInstance<T>()
        {
            if (NullableReflection.TreatAsSystemNullableT(typeof(T)))
                return default(T);

            return (T)typeof(T).NewInstance();
        }
    }
}

