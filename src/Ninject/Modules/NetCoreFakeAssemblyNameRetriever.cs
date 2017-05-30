//-------------------------------------------------------------------------------
// <copyright file="AssemblyNameRetriever.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

#if CORECLR
namespace Ninject.Modules
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Ninject.Components;

    using System.Runtime.Loader;

    /// <summary>
    /// Retrieves assembly names which contains a word 'ninject'
    /// we can do nothing more in .Net Core 1.x
    /// </summary>
    public class NetCoreFakeAssemblyNameRetriever : NinjectComponent, IAssemblyNameRetriever
    {
        /// <summary>
        /// Gets all assembly names of the assemblies in the given files that match the filter.
        /// </summary>
        /// <param name="filenames">The filenames.</param>
        /// <param name="filter">The filter.</param>
        /// <returns>All assembly names of the assemblies in the given files that match the filter.</returns>
        public IEnumerable<AssemblyName> GetAssemblyNames(
            IEnumerable<string> filenames,
            Predicate<Assembly> filter
            )
        {
            var result = new List<AssemblyName>();

            foreach(var filename in filenames)
            {
                var fnl = filename.ToLowerInvariant();
                if(fnl.Contains("ninject"))
                {
                    var an = AssemblyLoadContext.GetAssemblyName(filename);
                    result.Add(an);
                }
            }

            return
                result;
        }
    }

}
#endif