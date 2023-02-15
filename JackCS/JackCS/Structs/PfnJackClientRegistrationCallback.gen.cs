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
    public unsafe readonly struct PfnJackClientRegistrationCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<byte*, int, void*, void> Handle => (delegate* unmanaged[Cdecl]<byte*, int, void*, void>) _handle;
        public PfnJackClientRegistrationCallback
        (
            delegate* unmanaged[Cdecl]<byte*, int, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackClientRegistrationCallback
        (
             JackClientRegistrationCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackClientRegistrationCallback From(JackClientRegistrationCallback proc) => new PfnJackClientRegistrationCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackClientRegistrationCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackClientRegistrationCallback(nint pfn)
            => new PfnJackClientRegistrationCallback((delegate* unmanaged[Cdecl]<byte*, int, void*, void>) pfn);

        public static implicit operator PfnJackClientRegistrationCallback(JackClientRegistrationCallback proc)
            => new PfnJackClientRegistrationCallback(proc);

        public static explicit operator JackClientRegistrationCallback(PfnJackClientRegistrationCallback pfn)
            => SilkMarshal.PtrToDelegate<JackClientRegistrationCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<byte*, int, void*, void>(PfnJackClientRegistrationCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackClientRegistrationCallback(delegate* unmanaged[Cdecl]<byte*, int, void*, void> ptr) => new PfnJackClientRegistrationCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackClientRegistrationCallback(byte* arg0, int arg1, void* arg2);
}

