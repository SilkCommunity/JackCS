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
    public unsafe readonly struct PfnJackSyncCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<TransportStateT, Position*, void*, int> Handle => (delegate* unmanaged[Cdecl]<TransportStateT, Position*, void*, int>) _handle;
        public PfnJackSyncCallback
        (
            delegate* unmanaged[Cdecl]<TransportStateT, Position*, void*, int> ptr
        ) => _handle = ptr;

        public PfnJackSyncCallback
        (
             JackSyncCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackSyncCallback From(JackSyncCallback proc) => new PfnJackSyncCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackSyncCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackSyncCallback(nint pfn)
            => new PfnJackSyncCallback((delegate* unmanaged[Cdecl]<TransportStateT, Position*, void*, int>) pfn);

        public static implicit operator PfnJackSyncCallback(JackSyncCallback proc)
            => new PfnJackSyncCallback(proc);

        public static explicit operator JackSyncCallback(PfnJackSyncCallback pfn)
            => SilkMarshal.PtrToDelegate<JackSyncCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<TransportStateT, Position*, void*, int>(PfnJackSyncCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackSyncCallback(delegate* unmanaged[Cdecl]<TransportStateT, Position*, void*, int> ptr) => new PfnJackSyncCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int JackSyncCallback(TransportStateT arg0, Position* arg1, void* arg2);
}

