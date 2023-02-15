using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    public partial class Jack
    {
        public static Jack GetApi()
        {
             return new(CreateDefaultContext(new JackLibraryNameContainer().GetLibraryName()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<Jack>
        {
             ext = IsExtensionPresent(GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return ext is not null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

