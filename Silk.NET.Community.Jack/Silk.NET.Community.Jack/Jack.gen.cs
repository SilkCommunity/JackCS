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
    public unsafe partial class Jack : NativeAPI
    {
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "JACK_MAX_FRAMES")]
        public const uint MaxFrames = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "JACK_LOAD_INIT_LIMIT")]
        public const int LoadInitLimit = unchecked((int) 0x400);
        [NativeName("Type", "")]
        [NativeName("Name", "JACK_DEFAULT_AUDIO_TYPE")]
        public const string DefaultAudioType = unchecked((string) "32 bit float mono audio");
        [NativeName("Type", "")]
        [NativeName("Name", "JACK_DEFAULT_MIDI_TYPE")]
        public const string DefaultMidiType = unchecked((string) "8 bit raw midi");

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_release_timebase")]
        public unsafe partial int ReleaseTimebase(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_release_timebase")]
        public partial int ReleaseTimebase(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_sync_callback")]
        public unsafe partial int SetSyncCallback(Client* client, PfnJackSyncCallback sync_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_sync_callback")]
        public unsafe partial int SetSyncCallback<T0>(Client* client, PfnJackSyncCallback sync_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_sync_callback")]
        public unsafe partial int SetSyncCallback(ref Client client, PfnJackSyncCallback sync_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_sync_callback")]
        public partial int SetSyncCallback<T0>(ref Client client, PfnJackSyncCallback sync_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_sync_timeout")]
        public unsafe partial int SetSyncTimeout(Client* client, ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_sync_timeout")]
        public partial int SetSyncTimeout(ref Client client, ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_timebase_callback")]
        public unsafe partial int SetTimebaseCallback(Client* client, int conditional, PfnJackTimebaseCallback timebase_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_timebase_callback")]
        public unsafe partial int SetTimebaseCallback<T0>(Client* client, int conditional, PfnJackTimebaseCallback timebase_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_timebase_callback")]
        public unsafe partial int SetTimebaseCallback(ref Client client, int conditional, PfnJackTimebaseCallback timebase_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_timebase_callback")]
        public partial int SetTimebaseCallback<T0>(ref Client client, int conditional, PfnJackTimebaseCallback timebase_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_locate")]
        public unsafe partial int TransportLocate(Client* client, uint frame);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_locate")]
        public partial int TransportLocate(ref Client client, uint frame);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_query")]
        public unsafe partial TransportStateT TransportQuery([Flow(FlowDirection.In)] Client* client, Position* pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_query")]
        public unsafe partial TransportStateT TransportQuery([Flow(FlowDirection.In)] Client* client, ref Position pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_query")]
        public unsafe partial TransportStateT TransportQuery([Flow(FlowDirection.In)] in Client client, Position* pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_query")]
        public partial TransportStateT TransportQuery([Flow(FlowDirection.In)] in Client client, ref Position pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 16 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_get_current_transport_frame")]
        public unsafe partial uint GetCurrentTransportFrame([Flow(FlowDirection.In)] Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 16 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_get_current_transport_frame")]
        public partial uint GetCurrentTransportFrame([Flow(FlowDirection.In)] in Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_reposition")]
        public unsafe partial int TransportReposition(Client* client, [Flow(FlowDirection.In)] Position* pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_reposition")]
        public unsafe partial int TransportReposition(Client* client, [Flow(FlowDirection.In)] in Position pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_reposition")]
        public unsafe partial int TransportReposition(ref Client client, [Flow(FlowDirection.In)] Position* pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_reposition")]
        public partial int TransportReposition(ref Client client, [Flow(FlowDirection.In)] in Position pos);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_start")]
        public unsafe partial void TransportStart(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_start")]
        public partial void TransportStart(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_stop")]
        public unsafe partial void TransportStop(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_transport_stop")]
        public partial void TransportStop(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_get_transport_info")]
        public unsafe partial void GetTransportInfo(Client* client, TransportInfoT* tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_get_transport_info")]
        public unsafe partial void GetTransportInfo(Client* client, ref TransportInfoT tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_get_transport_info")]
        public unsafe partial void GetTransportInfo(ref Client client, TransportInfoT* tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_get_transport_info")]
        public partial void GetTransportInfo(ref Client client, ref TransportInfoT tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_transport_info")]
        public unsafe partial void SetTransportInfo(Client* client, TransportInfoT* tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_transport_info")]
        public unsafe partial void SetTransportInfo(Client* client, ref TransportInfoT tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_transport_info")]
        public unsafe partial void SetTransportInfo(ref Client client, TransportInfoT* tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        [NativeApi(EntryPoint = "jack_set_transport_info")]
        public partial void SetTransportInfo(ref Client client, ref TransportInfoT tinfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, int* minor_ptr, int* micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, int* minor_ptr, int* micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, int* minor_ptr, ref int micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, int* minor_ptr, ref int micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, ref int minor_ptr, int* micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, ref int minor_ptr, int* micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, ref int minor_ptr, ref int micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(int* major_ptr, ref int minor_ptr, ref int micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, int* minor_ptr, int* micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, int* minor_ptr, int* micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, int* minor_ptr, ref int micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, int* minor_ptr, ref int micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, ref int minor_ptr, int* micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, ref int minor_ptr, int* micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public unsafe partial void GetVersion(ref int major_ptr, ref int minor_ptr, ref int micro_ptr, int* proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version")]
        public partial void GetVersion(ref int major_ptr, ref int minor_ptr, ref int micro_ptr, ref int proto_ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 1 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_version_string")]
        public unsafe partial byte* GetVersionString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 1 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_version_string")]
        public partial string GetVersionStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_open")]
        public unsafe partial Client* ClientOpen([Flow(FlowDirection.In)] byte* client_name, JackOptions options, JackStatus* status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_open")]
        public unsafe partial Client* ClientOpen([Flow(FlowDirection.In)] byte* client_name, JackOptions options, ref JackStatus status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_open")]
        public unsafe partial Client* ClientOpen([Flow(FlowDirection.In)] in byte client_name, JackOptions options, JackStatus* status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_open")]
        public unsafe partial Client* ClientOpen([Flow(FlowDirection.In)] in byte client_name, JackOptions options, ref JackStatus status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_open")]
        public unsafe partial Client* ClientOpen([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, JackOptions options, JackStatus* status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_open")]
        public unsafe partial Client* ClientOpen([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, JackOptions options, ref JackStatus status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_new")]
        public unsafe partial Client* ClientNew([Flow(FlowDirection.In)] byte* client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_new")]
        public unsafe partial Client* ClientNew([Flow(FlowDirection.In)] in byte client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 17 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_new")]
        public unsafe partial Client* ClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_close")]
        public unsafe partial int ClientClose(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_close")]
        public partial int ClientClose(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_name_size")]
        public partial int ClientNameSize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name")]
        public unsafe partial byte* GetClientName(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 8 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name")]
        public unsafe partial string GetClientNameS(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name")]
        public unsafe partial byte* GetClientName(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 8 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name")]
        public partial string GetClientNameS(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial byte* GetUuidForClientName(Client* client, [Flow(FlowDirection.In)] byte* client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial string GetUuidForClientNameS(Client* client, [Flow(FlowDirection.In)] byte* client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial byte* GetUuidForClientName(Client* client, [Flow(FlowDirection.In)] in byte client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial string GetUuidForClientNameS(Client* client, [Flow(FlowDirection.In)] in byte client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial byte* GetUuidForClientName(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial string GetUuidForClientNameS(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial byte* GetUuidForClientName(ref Client client, [Flow(FlowDirection.In)] byte* client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial string GetUuidForClientNameS(ref Client client, [Flow(FlowDirection.In)] byte* client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial byte* GetUuidForClientName(ref Client client, [Flow(FlowDirection.In)] in byte client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public partial string GetUuidForClientNameS(ref Client client, [Flow(FlowDirection.In)] in byte client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public unsafe partial byte* GetUuidForClientName(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_uuid_for_client_name")]
        public partial string GetUuidForClientNameS(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial byte* GetClientNameByUuid(Client* client, [Flow(FlowDirection.In)] byte* client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial string GetClientNameByUuidS(Client* client, [Flow(FlowDirection.In)] byte* client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial byte* GetClientNameByUuid(Client* client, [Flow(FlowDirection.In)] in byte client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial string GetClientNameByUuidS(Client* client, [Flow(FlowDirection.In)] in byte client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial byte* GetClientNameByUuid(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial string GetClientNameByUuidS(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial byte* GetClientNameByUuid(ref Client client, [Flow(FlowDirection.In)] byte* client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial string GetClientNameByUuidS(ref Client client, [Flow(FlowDirection.In)] byte* client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial byte* GetClientNameByUuid(ref Client client, [Flow(FlowDirection.In)] in byte client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public partial string GetClientNameByUuidS(ref Client client, [Flow(FlowDirection.In)] in byte client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public unsafe partial byte* GetClientNameByUuid(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_get_client_name_by_uuid")]
        public partial string GetClientNameByUuidS(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_uuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In)] in byte client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] in byte load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public unsafe partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] byte* load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] in byte load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_new")]
        public partial int InternalClientNew([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_close")]
        public unsafe partial void InternalClientClose([Flow(FlowDirection.In)] byte* client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_close")]
        public partial void InternalClientClose([Flow(FlowDirection.In)] in byte client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_internal_client_close")]
        public partial void InternalClientClose([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_activate")]
        public unsafe partial int Activate(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_activate")]
        public partial int Activate(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_deactivate")]
        public unsafe partial int Deactivate(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_deactivate")]
        public partial int Deactivate(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_pid")]
        public unsafe partial int GetClientPid([Flow(FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_pid")]
        public partial int GetClientPid([Flow(FlowDirection.In)] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_client_pid")]
        public partial int GetClientPid([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 22 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_thread_id")]
        public unsafe partial void* ClientThreadId(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 22 in jack.h")]
        [NativeApi(EntryPoint = "jack_client_thread_id")]
        public unsafe partial void* ClientThreadId(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_is_realtime")]
        public unsafe partial int IsRealtime(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_is_realtime")]
        public partial int IsRealtime(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 255, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_thread_wait")]
        public unsafe partial uint ThreadWait(Client* client, int status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 255, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_thread_wait")]
        public partial uint ThreadWait(ref Client client, int status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_cycle_wait")]
        public unsafe partial uint CycleWait(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_cycle_wait")]
        public partial uint CycleWait(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_cycle_signal")]
        public unsafe partial void CycleSignal(Client* client, int status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_cycle_signal")]
        public partial void CycleSignal(ref Client client, int status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_thread")]
        public unsafe partial int SetProcessThread(Client* client, PfnJackThreadCallback thread_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_thread")]
        public unsafe partial int SetProcessThread<T0>(Client* client, PfnJackThreadCallback thread_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_thread")]
        public unsafe partial int SetProcessThread(ref Client client, PfnJackThreadCallback thread_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_thread")]
        public partial int SetProcessThread<T0>(ref Client client, PfnJackThreadCallback thread_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_thread_init_callback")]
        public unsafe partial int SetThreadInitCallback(Client* client, PfnJackThreadInitCallback thread_init_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_thread_init_callback")]
        public unsafe partial int SetThreadInitCallback<T0>(Client* client, PfnJackThreadInitCallback thread_init_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_thread_init_callback")]
        public unsafe partial int SetThreadInitCallback(ref Client client, PfnJackThreadInitCallback thread_init_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_thread_init_callback")]
        public partial int SetThreadInitCallback<T0>(ref Client client, PfnJackThreadInitCallback thread_init_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_shutdown")]
        public unsafe partial void OnShutdown(Client* client, PfnJackThreadInitCallback shutdown_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_shutdown")]
        public unsafe partial void OnShutdown<T0>(Client* client, PfnJackThreadInitCallback shutdown_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_shutdown")]
        public unsafe partial void OnShutdown(ref Client client, PfnJackThreadInitCallback shutdown_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_shutdown")]
        public partial void OnShutdown<T0>(ref Client client, PfnJackThreadInitCallback shutdown_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_info_shutdown")]
        public unsafe partial void OnInfoShutdown(Client* client, PfnJackInfoShutdownCallback shutdown_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_info_shutdown")]
        public unsafe partial void OnInfoShutdown<T0>(Client* client, PfnJackInfoShutdownCallback shutdown_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_info_shutdown")]
        public unsafe partial void OnInfoShutdown(ref Client client, PfnJackInfoShutdownCallback shutdown_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_on_info_shutdown")]
        public partial void OnInfoShutdown<T0>(ref Client client, PfnJackInfoShutdownCallback shutdown_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_callback")]
        public unsafe partial int SetProcessCallback(Client* client, PfnJackProcessCallback process_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_callback")]
        public unsafe partial int SetProcessCallback<T0>(Client* client, PfnJackProcessCallback process_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_callback")]
        public unsafe partial int SetProcessCallback(ref Client client, PfnJackProcessCallback process_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_process_callback")]
        public partial int SetProcessCallback<T0>(ref Client client, PfnJackProcessCallback process_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_freewheel_callback")]
        public unsafe partial int SetFreewheelCallback(Client* client, PfnJackFreewheelCallback freewheel_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_freewheel_callback")]
        public unsafe partial int SetFreewheelCallback<T0>(Client* client, PfnJackFreewheelCallback freewheel_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_freewheel_callback")]
        public unsafe partial int SetFreewheelCallback(ref Client client, PfnJackFreewheelCallback freewheel_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_freewheel_callback")]
        public partial int SetFreewheelCallback<T0>(ref Client client, PfnJackFreewheelCallback freewheel_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_buffer_size_callback")]
        public unsafe partial int SetBufferSizeCallback(Client* client, PfnJackProcessCallback bufsize_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_buffer_size_callback")]
        public unsafe partial int SetBufferSizeCallback<T0>(Client* client, PfnJackProcessCallback bufsize_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_buffer_size_callback")]
        public unsafe partial int SetBufferSizeCallback(ref Client client, PfnJackProcessCallback bufsize_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_buffer_size_callback")]
        public partial int SetBufferSizeCallback<T0>(ref Client client, PfnJackProcessCallback bufsize_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_sample_rate_callback")]
        public unsafe partial int SetSampleRateCallback(Client* client, PfnJackProcessCallback srate_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_sample_rate_callback")]
        public unsafe partial int SetSampleRateCallback<T0>(Client* client, PfnJackProcessCallback srate_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_sample_rate_callback")]
        public unsafe partial int SetSampleRateCallback(ref Client client, PfnJackProcessCallback srate_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_sample_rate_callback")]
        public partial int SetSampleRateCallback<T0>(ref Client client, PfnJackProcessCallback srate_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_client_registration_callback")]
        public unsafe partial int SetClientRegistrationCallback(Client* client, PfnJackClientRegistrationCallback registration_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_client_registration_callback")]
        public unsafe partial int SetClientRegistrationCallback<T0>(Client* client, PfnJackClientRegistrationCallback registration_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_client_registration_callback")]
        public unsafe partial int SetClientRegistrationCallback(ref Client client, PfnJackClientRegistrationCallback registration_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_client_registration_callback")]
        public partial int SetClientRegistrationCallback<T0>(ref Client client, PfnJackClientRegistrationCallback registration_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_registration_callback")]
        public unsafe partial int SetPortRegistrationCallback(Client* client, PfnJackPortRegistrationCallback registration_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_registration_callback")]
        public unsafe partial int SetPortRegistrationCallback<T0>(Client* client, PfnJackPortRegistrationCallback registration_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_registration_callback")]
        public unsafe partial int SetPortRegistrationCallback(ref Client client, PfnJackPortRegistrationCallback registration_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_registration_callback")]
        public partial int SetPortRegistrationCallback<T0>(ref Client client, PfnJackPortRegistrationCallback registration_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_connect_callback")]
        public unsafe partial int SetPortConnectCallback(Client* client, PfnJackPortConnectCallback connect_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_connect_callback")]
        public unsafe partial int SetPortConnectCallback<T0>(Client* client, PfnJackPortConnectCallback connect_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_connect_callback")]
        public unsafe partial int SetPortConnectCallback(ref Client client, PfnJackPortConnectCallback connect_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_connect_callback")]
        public partial int SetPortConnectCallback<T0>(ref Client client, PfnJackPortConnectCallback connect_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_rename_callback")]
        public unsafe partial int SetPortRenameCallback(Client* client, PfnJackPortRenameCallback rename_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_rename_callback")]
        public unsafe partial int SetPortRenameCallback<T0>(Client* client, PfnJackPortRenameCallback rename_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_rename_callback")]
        public unsafe partial int SetPortRenameCallback(ref Client client, PfnJackPortRenameCallback rename_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_port_rename_callback")]
        public partial int SetPortRenameCallback<T0>(ref Client client, PfnJackPortRenameCallback rename_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_graph_order_callback")]
        public unsafe partial int SetGraphOrderCallback(Client* client, PfnJackGraphOrderCallback graph_callback, void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_graph_order_callback")]
        public unsafe partial int SetGraphOrderCallback<T0>(Client* client, PfnJackGraphOrderCallback graph_callback, ref T0 arg2) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_graph_order_callback")]
        public unsafe partial int SetGraphOrderCallback(ref Client client, PfnJackGraphOrderCallback graph_callback, void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_graph_order_callback")]
        public partial int SetGraphOrderCallback<T0>(ref Client client, PfnJackGraphOrderCallback graph_callback, ref T0 arg2) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_xrun_callback")]
        public unsafe partial int SetXrunCallback(Client* client, PfnJackGraphOrderCallback xrun_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_xrun_callback")]
        public unsafe partial int SetXrunCallback<T0>(Client* client, PfnJackGraphOrderCallback xrun_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_xrun_callback")]
        public unsafe partial int SetXrunCallback(ref Client client, PfnJackGraphOrderCallback xrun_callback, void* arg);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_xrun_callback")]
        public partial int SetXrunCallback<T0>(ref Client client, PfnJackGraphOrderCallback xrun_callback, ref T0 arg) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_latency_callback")]
        public unsafe partial int SetLatencyCallback(Client* client, PfnJackLatencyCallback latency_callback, void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_latency_callback")]
        public unsafe partial int SetLatencyCallback<T0>(Client* client, PfnJackLatencyCallback latency_callback, ref T0 arg2) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_latency_callback")]
        public unsafe partial int SetLatencyCallback(ref Client client, PfnJackLatencyCallback latency_callback, void* arg2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_latency_callback")]
        public partial int SetLatencyCallback<T0>(ref Client client, PfnJackLatencyCallback latency_callback, ref T0 arg2) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_freewheel")]
        public unsafe partial int SetFreewheel(Client* client, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_freewheel")]
        public partial int SetFreewheel(ref Client client, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 668, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_buffer_size")]
        public unsafe partial int SetBufferSize(Client* client, uint nframes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 668, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_buffer_size")]
        public partial int SetBufferSize(ref Client client, uint nframes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 674, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_sample_rate")]
        public unsafe partial uint GetSampleRate(Client* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 674, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_sample_rate")]
        public partial uint GetSampleRate(ref Client arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_buffer_size")]
        public unsafe partial uint GetBufferSize(Client* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_buffer_size")]
        public partial uint GetBufferSize(ref Client arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_engine_takeover_timebase")]
        public unsafe partial int EngineTakeoverTimebase(Client* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_engine_takeover_timebase")]
        public partial int EngineTakeoverTimebase(ref Client arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_cpu_load")]
        public unsafe partial float CpuLoad(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 7 in jack.h")]
        [NativeApi(EntryPoint = "jack_cpu_load")]
        public partial float CpuLoad(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] in byte port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In)] in byte port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In)] in byte port_name, [Flow(FlowDirection.In)] in byte port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In)] in byte port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] in byte port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] in byte port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In)] in byte port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In)] in byte port_name, [Flow(FlowDirection.In)] in byte port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In)] in byte port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] in byte port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_register")]
        public unsafe partial Port* PortRegister(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unregister")]
        public unsafe partial int PortUnregister(Client* client, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unregister")]
        public unsafe partial int PortUnregister(Client* client, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unregister")]
        public unsafe partial int PortUnregister(ref Client client, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unregister")]
        public partial int PortUnregister(ref Client client, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_buffer")]
        public unsafe partial void* PortGetBuffer(Port* port, uint arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_buffer")]
        public unsafe partial void* PortGetBuffer(ref Port port, uint arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 783, Column 13 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_uuid")]
        public unsafe partial ulong PortUuid([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 783, Column 13 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_uuid")]
        public partial ulong PortUuid([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 14 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_name")]
        public unsafe partial byte* PortName([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 14 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_port_name")]
        public unsafe partial string PortNameS([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 14 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_name")]
        public unsafe partial byte* PortName([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 14 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_port_name")]
        public partial string PortNameS([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 799, Column 14 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_short_name")]
        public unsafe partial byte* PortShortName([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 799, Column 14 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_port_short_name")]
        public unsafe partial string PortShortNameS([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 799, Column 14 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_short_name")]
        public unsafe partial byte* PortShortName([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 799, Column 14 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_port_short_name")]
        public partial string PortShortNameS([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 804, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_flags")]
        public unsafe partial int PortFlags([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 804, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_flags")]
        public partial int PortFlags([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 14 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type")]
        public unsafe partial byte* PortType([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 14 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_port_type")]
        public unsafe partial string PortTypeS([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 14 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type")]
        public unsafe partial byte* PortType([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 14 in jack.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "jack_port_type")]
        public partial string PortTypeS([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 815, Column 21 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_id")]
        public unsafe partial uint PortTypeId([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 815, Column 21 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_id")]
        public partial uint PortTypeId([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_is_mine")]
        public unsafe partial int PortIsMine([Flow(FlowDirection.In)] Client* client, [Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_is_mine")]
        public unsafe partial int PortIsMine([Flow(FlowDirection.In)] Client* client, [Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_is_mine")]
        public unsafe partial int PortIsMine([Flow(FlowDirection.In)] in Client client, [Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_is_mine")]
        public partial int PortIsMine([Flow(FlowDirection.In)] in Client client, [Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected")]
        public unsafe partial int PortConnected([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected")]
        public partial int PortConnected([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected_to")]
        public unsafe partial int PortConnectedTo([Flow(FlowDirection.In)] Port* port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected_to")]
        public unsafe partial int PortConnectedTo([Flow(FlowDirection.In)] Port* port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected_to")]
        public unsafe partial int PortConnectedTo([Flow(FlowDirection.In)] Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected_to")]
        public unsafe partial int PortConnectedTo([Flow(FlowDirection.In)] in Port port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected_to")]
        public partial int PortConnectedTo([Flow(FlowDirection.In)] in Port port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_connected_to")]
        public partial int PortConnectedTo([Flow(FlowDirection.In)] in Port port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_connections")]
        public unsafe partial byte** PortGetConnections([Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_connections")]
        public unsafe partial byte** PortGetConnections([Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_all_connections")]
        public unsafe partial byte** PortGetAllConnections([Flow(FlowDirection.In)] Client* client, [Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_all_connections")]
        public unsafe partial byte** PortGetAllConnections([Flow(FlowDirection.In)] Client* client, [Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_all_connections")]
        public unsafe partial byte** PortGetAllConnections([Flow(FlowDirection.In)] in Client client, [Flow(FlowDirection.In)] Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_all_connections")]
        public unsafe partial byte** PortGetAllConnections([Flow(FlowDirection.In)] in Client client, [Flow(FlowDirection.In)] in Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_tie")]
        public unsafe partial int PortTie(Port* src, Port* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_tie")]
        public unsafe partial int PortTie(Port* src, ref Port dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_tie")]
        public unsafe partial int PortTie(ref Port src, Port* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_tie")]
        public partial int PortTie(ref Port src, ref Port dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_untie")]
        public unsafe partial int PortUntie(Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_untie")]
        public partial int PortUntie(ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_name")]
        public unsafe partial int PortSetName(Port* port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_name")]
        public unsafe partial int PortSetName(Port* port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_name")]
        public unsafe partial int PortSetName(Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_name")]
        public unsafe partial int PortSetName(ref Port port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_name")]
        public partial int PortSetName(ref Port port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_name")]
        public partial int PortSetName(ref Port port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(Client* client, Port* port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(Client* client, Port* port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(Client* client, Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(Client* client, ref Port port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(Client* client, ref Port port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(Client* client, ref Port port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(ref Client client, Port* port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(ref Client client, Port* port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(ref Client client, Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public unsafe partial int PortRename(ref Client client, ref Port port, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public partial int PortRename(ref Client client, ref Port port, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_rename")]
        public partial int PortRename(ref Client client, ref Port port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_alias")]
        public unsafe partial int PortSetAlias(Port* port, [Flow(FlowDirection.In)] byte* alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_alias")]
        public unsafe partial int PortSetAlias(Port* port, [Flow(FlowDirection.In)] in byte alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_alias")]
        public unsafe partial int PortSetAlias(Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_alias")]
        public unsafe partial int PortSetAlias(ref Port port, [Flow(FlowDirection.In)] byte* alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_alias")]
        public partial int PortSetAlias(ref Port port, [Flow(FlowDirection.In)] in byte alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_alias")]
        public partial int PortSetAlias(ref Port port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unset_alias")]
        public unsafe partial int PortUnsetAlias(Port* port, [Flow(FlowDirection.In)] byte* alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unset_alias")]
        public unsafe partial int PortUnsetAlias(Port* port, [Flow(FlowDirection.In)] in byte alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unset_alias")]
        public unsafe partial int PortUnsetAlias(Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unset_alias")]
        public unsafe partial int PortUnsetAlias(ref Port port, [Flow(FlowDirection.In)] byte* alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unset_alias")]
        public partial int PortUnsetAlias(ref Port port, [Flow(FlowDirection.In)] in byte alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_unset_alias")]
        public partial int PortUnsetAlias(ref Port port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alias);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_aliases")]
        public unsafe partial int PortGetAliases([Flow(FlowDirection.In)] Port* port, [Count(Count = 2), Flow(FlowDirection.In)] byte** aliases);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_aliases")]
        public unsafe partial int PortGetAliases([Flow(FlowDirection.In)] Port* port, [Count(Count = 2), Flow(FlowDirection.In)] in byte* aliases);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_aliases")]
        public unsafe partial int PortGetAliases([Flow(FlowDirection.In)] in Port port, [Count(Count = 2), Flow(FlowDirection.In)] byte** aliases);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_aliases")]
        public unsafe partial int PortGetAliases([Flow(FlowDirection.In)] in Port port, [Count(Count = 2), Flow(FlowDirection.In)] in byte* aliases);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor")]
        public unsafe partial int PortRequestMonitor(Port* port, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor")]
        public partial int PortRequestMonitor(ref Port port, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor_by_name")]
        public unsafe partial int PortRequestMonitorByName(Client* client, [Flow(FlowDirection.In)] byte* port_name, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor_by_name")]
        public unsafe partial int PortRequestMonitorByName(Client* client, [Flow(FlowDirection.In)] in byte port_name, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor_by_name")]
        public unsafe partial int PortRequestMonitorByName(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor_by_name")]
        public unsafe partial int PortRequestMonitorByName(ref Client client, [Flow(FlowDirection.In)] byte* port_name, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor_by_name")]
        public partial int PortRequestMonitorByName(ref Client client, [Flow(FlowDirection.In)] in byte port_name, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_request_monitor_by_name")]
        public partial int PortRequestMonitorByName(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_ensure_monitor")]
        public unsafe partial int PortEnsureMonitor(Port* port, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_ensure_monitor")]
        public partial int PortEnsureMonitor(ref Port port, int onoff);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 976, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_monitoring_input")]
        public unsafe partial int PortMonitoringInput(Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 976, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_monitoring_input")]
        public partial int PortMonitoringInput(ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(ref Client client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(ref Client client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(ref Client client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(ref Client client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public partial int Connect(ref Client client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public partial int Connect(ref Client client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public unsafe partial int Connect(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public partial int Connect(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_connect")]
        public partial int Connect(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(ref Client client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(ref Client client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(ref Client client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(ref Client client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public partial int Disconnect(ref Client client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public partial int Disconnect(ref Client client, [Flow(FlowDirection.In)] in byte source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public unsafe partial int Disconnect(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] byte* destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public partial int Disconnect(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] in byte destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_disconnect")]
        public partial int Disconnect(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_disconnect")]
        public unsafe partial int PortDisconnect(Client* client, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_disconnect")]
        public unsafe partial int PortDisconnect(Client* client, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_disconnect")]
        public unsafe partial int PortDisconnect(ref Client client, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_disconnect")]
        public partial int PortDisconnect(ref Client client, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_name_size")]
        public partial int PortNameSize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1041, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_size")]
        public partial int PortTypeSize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_get_buffer_size")]
        public unsafe partial nuint PortTypeGetBufferSize(Client* client, [Flow(FlowDirection.In)] byte* port_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_get_buffer_size")]
        public unsafe partial nuint PortTypeGetBufferSize(Client* client, [Flow(FlowDirection.In)] in byte port_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_get_buffer_size")]
        public unsafe partial nuint PortTypeGetBufferSize(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_get_buffer_size")]
        public unsafe partial nuint PortTypeGetBufferSize(ref Client client, [Flow(FlowDirection.In)] byte* port_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_get_buffer_size")]
        public partial nuint PortTypeGetBufferSize(ref Client client, [Flow(FlowDirection.In)] in byte port_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_type_get_buffer_size")]
        public partial nuint PortTypeGetBufferSize(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_latency")]
        public unsafe partial void PortSetLatency(Port* port, uint arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_latency")]
        public partial void PortSetLatency(ref Port port, uint arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_latency_range")]
        public unsafe partial void PortGetLatencyRange(Port* port, JackLatencyCallbackMode mode, LatencyRange* range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_latency_range")]
        public unsafe partial void PortGetLatencyRange(Port* port, JackLatencyCallbackMode mode, ref LatencyRange range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_latency_range")]
        public unsafe partial void PortGetLatencyRange(ref Port port, JackLatencyCallbackMode mode, LatencyRange* range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_latency_range")]
        public partial void PortGetLatencyRange(ref Port port, JackLatencyCallbackMode mode, ref LatencyRange range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_latency_range")]
        public unsafe partial void PortSetLatencyRange(Port* port, JackLatencyCallbackMode mode, LatencyRange* range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_latency_range")]
        public unsafe partial void PortSetLatencyRange(Port* port, JackLatencyCallbackMode mode, ref LatencyRange range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_latency_range")]
        public unsafe partial void PortSetLatencyRange(ref Port port, JackLatencyCallbackMode mode, LatencyRange* range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_set_latency_range")]
        public partial void PortSetLatencyRange(ref Port port, JackLatencyCallbackMode mode, ref LatencyRange range);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_recompute_total_latencies")]
        public unsafe partial int RecomputeTotalLatencies(Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_recompute_total_latencies")]
        public partial int RecomputeTotalLatencies(ref Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_latency")]
        public unsafe partial uint PortGetLatency(Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_latency")]
        public partial uint PortGetLatency(ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_total_latency")]
        public unsafe partial uint PortGetTotalLatency(Client* client, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_total_latency")]
        public unsafe partial uint PortGetTotalLatency(Client* client, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_total_latency")]
        public unsafe partial uint PortGetTotalLatency(ref Client client, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_get_total_latency")]
        public partial uint PortGetTotalLatency(ref Client client, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_recompute_total_latency")]
        public unsafe partial int RecomputeTotalLatency(Client* arg0, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_recompute_total_latency")]
        public unsafe partial int RecomputeTotalLatency(Client* arg0, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_recompute_total_latency")]
        public unsafe partial int RecomputeTotalLatency(ref Client arg0, Port* port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_recompute_total_latency")]
        public partial int RecomputeTotalLatency(ref Client arg0, ref Port port);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] in byte type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In)] in byte port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In)] in byte port_name_pattern, [Flow(FlowDirection.In)] in byte type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In)] in byte port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] in byte type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] in byte type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In)] in byte port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In)] in byte port_name_pattern, [Flow(FlowDirection.In)] in byte type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In)] in byte port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] in byte type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_ports")]
        public unsafe partial byte** GetPorts(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_name")]
        public unsafe partial Port* PortByName(Client* client, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_name")]
        public unsafe partial Port* PortByName(Client* client, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_name")]
        public unsafe partial Port* PortByName(Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_name")]
        public unsafe partial Port* PortByName(ref Client client, [Flow(FlowDirection.In)] byte* port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_name")]
        public unsafe partial Port* PortByName(ref Client client, [Flow(FlowDirection.In)] in byte port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_name")]
        public unsafe partial Port* PortByName(ref Client client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_id")]
        public unsafe partial Port* PortById(Client* client, uint port_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 15 in jack.h")]
        [NativeApi(EntryPoint = "jack_port_by_id")]
        public unsafe partial Port* PortById(ref Client client, uint port_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_frames_since_cycle_start")]
        public unsafe partial uint FramesSinceCycleStart([Flow(FlowDirection.In)] Client* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_frames_since_cycle_start")]
        public partial uint FramesSinceCycleStart([Flow(FlowDirection.In)] in Client arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1328, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_frame_time")]
        public unsafe partial uint FrameTime([Flow(FlowDirection.In)] Client* arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1328, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_frame_time")]
        public partial uint FrameTime([Flow(FlowDirection.In)] in Client arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_last_frame_time")]
        public unsafe partial uint LastFrameTime([Flow(FlowDirection.In)] Client* client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_last_frame_time")]
        public partial uint LastFrameTime([Flow(FlowDirection.In)] in Client client);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ref ulong current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ref ulong current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ref ulong current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, uint* current_frames, ref ulong current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ulong* current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ulong* current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ulong* current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ref ulong current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ref ulong current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ref ulong current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] Client* client, ref uint current_frames, ref ulong current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ulong* current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ulong* current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ref ulong current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ref ulong current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ref ulong current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, uint* current_frames, ref ulong current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ulong* current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ulong* current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ulong* current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ref ulong current_usecs, ulong* next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ref ulong current_usecs, ulong* next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public unsafe partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ref ulong current_usecs, ref ulong next_usecs, float* period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_cycle_times")]
        public partial int GetCycleTimes([Flow(FlowDirection.In)] in Client client, ref uint current_frames, ref ulong current_usecs, ref ulong next_usecs, ref float period_usecs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1398, Column 13 in jack.h")]
        [NativeApi(EntryPoint = "jack_frames_to_time")]
        public unsafe partial ulong FramesToTime([Flow(FlowDirection.In)] Client* client, uint arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1398, Column 13 in jack.h")]
        [NativeApi(EntryPoint = "jack_frames_to_time")]
        public partial ulong FramesToTime([Flow(FlowDirection.In)] in Client client, uint arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_time_to_frames")]
        public unsafe partial uint TimeToFrames([Flow(FlowDirection.In)] Client* client, ulong arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 16 in jack.h")]
        [NativeApi(EntryPoint = "jack_time_to_frames")]
        public partial uint TimeToFrames([Flow(FlowDirection.In)] in Client client, ulong arg1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 13 in jack.h")]
        [NativeApi(EntryPoint = "jack_get_time")]
        public partial ulong GetTime();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_error_function")]
        public partial void SetErrorFunction(PfnBvV func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1456, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_set_info_function")]
        public partial void SetInfoFunction(PfnBvV func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_free")]
        public unsafe partial void Free(void* ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 6 in jack.h")]
        [NativeApi(EntryPoint = "jack_free")]
        public partial void Free<T0>(ref T0 ptr) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        public unsafe int PortGetAliases([Flow(FlowDirection.In)] Port* port, [Count(Count = 2), Flow(FlowDirection.In)] string[] aliasesSa)
        {
            // StringArrayOverloader
            var aliases = (byte**) SilkMarshal.StringArrayToPtr(aliasesSa);
            var ret = PortGetAliases(port, aliases);
            SilkMarshal.CopyPtrToStringArray((nint) aliases, aliasesSa);
            SilkMarshal.Free((nint) aliases);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        public unsafe int PortGetAliases([Flow(FlowDirection.In)] in Port port, [Count(Count = 2), Flow(FlowDirection.In)] string[] aliasesSa)
        {
            // StringArrayOverloader
            var aliases = (byte**) SilkMarshal.StringArrayToPtr(aliasesSa);
            var ret = PortGetAliases(in port, aliases);
            SilkMarshal.CopyPtrToStringArray((nint) aliases, aliasesSa);
            SilkMarshal.Free((nint) aliases);
            return ret;
        }


        public Jack(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

