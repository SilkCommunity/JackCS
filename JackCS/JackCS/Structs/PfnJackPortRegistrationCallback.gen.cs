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
    public unsafe readonly struct PfnJackPortRegistrationCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, int, void*, void> Handle => (delegate* unmanaged[Cdecl]<uint, int, void*, void>) _handle;
        public PfnJackPortRegistrationCallback
        (
            delegate* unmanaged[Cdecl]<uint, int, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackPortRegistrationCallback
        (
             JackPortRegistrationCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackPortRegistrationCallback From(JackPortRegistrationCallback proc) => new PfnJackPortRegistrationCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackPortRegistrationCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackPortRegistrationCallback(nint pfn)
            => new PfnJackPortRegistrationCallback((delegate* unmanaged[Cdecl]<uint, int, void*, void>) pfn);

        public static implicit operator PfnJackPortRegistrationCallback(JackPortRegistrationCallback proc)
            => new PfnJackPortRegistrationCallback(proc);

        public static explicit operator JackPortRegistrationCallback(PfnJackPortRegistrationCallback pfn)
            => SilkMarshal.PtrToDelegate<JackPortRegistrationCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, int, void*, void>(PfnJackPortRegistrationCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackPortRegistrationCallback(delegate* unmanaged[Cdecl]<uint, int, void*, void> ptr) => new PfnJackPortRegistrationCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackPortRegistrationCallback(uint arg0, int arg1, void* arg2);
}

