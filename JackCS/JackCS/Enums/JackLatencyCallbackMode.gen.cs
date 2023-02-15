//oh


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace JackCS
{
    [Flags]
    [NativeName("Name", "JackLatencyCallbackMode")]
    public enum JackLatencyCallbackMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "JackCaptureLatency")]
        JackCaptureLatency = 0x0,
        [NativeName("Name", "JackPlaybackLatency")]
        JackPlaybackLatency = 0x1,
    }
}
