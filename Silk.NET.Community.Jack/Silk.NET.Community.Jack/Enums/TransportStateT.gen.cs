//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_types_L523_C9")]
    [NativeName("Name", "jack_transport_state_t")]
    public enum TransportStateT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackTransportStopped")]
        JackTransportStopped = 0x0,
        [NativeName("Name", "JackTransportRolling")]
        JackTransportRolling = 0x1,
        [NativeName("Name", "JackTransportLooping")]
        JackTransportLooping = 0x2,
        [NativeName("Name", "JackTransportStarting")]
        JackTransportStarting = 0x3,
        [NativeName("Name", "JackTransportNetStarting")]
        JackTransportNetStarting = 0x4,
    }
}
