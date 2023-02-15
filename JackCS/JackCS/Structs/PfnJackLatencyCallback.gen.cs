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
    public unsafe readonly struct PfnJackLatencyCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<JackLatencyCallbackMode, void*, void> Handle => (delegate* unmanaged[Cdecl]<JackLatencyCallbackMode, void*, void>) _handle;
        public PfnJackLatencyCallback
        (
            delegate* unmanaged[Cdecl]<JackLatencyCallbackMode, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackLatencyCallback
        (
             JackLatencyCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackLatencyCallback From(JackLatencyCallback proc) => new PfnJackLatencyCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackLatencyCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackLatencyCallback(nint pfn)
            => new PfnJackLatencyCallback((delegate* unmanaged[Cdecl]<JackLatencyCallbackMode, void*, void>) pfn);

        public static implicit operator PfnJackLatencyCallback(JackLatencyCallback proc)
            => new PfnJackLatencyCallback(proc);

        public static explicit operator JackLatencyCallback(PfnJackLatencyCallback pfn)
            => SilkMarshal.PtrToDelegate<JackLatencyCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<JackLatencyCallbackMode, void*, void>(PfnJackLatencyCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackLatencyCallback(delegate* unmanaged[Cdecl]<JackLatencyCallbackMode, void*, void> ptr) => new PfnJackLatencyCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackLatencyCallback(JackLatencyCallbackMode arg0, void* arg1);
}

