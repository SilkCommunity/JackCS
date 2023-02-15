//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace JackCS
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_types_L539_C9")]
    [NativeName("Name", "jack_position_bits_t")]
    public enum PositionBitsT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackPositionBBT")]
        JackPositionBbt = 0x10,
        [NativeName("Name", "JackPositionTimecode")]
        JackPositionTimecode = 0x20,
        [NativeName("Name", "JackBBTFrameOffset")]
        JackBbtframeOffset = 0x40,
        [NativeName("Name", "JackAudioVideoRatio")]
        JackAudioVideoRatio = 0x80,
        [NativeName("Name", "JackVideoFrameOffset")]
        JackVideoFrameOffset = 0x100,
        [NativeName("Name", "JackTickDouble")]
        JackTickDouble = 0x200,
    }
}
