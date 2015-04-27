// Copyright (C) 2014 dot42
//
// Original filename: IProperty.cs
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
using System.Reflection;
using Java.Lang.Annotation;

namespace Dot42.Internal
{
    /// <summary>
    /// Annotation interface specifying the assembly nme of a single type.
    /// </summary>
    [Include(TypeCondition = typeof(AssemblyTypes), ApplyToMembers = true)]
    internal interface IAssemblyType : IAnnotation
    {
        /// <summary>
        /// Name of the assembly.
        /// </summary>
        string AssemblyName();

        /// <summary>
        /// Type
        /// </summary>
        Type Type();
    }

    /// <summary>
    /// Annotation interface for assembly reflection
    /// </summary>
    [Include(TypeCondition = typeof(AssemblyTypes), ApplyToMembers = true)]
    internal interface IAssemblyTypes : IAnnotation
    {
        IAssemblyType[] Types();
        
        string EntryAssemblyName();
    }
}

