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
    public unsafe readonly struct PfnJackGraphOrderCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, int> Handle => (delegate* unmanaged[Cdecl]<void*, int>) _handle;
        public PfnJackGraphOrderCallback
        (
            delegate* unmanaged[Cdecl]<void*, int> ptr
        ) => _handle = ptr;

        public PfnJackGraphOrderCallback
        (
             JackGraphOrderCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackGraphOrderCallback From(JackGraphOrderCallback proc) => new PfnJackGraphOrderCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackGraphOrderCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackGraphOrderCallback(nint pfn)
            => new PfnJackGraphOrderCallback((delegate* unmanaged[Cdecl]<void*, int>) pfn);

        public static implicit operator PfnJackGraphOrderCallback(JackGraphOrderCallback proc)
            => new PfnJackGraphOrderCallback(proc);

        public static explicit operator JackGraphOrderCallback(PfnJackGraphOrderCallback pfn)
            => SilkMarshal.PtrToDelegate<JackGraphOrderCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int>(PfnJackGraphOrderCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackGraphOrderCallback(delegate* unmanaged[Cdecl]<void*, int> ptr) => new PfnJackGraphOrderCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int JackGraphOrderCallback(void* arg0);
}

