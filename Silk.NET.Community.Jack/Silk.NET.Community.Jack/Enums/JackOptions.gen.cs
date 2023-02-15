//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    [Flags]
    [NativeName("Name", "JackOptions")]
    public enum JackOptions : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackNullOption")]
        JackNullOption = 0x0,
        [NativeName("Name", "JackNoStartServer")]
        JackNoStartServer = 0x1,
        [NativeName("Name", "JackUseExactName")]
        JackUseExactName = 0x2,
        [NativeName("Name", "JackServerName")]
        JackServerName = 0x4,
        [NativeName("Name", "JackLoadName")]
        JackLoadName = 0x8,
        [NativeName("Name", "JackLoadInit")]
        JackLoadInit = 0x10,
        [NativeName("Name", "JackSessionID")]
        JackSessionID = 0x20,
    }
}
