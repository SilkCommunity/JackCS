//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    [Flags]
    [NativeName("Name", "JackPortFlags")]
    public enum JackPortFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackPortIsInput")]
        JackPortIsInput = 0x1,
        [NativeName("Name", "JackPortIsOutput")]
        JackPortIsOutput = 0x2,
        [NativeName("Name", "JackPortIsPhysical")]
        JackPortIsPhysical = 0x4,
        [NativeName("Name", "JackPortCanMonitor")]
        JackPortCanMonitor = 0x8,
        [NativeName("Name", "JackPortIsTerminal")]
        JackPortIsTerminal = 0x10,
    }
}
