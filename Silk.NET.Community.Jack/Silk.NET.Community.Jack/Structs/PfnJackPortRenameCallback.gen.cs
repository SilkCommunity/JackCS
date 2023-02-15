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
    public unsafe readonly struct PfnJackPortRenameCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, byte*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<uint, byte*, byte*, void*, void>) _handle;
        public PfnJackPortRenameCallback
        (
            delegate* unmanaged[Cdecl]<uint, byte*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnJackPortRenameCallback
        (
             JackPortRenameCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackPortRenameCallback From(JackPortRenameCallback proc) => new PfnJackPortRenameCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackPortRenameCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackPortRenameCallback(nint pfn)
            => new PfnJackPortRenameCallback((delegate* unmanaged[Cdecl]<uint, byte*, byte*, void*, void>) pfn);

        public static implicit operator PfnJackPortRenameCallback(JackPortRenameCallback proc)
            => new PfnJackPortRenameCallback(proc);

        public static explicit operator JackPortRenameCallback(PfnJackPortRenameCallback pfn)
            => SilkMarshal.PtrToDelegate<JackPortRenameCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, byte*, byte*, void*, void>(PfnJackPortRenameCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackPortRenameCallback(delegate* unmanaged[Cdecl]<uint, byte*, byte*, void*, void> ptr) => new PfnJackPortRenameCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void JackPortRenameCallback(uint arg0, byte* arg1, byte* arg2, void* arg3);
}

