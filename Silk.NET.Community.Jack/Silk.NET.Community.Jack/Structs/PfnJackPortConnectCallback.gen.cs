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
    public unsafe readonly struct PfnJackPortConnectCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, uint, int, void*, void> Handle => (delegate* unmanaged[Cdecl]<uint, uint, int, void*, void>) _handle;
        public PfnJackPortConnectCallback
        (
            delegate* unmanaged[Cdecl]<uint, uint, int, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackPortConnectCallback
        (
             JackPortConnectCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackPortConnectCallback From(JackPortConnectCallback proc) => new PfnJackPortConnectCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackPortConnectCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackPortConnectCallback(nint pfn)
            => new PfnJackPortConnectCallback((delegate* unmanaged[Cdecl]<uint, uint, int, void*, void>) pfn);

        public static implicit operator PfnJackPortConnectCallback(JackPortConnectCallback proc)
            => new PfnJackPortConnectCallback(proc);

        public static explicit operator JackPortConnectCallback(PfnJackPortConnectCallback pfn)
            => SilkMarshal.PtrToDelegate<JackPortConnectCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, uint, int, void*, void>(PfnJackPortConnectCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackPortConnectCallback(delegate* unmanaged[Cdecl]<uint, uint, int, void*, void> ptr) => new PfnJackPortConnectCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackPortConnectCallback(uint arg0, uint arg1, int arg2, void* arg3);
}

