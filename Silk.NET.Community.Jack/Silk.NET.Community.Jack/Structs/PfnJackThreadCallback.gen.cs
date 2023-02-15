//oh


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    public unsafe readonly struct PfnJackThreadCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void*> Handle => (delegate* unmanaged[Cdecl]<void*, void*>) _handle;
        public PfnJackThreadCallback
        (
            delegate* unmanaged[Cdecl]<void*, void*> ptr
        ) => _handle = ptr;

        public PfnJackThreadCallback
        (
             JackThreadCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackThreadCallback From(JackThreadCallback proc) => new PfnJackThreadCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackThreadCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackThreadCallback(nint pfn)
            => new PfnJackThreadCallback((delegate* unmanaged[Cdecl]<void*, void*>) pfn);

        public static implicit operator PfnJackThreadCallback(JackThreadCallback proc)
            => new PfnJackThreadCallback(proc);

        public static explicit operator JackThreadCallback(PfnJackThreadCallback pfn)
            => SilkMarshal.PtrToDelegate<JackThreadCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*>(PfnJackThreadCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackThreadCallback(delegate* unmanaged[Cdecl]<void*, void*> ptr) => new PfnJackThreadCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* JackThreadCallback(void* arg0);
}

