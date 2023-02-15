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
    public unsafe readonly struct PfnBvV : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<byte*, void> Handle => (delegate* unmanaged[Cdecl]<byte*, void>) _handle;
        public PfnBvV
        (
            delegate* unmanaged[Cdecl]<byte*, void> ptr
        ) => _handle = ptr;

        public PfnBvV
        (
             BvVProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnBvV From(BvVProc proc) => new PfnBvV(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnBvV pfn) => (nint) pfn.Handle;
        public static explicit operator PfnBvV(nint pfn)
            => new PfnBvV((delegate* unmanaged[Cdecl]<byte*, void>) pfn);

        public static implicit operator PfnBvV(BvVProc proc)
            => new PfnBvV(proc);

        public static explicit operator BvVProc(PfnBvV pfn)
            => SilkMarshal.PtrToDelegate<BvVProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<byte*, void>(PfnBvV pfn) => pfn.Handle;
        public static implicit operator PfnBvV(delegate* unmanaged[Cdecl]<byte*, void> ptr) => new PfnBvV(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void BvVProc(byte* arg0);
}

