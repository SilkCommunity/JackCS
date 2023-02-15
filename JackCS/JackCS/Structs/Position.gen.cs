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
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "_jack_position")]
    public unsafe partial struct Position
    {
        public Position
        (
            ulong? unique1 = null,
            ulong? usecs = null,
            uint? frameRate = null,
            uint? frame = null,
            PositionBitsT? valid = null,
            int? bar = null,
            int? beat = null,
            int? tick = null,
            double? barStartTick = null,
            float? beatsPerBar = null,
            float? beatType = null,
            double? ticksPerBeat = null,
            double? beatsPerMinute = null,
            double? frameTime = null,
            double? nextTime = null,
            uint? bbtOffset = null,
            float? audioFramesPerVideoFrame = null,
            uint? videoOffset = null,
            double? tickDouble = null,
            ulong? unique2 = null
        ) : this()
        {
            if (unique1 is not null)
            {
                Unique1 = unique1.Value;
            }

            if (usecs is not null)
            {
                Usecs = usecs.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (frame is not null)
            {
                Frame = frame.Value;
            }

            if (valid is not null)
            {
                Valid = valid.Value;
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

            if (frameTime is not null)
            {
                FrameTime = frameTime.Value;
            }

            if (nextTime is not null)
            {
                NextTime = nextTime.Value;
            }

            if (bbtOffset is not null)
            {
                BbtOffset = bbtOffset.Value;
            }

            if (audioFramesPerVideoFrame is not null)
            {
                AudioFramesPerVideoFrame = audioFramesPerVideoFrame.Value;
            }

            if (videoOffset is not null)
            {
                VideoOffset = videoOffset.Value;
            }

            if (tickDouble is not null)
            {
                TickDouble = tickDouble.Value;
            }

            if (unique2 is not null)
            {
                Unique2 = unique2.Value;
            }
        }


        [NativeName("Type", "jack_unique_t")]
        [NativeName("Type.Name", "jack_unique_t")]
        [NativeName("Name", "unique_1")]
        public ulong Unique1;

        [NativeName("Type", "jack_time_t")]
        [NativeName("Type.Name", "jack_time_t")]
        [NativeName("Name", "usecs")]
        public ulong Usecs;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "frame_rate")]
        public uint FrameRate;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "frame")]
        public uint Frame;

        [NativeName("Type", "jack_position_bits_t")]
        [NativeName("Type.Name", "jack_position_bits_t")]
        [NativeName("Name", "valid")]
        public PositionBitsT Valid;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "bar")]
        public int Bar;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "beat")]
        public int Beat;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
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

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "frame_time")]
        public double FrameTime;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "next_time")]
        public double NextTime;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "bbt_offset")]
        public uint BbtOffset;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "audio_frames_per_video_frame")]
        public float AudioFramesPerVideoFrame;

        [NativeName("Type", "jack_nframes_t")]
        [NativeName("Type.Name", "jack_nframes_t")]
        [NativeName("Name", "video_offset")]
        public uint VideoOffset;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "tick_double")]
        public double TickDouble;
        [NativeName("Type", "int32_t [5]")]
        [NativeName("Type.Name", "int32_t [5]")]
        [NativeName("Name", "padding")]
        public fixed int Padding[5];

        [NativeName("Type", "jack_unique_t")]
        [NativeName("Type.Name", "jack_unique_t")]
        [NativeName("Name", "unique_2")]
        public ulong Unique2;
    }
}
