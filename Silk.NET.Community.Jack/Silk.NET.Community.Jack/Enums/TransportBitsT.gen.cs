//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Community.Jack
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_types_L707_C9")]
    [NativeName("Name", "jack_transport_bits_t")]
    public enum TransportBitsT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackTransportState")]
        JackTransportState = 0x1,
        [NativeName("Name", "JackTransportPosition")]
        JackTransportPosition = 0x2,
        [NativeName("Name", "JackTransportLoop")]
        JackTransportLoop = 0x4,
        [NativeName("Name", "JackTransportSMPTE")]
        JackTransportSmpte = 0x8,
        [NativeName("Name", "JackTransportBBT")]
        JackTransportBbt = 0x10,
    }
}
