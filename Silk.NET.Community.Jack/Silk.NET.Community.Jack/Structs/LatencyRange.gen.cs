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
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "_jack_latency_range")]
    public unsafe partial struct LatencyRange
    {
        public LatencyRange
        (
            uint? min = null,
            uint? max = null
        ) : this()
        {
            if (min is not null)
            {
                Min = min.Value;
            }

            if (max is not null)
            {
                Max = max.Value;
            }
        }


        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "min")]
        public uint Min;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "max")]
        public uint Max;
    }
}
