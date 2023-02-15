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
    public unsafe readonly struct PfnJackFreewheelCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<int, void*, void> Handle => (delegate* unmanaged[Cdecl]<int, void*, void>) _handle;
        public PfnJackFreewheelCallback
        (
            delegate* unmanaged[Cdecl]<int, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackFreewheelCallback
        (
             JackFreewheelCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackFreewheelCallback From(JackFreewheelCallback proc) => new PfnJackFreewheelCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackFreewheelCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackFreewheelCallback(nint pfn)
            => new PfnJackFreewheelCallback((delegate* unmanaged[Cdecl]<int, void*, void>) pfn);

        public static implicit operator PfnJackFreewheelCallback(JackFreewheelCallback proc)
            => new PfnJackFreewheelCallback(proc);

        public static explicit operator JackFreewheelCallback(PfnJackFreewheelCallback pfn)
            => SilkMarshal.PtrToDelegate<JackFreewheelCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<int, void*, void>(PfnJackFreewheelCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackFreewheelCallback(delegate* unmanaged[Cdecl]<int, void*, void> ptr) => new PfnJackFreewheelCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackFreewheelCallback(int arg0, void* arg1);
}

