//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    [Flags]
    [NativeName("Name", "JackStatus")]
    public enum JackStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackFailure")]
        JackFailure = 0x1,
        [NativeName("Name", "JackInvalidOption")]
        JackInvalidOption = 0x2,
        [NativeName("Name", "JackNameNotUnique")]
        JackNameNotUnique = 0x4,
        [NativeName("Name", "JackServerStarted")]
        JackServerStarted = 0x8,
        [NativeName("Name", "JackServerFailed")]
        JackServerFailed = 0x10,
        [NativeName("Name", "JackServerError")]
        JackServerError = 0x20,
        [NativeName("Name", "JackNoSuchClient")]
        JackNoSuchClient = 0x40,
        [NativeName("Name", "JackLoadFailure")]
        JackLoadFailure = 0x80,
        [NativeName("Name", "JackInitFailure")]
        JackInitFailure = 0x100,
        [NativeName("Name", "JackShmFailure")]
        JackShmFailure = 0x200,
        [NativeName("Name", "JackVersionError")]
        JackVersionError = 0x400,
        [NativeName("Name", "JackBackendError")]
        JackBackendError = 0x800,
        [NativeName("Name", "JackClientZombie")]
        JackClientZombie = 0x1000,
    }
}
