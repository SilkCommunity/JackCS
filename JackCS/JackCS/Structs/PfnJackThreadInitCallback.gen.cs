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

namespace JackCS
{
    public unsafe readonly struct PfnJackThreadInitCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnJackThreadInitCallback
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnJackThreadInitCallback
        (
             JackThreadInitCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackThreadInitCallback From(JackThreadInitCallback proc) => new PfnJackThreadInitCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackThreadInitCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackThreadInitCallback(nint pfn)
            => new PfnJackThreadInitCallback((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnJackThreadInitCallback(JackThreadInitCallback proc)
            => new PfnJackThreadInitCallback(proc);

        public static explicit operator JackThreadInitCallback(PfnJackThreadInitCallback pfn)
            => SilkMarshal.PtrToDelegate<JackThreadInitCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnJackThreadInitCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackThreadInitCallback(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnJackThreadInitCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackThreadInitCallback(void* arg0);
}

