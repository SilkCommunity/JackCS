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
    [NativeName("AnonymousName", "__AnonymousRecord_types_L723_C9")]
    [NativeName("Name", "jack_transport_info_t")]
    public unsafe partial struct TransportInfoT
    {
        public TransportInfoT
        (
            uint? frameRate = null,
            ulong? usecs = null,
            TransportBitsT? valid = null,
            TransportStateT? transportState = null,
            uint? frame = null,
            uint? loopStart = null,
            uint? loopEnd = null,
            int? smpteOffset = null,
            float? smpteFrameRate = null,
            int? bar = null,
            int? beat = null,
            int? tick = null,
            double? barStartTick = null,
            float? beatsPerBar = null,
            float? beatType = null,
            double? ticksPerBeat = null,
            double? beatsPerMinute = null
        ) : this()
        {
            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (usecs is not null)
            {
                Usecs = usecs.Value;
            }

            if (valid is not null)
            {
                Valid = valid.Value;
            }

            if (transportState is not null)
            {
                TransportState = transportState.Value;
            }

            if (frame is not null)
            {
                Frame = frame.Value;
            }

            if (loopStart is not null)
            {
                LoopStart = loopStart.Value;
            }

            if (loopEnd is not null)
            {
                LoopEnd = loopEnd.Value;
            }

            if (smpteOffset is not null)
            {
                SmpteOffset = smpteOffset.Value;
            }

            if (smpteFrameRate is not null)
            {
                SmpteFrameRate = smpteFrameRate.Value;
            }

            if (bar is not null)
            {
                Bar = bar.Value;
            }

            if (beat is not null)
            {
                Beat = beat.Value;
            }

            if (tick is not null)
            {
                Tick = tick.Value;
            }

            if (barStartTick is not null)
            {
                BarStartTick = barStartTick.Value;
            }

            if (beatsPerBar is not null)
            {
                BeatsPerBar = beatsPerBar.Value;
            }

            if (beatType is not null)
            {
                BeatType = beatType.Value;
            }

            if (ticksPerBeat is not null)
            {
                TicksPerBeat = ticksPerBeat.Value;
            }

            if (beatsPerMinute is not null)
            {
                BeatsPerMinute = beatsPerMinute.Value;
            }
        }


        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "frame_rate")]
        public uint FrameRate;

        [NativeName("Type", "jack_time_t")]
        [NativeName("Type.Name", "jack_time_t")]
        [NativeName("Name", "usecs")]
        public ulong Usecs;

        [NativeName("Type", "jack_transport_bits_t")]
        [NativeName("Type.Name", "jack_transport_bits_t")]
        [NativeName("Name", "valid")]
        public TransportBitsT Valid;

        [NativeName("Type", "jack_transport_state_t")]
        [NativeName("Type.Name", "jack_transport_state_t")]
        [NativeName("Name", "transport_state")]
        public TransportStateT TransportState;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "frame")]
        public uint Frame;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "loop_start")]
        public uint LoopStart;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "loop_end")]
        public uint LoopEnd;

        [NativeName("Type", "long")]
        [NativeName("Type.Name", "long")]
        [NativeName("Name", "smpte_offset")]
        public int SmpteOffset;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "smpte_frame_rate")]
        public float SmpteFrameRate;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "bar")]
        public int Bar;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "beat")]
        public int Beat;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "tick")]
        public int Tick;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "bar_start_tick")]
        public double BarStartTick;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "beats_per_bar")]
        public float BeatsPerBar;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "beat_type")]
        public float BeatType;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "ticks_per_beat")]
        public double TicksPerBeat;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "beats_per_minute")]
        public double BeatsPerMinute;
    }
}
