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
    public unsafe readonly struct PfnJackProcessCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<uint, void*, int>) _handle;
        public PfnJackProcessCallback
        (
            delegate* unmanaged[Cdecl]<uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnJackProcessCallback
        (
             JackProcessCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnJackProcessCallback From(JackProcessCallback proc) => new PfnJackProcessCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnJackProcessCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnJackProcessCallback(nint pfn)
            => new PfnJackProcessCallback((delegate* unmanaged[Cdecl]<uint, void*, int>) pfn);

        public static implicit operator PfnJackProcessCallback(JackProcessCallback proc)
            => new PfnJackProcessCallback(proc);

        public static explicit operator JackProcessCallback(PfnJackProcessCallback pfn)
            => SilkMarshal.PtrToDelegate<JackProcessCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, void*, int>(PfnJackProcessCallback pfn) => pfn.Handle;
        public static implicit operator PfnJackProcessCallback(delegate* unmanaged[Cdecl]<uint, void*, int> ptr) => new PfnJackProcessCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int JackProcessCallback(uint arg0, void* arg1);
}

