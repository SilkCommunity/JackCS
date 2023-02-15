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
    public unsafe readonly struct PfnJackTimebaseCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<TransportStateT, uint, Position*, int, void*, void> Handle => (delegate* unmanaged[Cdecl]<TransportStateT, uint, Position*, int, void*, void>) _handle;
        public PfnJackTimebaseCallback
        (
            delegate* unmanaged[Cdecl]<TransportStateT, uint, Position*, int, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackTimebaseCallback
        (
             JackTimebaseCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackTimebaseCallback From(JackTimebaseCallback proc) => new PfnJackTimebaseCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackTimebaseCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackTimebaseCallback(nint pfn)
            => new PfnJackTimebaseCallback((delegate* unmanaged[Cdecl]<TransportStateT, uint, Position*, int, void*, void>) pfn);

        public static implicit operator PfnJackTimebaseCallback(JackTimebaseCallback proc)
            => new PfnJackTimebaseCallback(proc);

        public static explicit operator JackTimebaseCallback(PfnJackTimebaseCallback pfn)
            => SilkMarshal.PtrToDelegate<JackTimebaseCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<TransportStateT, uint, Position*, int, void*, void>(PfnJackTimebaseCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackTimebaseCallback(delegate* unmanaged[Cdecl]<TransportStateT, uint, Position*, int, void*, void> ptr) => new PfnJackTimebaseCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackTimebaseCallback(TransportStateT arg0, uint arg1, Position* arg2, int arg3, void* arg4);
}

