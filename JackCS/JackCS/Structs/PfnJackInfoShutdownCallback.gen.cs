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
    public unsafe readonly struct PfnJackInfoShutdownCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<JackStatus, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<JackStatus, byte*, void*, void>) _handle;
        public PfnJackInfoShutdownCallback
        (
            delegate* unmanaged[Cdecl]<JackStatus, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackInfoShutdownCallback
        (
             JackInfoShutdownCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackInfoShutdownCallback From(JackInfoShutdownCallback proc) => new PfnJackInfoShutdownCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackInfoShutdownCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackInfoShutdownCallback(nint pfn)
            => new PfnJackInfoShutdownCallback((delegate* unmanaged[Cdecl]<JackStatus, byte*, void*, void>) pfn);

        public static implicit operator PfnJackInfoShutdownCallback(JackInfoShutdownCallback proc)
            => new PfnJackInfoShutdownCallback(proc);

        public static explicit operator JackInfoShutdownCallback(PfnJackInfoShutdownCallback pfn)
            => SilkMarshal.PtrToDelegate<JackInfoShutdownCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<JackStatus, byte*, void*, void>(PfnJackInfoShutdownCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackInfoShutdownCallback(delegate* unmanaged[Cdecl]<JackStatus, byte*, void*, void> ptr) => new PfnJackInfoShutdownCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackInfoShutdownCallback(JackStatus arg0, byte* arg1, void* arg2);
}

