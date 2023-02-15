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
    public static class JackOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int ReleaseTimebase(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.ReleaseTimebase(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetSyncCallback<T0>(this Jack thisApi, Client* client, PfnJackSyncCallback sync_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetSyncCallback(client, sync_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetSyncCallback(this Jack thisApi, Span<Client> client, PfnJackSyncCallback sync_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetSyncCallback(ref client.GetPinnableReference(), sync_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetSyncCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackSyncCallback sync_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetSyncCallback(ref client.GetPinnableReference(), sync_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetSyncTimeout(this Jack thisApi, Span<Client> client, ulong timeout)
        {
            // SpanOverloader
            return thisApi.SetSyncTimeout(ref client.GetPinnableReference(), timeout);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetTimebaseCallback<T0>(this Jack thisApi, Client* client, int conditional, PfnJackTimebaseCallback timebase_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetTimebaseCallback(client, conditional, timebase_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetTimebaseCallback(this Jack thisApi, Span<Client> client, int conditional, PfnJackTimebaseCallback timebase_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetTimebaseCallback(ref client.GetPinnableReference(), conditional, timebase_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int SetTimebaseCallback<T0>(this Jack thisApi, Span<Client> client, int conditional, PfnJackTimebaseCallback timebase_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetTimebaseCallback(ref client.GetPinnableReference(), conditional, timebase_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int TransportLocate(this Jack thisApi, Span<Client> client, uint frame)
        {
            // SpanOverloader
            return thisApi.TransportLocate(ref client.GetPinnableReference(), frame);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        public static unsafe TransportStateT TransportQuery(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<Position> pos)
        {
            // SpanOverloader
            return thisApi.TransportQuery(client, ref pos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        public static unsafe TransportStateT TransportQuery(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Position* pos)
        {
            // SpanOverloader
            return thisApi.TransportQuery(in client.GetPinnableReference(), pos);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 24 in jack2/common\\jack/transport.h")]
        public static unsafe TransportStateT TransportQuery(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<Position> pos)
        {
            // SpanOverloader
            return thisApi.TransportQuery(in client.GetPinnableReference(), ref pos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 172, Column 16 in jack2/common\\jack/transport.h")]
        public static unsafe uint GetCurrentTransportFrame(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client)
        {
            // SpanOverloader
            return thisApi.GetCurrentTransportFrame(in client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int TransportReposition(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<Position> pos)
        {
            // SpanOverloader
            return thisApi.TransportReposition(client, in pos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int TransportReposition(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] Position* pos)
        {
            // SpanOverloader
            return thisApi.TransportReposition(ref client.GetPinnableReference(), pos);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe int TransportReposition(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<Position> pos)
        {
            // SpanOverloader
            return thisApi.TransportReposition(ref client.GetPinnableReference(), in pos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void TransportStart(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            thisApi.TransportStart(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void TransportStop(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            thisApi.TransportStop(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void GetTransportInfo(this Jack thisApi, Client* client, Span<TransportInfoT> tinfo)
        {
            // SpanOverloader
            thisApi.GetTransportInfo(client, ref tinfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void GetTransportInfo(this Jack thisApi, Span<Client> client, TransportInfoT* tinfo)
        {
            // SpanOverloader
            thisApi.GetTransportInfo(ref client.GetPinnableReference(), tinfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void GetTransportInfo(this Jack thisApi, Span<Client> client, Span<TransportInfoT> tinfo)
        {
            // SpanOverloader
            thisApi.GetTransportInfo(ref client.GetPinnableReference(), ref tinfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void SetTransportInfo(this Jack thisApi, Client* client, Span<TransportInfoT> tinfo)
        {
            // SpanOverloader
            thisApi.SetTransportInfo(client, ref tinfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void SetTransportInfo(this Jack thisApi, Span<Client> client, TransportInfoT* tinfo)
        {
            // SpanOverloader
            thisApi.SetTransportInfo(ref client.GetPinnableReference(), tinfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 6 in jack2/common\\jack/transport.h")]
        public static unsafe void SetTransportInfo(this Jack thisApi, Span<Client> client, Span<TransportInfoT> tinfo)
        {
            // SpanOverloader
            thisApi.SetTransportInfo(ref client.GetPinnableReference(), ref tinfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, int* minor_ptr, int* micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, minor_ptr, micro_ptr, ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, int* minor_ptr, Span<int> micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, minor_ptr, ref micro_ptr.GetPinnableReference(), proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, int* minor_ptr, Span<int> micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, minor_ptr, ref micro_ptr.GetPinnableReference(), ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, Span<int> minor_ptr, int* micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, ref minor_ptr.GetPinnableReference(), micro_ptr, proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, Span<int> minor_ptr, int* micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, ref minor_ptr.GetPinnableReference(), micro_ptr, ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, Span<int> minor_ptr, Span<int> micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, ref minor_ptr.GetPinnableReference(), ref micro_ptr.GetPinnableReference(), proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, int* major_ptr, Span<int> minor_ptr, Span<int> micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(major_ptr, ref minor_ptr.GetPinnableReference(), ref micro_ptr.GetPinnableReference(), ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, int* minor_ptr, int* micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), minor_ptr, micro_ptr, proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, int* minor_ptr, int* micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), minor_ptr, micro_ptr, ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, int* minor_ptr, Span<int> micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), minor_ptr, ref micro_ptr.GetPinnableReference(), proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, int* minor_ptr, Span<int> micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), minor_ptr, ref micro_ptr.GetPinnableReference(), ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, Span<int> minor_ptr, int* micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), ref minor_ptr.GetPinnableReference(), micro_ptr, proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, Span<int> minor_ptr, int* micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), ref minor_ptr.GetPinnableReference(), micro_ptr, ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, Span<int> minor_ptr, Span<int> micro_ptr, int* proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), ref minor_ptr.GetPinnableReference(), ref micro_ptr.GetPinnableReference(), proto_ptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in jack.h")]
        public static unsafe void GetVersion(this Jack thisApi, Span<int> major_ptr, Span<int> minor_ptr, Span<int> micro_ptr, Span<int> proto_ptr)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major_ptr.GetPinnableReference(), ref minor_ptr.GetPinnableReference(), ref micro_ptr.GetPinnableReference(), ref proto_ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        public static unsafe Client* ClientOpen(this Jack thisApi, [Flow(FlowDirection.In)] byte* client_name, JackOptions options, Span<JackStatus> status)
        {
            // SpanOverloader
            return thisApi.ClientOpen(client_name, options, ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        public static unsafe Client* ClientOpen(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, JackOptions options, JackStatus* status)
        {
            // SpanOverloader
            return thisApi.ClientOpen(in client_name.GetPinnableReference(), options, status);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        public static unsafe Client* ClientOpen(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, JackOptions options, Span<JackStatus> status)
        {
            // SpanOverloader
            return thisApi.ClientOpen(in client_name.GetPinnableReference(), options, ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 17 in jack.h")]
        public static unsafe Client* ClientOpen(this Jack thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, JackOptions options, Span<JackStatus> status)
        {
            // SpanOverloader
            return thisApi.ClientOpen(client_name, options, ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 17 in jack.h")]
        public static unsafe Client* ClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name)
        {
            // SpanOverloader
            return thisApi.ClientNew(in client_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 5 in jack.h")]
        public static unsafe int ClientClose(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.ClientClose(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 8 in jack.h")]
        public static unsafe byte* GetClientName(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.GetClientName(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        public static unsafe byte* GetUuidForClientName(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name)
        {
            // SpanOverloader
            return thisApi.GetUuidForClientName(client, in client_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        public static unsafe byte* GetUuidForClientName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* client_name)
        {
            // SpanOverloader
            return thisApi.GetUuidForClientName(ref client.GetPinnableReference(), client_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        public static unsafe byte* GetUuidForClientName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name)
        {
            // SpanOverloader
            return thisApi.GetUuidForClientName(ref client.GetPinnableReference(), in client_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 7 in jack.h")]
        public static unsafe byte* GetUuidForClientName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name)
        {
            // SpanOverloader
            return thisApi.GetUuidForClientName(ref client.GetPinnableReference(), client_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        public static unsafe byte* GetClientNameByUuid(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_uuid)
        {
            // SpanOverloader
            return thisApi.GetClientNameByUuid(client, in client_uuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        public static unsafe byte* GetClientNameByUuid(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* client_uuid)
        {
            // SpanOverloader
            return thisApi.GetClientNameByUuid(ref client.GetPinnableReference(), client_uuid);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        public static unsafe byte* GetClientNameByUuid(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_uuid)
        {
            // SpanOverloader
            return thisApi.GetClientNameByUuid(ref client.GetPinnableReference(), in client_uuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 7 in jack.h")]
        public static unsafe byte* GetClientNameByUuid(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_uuid)
        {
            // SpanOverloader
            return thisApi.GetClientNameByUuid(ref client.GetPinnableReference(), client_uuid);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, load_name, in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In)] byte* load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, in load_name.GetPinnableReference(), load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, in load_name.GetPinnableReference(), in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, in load_name.GetPinnableReference(), load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] byte* client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, load_name, in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] byte* load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), load_name, load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), load_name, in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), load_name, load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In)] byte* load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), in load_name.GetPinnableReference(), load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), in load_name.GetPinnableReference(), in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), in load_name.GetPinnableReference(), load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] byte* load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), load_name, load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), load_name, in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(in client_name.GetPinnableReference(), load_name, load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] byte* load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, load_name, in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In)] byte* load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, in load_name.GetPinnableReference(), load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, in load_name.GetPinnableReference(), in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, in load_name.GetPinnableReference(), load_init);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 5 in jack.h")]
        public static unsafe int InternalClientNew(this Jack thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string client_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string load_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> load_init)
        {
            // SpanOverloader
            return thisApi.InternalClientNew(client_name, load_name, in load_init.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 6 in jack.h")]
        public static unsafe void InternalClientClose(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> client_name)
        {
            // SpanOverloader
            thisApi.InternalClientClose(in client_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 5 in jack.h")]
        public static unsafe int Activate(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.Activate(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 5 in jack.h")]
        public static unsafe int Deactivate(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.Deactivate(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 5 in jack.h")]
        public static unsafe int GetClientPid(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetClientPid(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 22 in jack.h")]
        public static unsafe void* ClientThreadId(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.ClientThreadId(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 5 in jack.h")]
        public static unsafe int IsRealtime(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.IsRealtime(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 255, Column 16 in jack.h")]
        public static unsafe uint ThreadWait(this Jack thisApi, Span<Client> client, int status)
        {
            // SpanOverloader
            return thisApi.ThreadWait(ref client.GetPinnableReference(), status);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 16 in jack.h")]
        public static unsafe uint CycleWait(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.CycleWait(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 6 in jack.h")]
        public static unsafe void CycleSignal(this Jack thisApi, Span<Client> client, int status)
        {
            // SpanOverloader
            thisApi.CycleSignal(ref client.GetPinnableReference(), status);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        public static unsafe int SetProcessThread<T0>(this Jack thisApi, Client* client, PfnJackThreadCallback thread_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetProcessThread(client, thread_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        public static unsafe int SetProcessThread(this Jack thisApi, Span<Client> client, PfnJackThreadCallback thread_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetProcessThread(ref client.GetPinnableReference(), thread_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 5 in jack.h")]
        public static unsafe int SetProcessThread<T0>(this Jack thisApi, Span<Client> client, PfnJackThreadCallback thread_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetProcessThread(ref client.GetPinnableReference(), thread_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        public static unsafe int SetThreadInitCallback<T0>(this Jack thisApi, Client* client, PfnJackThreadInitCallback thread_init_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetThreadInitCallback(client, thread_init_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        public static unsafe int SetThreadInitCallback(this Jack thisApi, Span<Client> client, PfnJackThreadInitCallback thread_init_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetThreadInitCallback(ref client.GetPinnableReference(), thread_init_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 5 in jack.h")]
        public static unsafe int SetThreadInitCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackThreadInitCallback thread_init_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetThreadInitCallback(ref client.GetPinnableReference(), thread_init_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        public static unsafe void OnShutdown<T0>(this Jack thisApi, Client* client, PfnJackThreadInitCallback shutdown_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.OnShutdown(client, shutdown_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        public static unsafe void OnShutdown(this Jack thisApi, Span<Client> client, PfnJackThreadInitCallback shutdown_callback, void* arg)
        {
            // SpanOverloader
            thisApi.OnShutdown(ref client.GetPinnableReference(), shutdown_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 6 in jack.h")]
        public static unsafe void OnShutdown<T0>(this Jack thisApi, Span<Client> client, PfnJackThreadInitCallback shutdown_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.OnShutdown(ref client.GetPinnableReference(), shutdown_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        public static unsafe void OnInfoShutdown<T0>(this Jack thisApi, Client* client, PfnJackInfoShutdownCallback shutdown_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.OnInfoShutdown(client, shutdown_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        public static unsafe void OnInfoShutdown(this Jack thisApi, Span<Client> client, PfnJackInfoShutdownCallback shutdown_callback, void* arg)
        {
            // SpanOverloader
            thisApi.OnInfoShutdown(ref client.GetPinnableReference(), shutdown_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 6 in jack.h")]
        public static unsafe void OnInfoShutdown<T0>(this Jack thisApi, Span<Client> client, PfnJackInfoShutdownCallback shutdown_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.OnInfoShutdown(ref client.GetPinnableReference(), shutdown_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        public static unsafe int SetProcessCallback<T0>(this Jack thisApi, Client* client, PfnJackProcessCallback process_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetProcessCallback(client, process_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        public static unsafe int SetProcessCallback(this Jack thisApi, Span<Client> client, PfnJackProcessCallback process_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetProcessCallback(ref client.GetPinnableReference(), process_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 5 in jack.h")]
        public static unsafe int SetProcessCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackProcessCallback process_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetProcessCallback(ref client.GetPinnableReference(), process_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        public static unsafe int SetFreewheelCallback<T0>(this Jack thisApi, Client* client, PfnJackFreewheelCallback freewheel_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetFreewheelCallback(client, freewheel_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        public static unsafe int SetFreewheelCallback(this Jack thisApi, Span<Client> client, PfnJackFreewheelCallback freewheel_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetFreewheelCallback(ref client.GetPinnableReference(), freewheel_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 5 in jack.h")]
        public static unsafe int SetFreewheelCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackFreewheelCallback freewheel_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetFreewheelCallback(ref client.GetPinnableReference(), freewheel_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        public static unsafe int SetBufferSizeCallback<T0>(this Jack thisApi, Client* client, PfnJackProcessCallback bufsize_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetBufferSizeCallback(client, bufsize_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        public static unsafe int SetBufferSizeCallback(this Jack thisApi, Span<Client> client, PfnJackProcessCallback bufsize_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetBufferSizeCallback(ref client.GetPinnableReference(), bufsize_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 5 in jack.h")]
        public static unsafe int SetBufferSizeCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackProcessCallback bufsize_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetBufferSizeCallback(ref client.GetPinnableReference(), bufsize_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        public static unsafe int SetSampleRateCallback<T0>(this Jack thisApi, Client* client, PfnJackProcessCallback srate_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetSampleRateCallback(client, srate_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        public static unsafe int SetSampleRateCallback(this Jack thisApi, Span<Client> client, PfnJackProcessCallback srate_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetSampleRateCallback(ref client.GetPinnableReference(), srate_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 5 in jack.h")]
        public static unsafe int SetSampleRateCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackProcessCallback srate_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetSampleRateCallback(ref client.GetPinnableReference(), srate_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        public static unsafe int SetClientRegistrationCallback<T0>(this Jack thisApi, Client* client, PfnJackClientRegistrationCallback registration_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetClientRegistrationCallback(client, registration_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        public static unsafe int SetClientRegistrationCallback(this Jack thisApi, Span<Client> client, PfnJackClientRegistrationCallback registration_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetClientRegistrationCallback(ref client.GetPinnableReference(), registration_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 5 in jack.h")]
        public static unsafe int SetClientRegistrationCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackClientRegistrationCallback registration_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetClientRegistrationCallback(ref client.GetPinnableReference(), registration_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        public static unsafe int SetPortRegistrationCallback<T0>(this Jack thisApi, Client* client, PfnJackPortRegistrationCallback registration_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetPortRegistrationCallback(client, registration_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        public static unsafe int SetPortRegistrationCallback(this Jack thisApi, Span<Client> client, PfnJackPortRegistrationCallback registration_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetPortRegistrationCallback(ref client.GetPinnableReference(), registration_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 6 in jack.h")]
        public static unsafe int SetPortRegistrationCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackPortRegistrationCallback registration_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetPortRegistrationCallback(ref client.GetPinnableReference(), registration_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        public static unsafe int SetPortConnectCallback<T0>(this Jack thisApi, Client* client, PfnJackPortConnectCallback connect_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetPortConnectCallback(client, connect_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        public static unsafe int SetPortConnectCallback(this Jack thisApi, Span<Client> client, PfnJackPortConnectCallback connect_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetPortConnectCallback(ref client.GetPinnableReference(), connect_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 5 in jack.h")]
        public static unsafe int SetPortConnectCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackPortConnectCallback connect_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetPortConnectCallback(ref client.GetPinnableReference(), connect_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        public static unsafe int SetPortRenameCallback<T0>(this Jack thisApi, Client* client, PfnJackPortRenameCallback rename_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetPortRenameCallback(client, rename_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        public static unsafe int SetPortRenameCallback(this Jack thisApi, Span<Client> client, PfnJackPortRenameCallback rename_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetPortRenameCallback(ref client.GetPinnableReference(), rename_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 523, Column 5 in jack.h")]
        public static unsafe int SetPortRenameCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackPortRenameCallback rename_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetPortRenameCallback(ref client.GetPinnableReference(), rename_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        public static unsafe int SetGraphOrderCallback<T0>(this Jack thisApi, Client* client, PfnJackGraphOrderCallback graph_callback, Span<T0> arg2) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetGraphOrderCallback(client, graph_callback, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        public static unsafe int SetGraphOrderCallback(this Jack thisApi, Span<Client> client, PfnJackGraphOrderCallback graph_callback, void* arg2)
        {
            // SpanOverloader
            return thisApi.SetGraphOrderCallback(ref client.GetPinnableReference(), graph_callback, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 5 in jack.h")]
        public static unsafe int SetGraphOrderCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackGraphOrderCallback graph_callback, Span<T0> arg2) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetGraphOrderCallback(ref client.GetPinnableReference(), graph_callback, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        public static unsafe int SetXrunCallback<T0>(this Jack thisApi, Client* client, PfnJackGraphOrderCallback xrun_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetXrunCallback(client, xrun_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        public static unsafe int SetXrunCallback(this Jack thisApi, Span<Client> client, PfnJackGraphOrderCallback xrun_callback, void* arg)
        {
            // SpanOverloader
            return thisApi.SetXrunCallback(ref client.GetPinnableReference(), xrun_callback, arg);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 5 in jack.h")]
        public static unsafe int SetXrunCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackGraphOrderCallback xrun_callback, Span<T0> arg) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetXrunCallback(ref client.GetPinnableReference(), xrun_callback, ref arg.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        public static unsafe int SetLatencyCallback<T0>(this Jack thisApi, Client* client, PfnJackLatencyCallback latency_callback, Span<T0> arg2) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetLatencyCallback(client, latency_callback, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        public static unsafe int SetLatencyCallback(this Jack thisApi, Span<Client> client, PfnJackLatencyCallback latency_callback, void* arg2)
        {
            // SpanOverloader
            return thisApi.SetLatencyCallback(ref client.GetPinnableReference(), latency_callback, arg2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 5 in jack.h")]
        public static unsafe int SetLatencyCallback<T0>(this Jack thisApi, Span<Client> client, PfnJackLatencyCallback latency_callback, Span<T0> arg2) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetLatencyCallback(ref client.GetPinnableReference(), latency_callback, ref arg2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 5 in jack.h")]
        public static unsafe int SetFreewheel(this Jack thisApi, Span<Client> client, int onoff)
        {
            // SpanOverloader
            return thisApi.SetFreewheel(ref client.GetPinnableReference(), onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 668, Column 5 in jack.h")]
        public static unsafe int SetBufferSize(this Jack thisApi, Span<Client> client, uint nframes)
        {
            // SpanOverloader
            return thisApi.SetBufferSize(ref client.GetPinnableReference(), nframes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 674, Column 16 in jack.h")]
        public static unsafe uint GetSampleRate(this Jack thisApi, Span<Client> arg0)
        {
            // SpanOverloader
            return thisApi.GetSampleRate(ref arg0.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 16 in jack.h")]
        public static unsafe uint GetBufferSize(this Jack thisApi, Span<Client> arg0)
        {
            // SpanOverloader
            return thisApi.GetBufferSize(ref arg0.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 5 in jack.h")]
        public static unsafe int EngineTakeoverTimebase(this Jack thisApi, Span<Client> arg0)
        {
            // SpanOverloader
            return thisApi.EngineTakeoverTimebase(ref arg0.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 7 in jack.h")]
        public static unsafe float CpuLoad(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.CpuLoad(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(client, port_name, in port_type.GetPinnableReference(), flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(client, in port_name.GetPinnableReference(), port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(client, in port_name.GetPinnableReference(), in port_type.GetPinnableReference(), flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(client, in port_name.GetPinnableReference(), port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(client, port_name, in port_type.GetPinnableReference(), flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), port_name, port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), port_name, in port_type.GetPinnableReference(), flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), port_name, port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), in port_name.GetPinnableReference(), port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), in port_name.GetPinnableReference(), in port_type.GetPinnableReference(), flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), in port_name.GetPinnableReference(), port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] byte* port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), port_name, port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), port_name, in port_type.GetPinnableReference(), flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 15 in jack.h")]
        public static unsafe Port* PortRegister(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type, uint flags, uint buffer_size)
        {
            // SpanOverloader
            return thisApi.PortRegister(ref client.GetPinnableReference(), port_name, port_type, flags, buffer_size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        public static unsafe int PortUnregister(this Jack thisApi, Client* client, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortUnregister(client, ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        public static unsafe int PortUnregister(this Jack thisApi, Span<Client> client, Port* port)
        {
            // SpanOverloader
            return thisApi.PortUnregister(ref client.GetPinnableReference(), port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 5 in jack.h")]
        public static unsafe int PortUnregister(this Jack thisApi, Span<Client> client, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortUnregister(ref client.GetPinnableReference(), ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 8 in jack.h")]
        public static unsafe void* PortGetBuffer(this Jack thisApi, Span<Port> port, uint arg1)
        {
            // SpanOverloader
            return thisApi.PortGetBuffer(ref port.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 783, Column 13 in jack.h")]
        public static unsafe ulong PortUuid(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortUuid(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 14 in jack.h")]
        public static unsafe byte* PortName(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortName(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 799, Column 14 in jack.h")]
        public static unsafe byte* PortShortName(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortShortName(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 804, Column 5 in jack.h")]
        public static unsafe int PortFlags(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortFlags(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 810, Column 14 in jack.h")]
        public static unsafe byte* PortType(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortType(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 815, Column 21 in jack.h")]
        public static unsafe uint PortTypeId(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortTypeId(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        public static unsafe int PortIsMine(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortIsMine(client, in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        public static unsafe int PortIsMine(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, [Flow(FlowDirection.In)] Port* port)
        {
            // SpanOverloader
            return thisApi.PortIsMine(in client.GetPinnableReference(), port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 5 in jack.h")]
        public static unsafe int PortIsMine(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortIsMine(in client.GetPinnableReference(), in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 5 in jack.h")]
        public static unsafe int PortConnected(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortConnected(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        public static unsafe int PortConnectedTo(this Jack thisApi, [Flow(FlowDirection.In)] Port* port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortConnectedTo(port, in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        public static unsafe int PortConnectedTo(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port, [Flow(FlowDirection.In)] byte* port_name)
        {
            // SpanOverloader
            return thisApi.PortConnectedTo(in port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        public static unsafe int PortConnectedTo(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortConnectedTo(in port.GetPinnableReference(), in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 5 in jack.h")]
        public static unsafe int PortConnectedTo(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name)
        {
            // SpanOverloader
            return thisApi.PortConnectedTo(in port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 15 in jack.h")]
        public static unsafe byte** PortGetConnections(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortGetConnections(in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        public static unsafe byte** PortGetAllConnections(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortGetAllConnections(client, in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        public static unsafe byte** PortGetAllConnections(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, [Flow(FlowDirection.In)] Port* port)
        {
            // SpanOverloader
            return thisApi.PortGetAllConnections(in client.GetPinnableReference(), port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 15 in jack.h")]
        public static unsafe byte** PortGetAllConnections(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port)
        {
            // SpanOverloader
            return thisApi.PortGetAllConnections(in client.GetPinnableReference(), in port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        public static unsafe int PortTie(this Jack thisApi, Port* src, Span<Port> dst)
        {
            // SpanOverloader
            return thisApi.PortTie(src, ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        public static unsafe int PortTie(this Jack thisApi, Span<Port> src, Port* dst)
        {
            // SpanOverloader
            return thisApi.PortTie(ref src.GetPinnableReference(), dst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 5 in jack.h")]
        public static unsafe int PortTie(this Jack thisApi, Span<Port> src, Span<Port> dst)
        {
            // SpanOverloader
            return thisApi.PortTie(ref src.GetPinnableReference(), ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 5 in jack.h")]
        public static unsafe int PortUntie(this Jack thisApi, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortUntie(ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        public static unsafe int PortSetName(this Jack thisApi, Port* port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortSetName(port, in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        public static unsafe int PortSetName(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In)] byte* port_name)
        {
            // SpanOverloader
            return thisApi.PortSetName(ref port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        public static unsafe int PortSetName(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortSetName(ref port.GetPinnableReference(), in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 5 in jack.h")]
        public static unsafe int PortSetName(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name)
        {
            // SpanOverloader
            return thisApi.PortSetName(ref port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Client* client, Port* port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(client, port, in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Client* client, Span<Port> port, [Flow(FlowDirection.In)] byte* port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(client, ref port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Client* client, Span<Port> port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(client, ref port.GetPinnableReference(), in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Client* client, Span<Port> port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(client, ref port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Span<Client> client, Port* port, [Flow(FlowDirection.In)] byte* port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(ref client.GetPinnableReference(), port, port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Span<Client> client, Port* port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(ref client.GetPinnableReference(), port, in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Span<Client> client, Port* port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(ref client.GetPinnableReference(), port, port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Span<Client> client, Span<Port> port, [Flow(FlowDirection.In)] byte* port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(ref client.GetPinnableReference(), ref port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Span<Client> client, Span<Port> port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(ref client.GetPinnableReference(), ref port.GetPinnableReference(), in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 5 in jack.h")]
        public static unsafe int PortRename(this Jack thisApi, Span<Client> client, Span<Port> port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name)
        {
            // SpanOverloader
            return thisApi.PortRename(ref client.GetPinnableReference(), ref port.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        public static unsafe int PortSetAlias(this Jack thisApi, Port* port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> alias)
        {
            // SpanOverloader
            return thisApi.PortSetAlias(port, in alias.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        public static unsafe int PortSetAlias(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In)] byte* alias)
        {
            // SpanOverloader
            return thisApi.PortSetAlias(ref port.GetPinnableReference(), alias);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        public static unsafe int PortSetAlias(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> alias)
        {
            // SpanOverloader
            return thisApi.PortSetAlias(ref port.GetPinnableReference(), in alias.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 928, Column 5 in jack.h")]
        public static unsafe int PortSetAlias(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alias)
        {
            // SpanOverloader
            return thisApi.PortSetAlias(ref port.GetPinnableReference(), alias);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        public static unsafe int PortUnsetAlias(this Jack thisApi, Port* port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> alias)
        {
            // SpanOverloader
            return thisApi.PortUnsetAlias(port, in alias.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        public static unsafe int PortUnsetAlias(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In)] byte* alias)
        {
            // SpanOverloader
            return thisApi.PortUnsetAlias(ref port.GetPinnableReference(), alias);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        public static unsafe int PortUnsetAlias(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> alias)
        {
            // SpanOverloader
            return thisApi.PortUnsetAlias(ref port.GetPinnableReference(), in alias.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 5 in jack.h")]
        public static unsafe int PortUnsetAlias(this Jack thisApi, Span<Port> port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alias)
        {
            // SpanOverloader
            return thisApi.PortUnsetAlias(ref port.GetPinnableReference(), alias);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        public static unsafe int PortGetAliases(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port, [Count(Count = 2), Flow(FlowDirection.In)] byte** aliases)
        {
            // SpanOverloader
            return thisApi.PortGetAliases(in port.GetPinnableReference(), aliases);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 945, Column 5 in jack.h")]
        public static unsafe int PortGetAliases(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Port> port, [Count(Count = 2), Flow(FlowDirection.In)] in byte* aliases)
        {
            // SpanOverloader
            return thisApi.PortGetAliases(in port.GetPinnableReference(), in aliases);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 5 in jack.h")]
        public static unsafe int PortRequestMonitor(this Jack thisApi, Span<Port> port, int onoff)
        {
            // SpanOverloader
            return thisApi.PortRequestMonitor(ref port.GetPinnableReference(), onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        public static unsafe int PortRequestMonitorByName(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, int onoff)
        {
            // SpanOverloader
            return thisApi.PortRequestMonitorByName(client, in port_name.GetPinnableReference(), onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        public static unsafe int PortRequestMonitorByName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name, int onoff)
        {
            // SpanOverloader
            return thisApi.PortRequestMonitorByName(ref client.GetPinnableReference(), port_name, onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        public static unsafe int PortRequestMonitorByName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name, int onoff)
        {
            // SpanOverloader
            return thisApi.PortRequestMonitorByName(ref client.GetPinnableReference(), in port_name.GetPinnableReference(), onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 961, Column 5 in jack.h")]
        public static unsafe int PortRequestMonitorByName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name, int onoff)
        {
            // SpanOverloader
            return thisApi.PortRequestMonitorByName(ref client.GetPinnableReference(), port_name, onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 5 in jack.h")]
        public static unsafe int PortEnsureMonitor(this Jack thisApi, Span<Port> port, int onoff)
        {
            // SpanOverloader
            return thisApi.PortEnsureMonitor(ref port.GetPinnableReference(), onoff);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 976, Column 5 in jack.h")]
        public static unsafe int PortMonitoringInput(this Jack thisApi, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortMonitoringInput(ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(client, source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(client, in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(client, in source_port.GetPinnableReference(), in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(client, in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(client, source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), in source_port.GetPinnableReference(), in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 5 in jack.h")]
        public static unsafe int Connect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Connect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(client, source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(client, in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(client, in source_port.GetPinnableReference(), in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(client, in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(client, source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), in source_port.GetPinnableReference(), in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), in source_port.GetPinnableReference(), destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] byte* destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In)] ReadOnlySpan<byte> destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), source_port, in destination_port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 5 in jack.h")]
        public static unsafe int Disconnect(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_port, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string destination_port)
        {
            // SpanOverloader
            return thisApi.Disconnect(ref client.GetPinnableReference(), source_port, destination_port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        public static unsafe int PortDisconnect(this Jack thisApi, Client* client, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortDisconnect(client, ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        public static unsafe int PortDisconnect(this Jack thisApi, Span<Client> client, Port* port)
        {
            // SpanOverloader
            return thisApi.PortDisconnect(ref client.GetPinnableReference(), port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 5 in jack.h")]
        public static unsafe int PortDisconnect(this Jack thisApi, Span<Client> client, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortDisconnect(ref client.GetPinnableReference(), ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        public static unsafe nuint PortTypeGetBufferSize(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type)
        {
            // SpanOverloader
            return thisApi.PortTypeGetBufferSize(client, in port_type.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        public static unsafe nuint PortTypeGetBufferSize(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_type)
        {
            // SpanOverloader
            return thisApi.PortTypeGetBufferSize(ref client.GetPinnableReference(), port_type);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        public static unsafe nuint PortTypeGetBufferSize(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_type)
        {
            // SpanOverloader
            return thisApi.PortTypeGetBufferSize(ref client.GetPinnableReference(), in port_type.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 8 in jack.h")]
        public static unsafe nuint PortTypeGetBufferSize(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_type)
        {
            // SpanOverloader
            return thisApi.PortTypeGetBufferSize(ref client.GetPinnableReference(), port_type);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 6 in jack.h")]
        public static unsafe void PortSetLatency(this Jack thisApi, Span<Port> port, uint arg1)
        {
            // SpanOverloader
            thisApi.PortSetLatency(ref port.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        public static unsafe void PortGetLatencyRange(this Jack thisApi, Port* port, JackLatencyCallbackMode mode, Span<LatencyRange> range)
        {
            // SpanOverloader
            thisApi.PortGetLatencyRange(port, mode, ref range.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        public static unsafe void PortGetLatencyRange(this Jack thisApi, Span<Port> port, JackLatencyCallbackMode mode, LatencyRange* range)
        {
            // SpanOverloader
            thisApi.PortGetLatencyRange(ref port.GetPinnableReference(), mode, range);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1130, Column 6 in jack.h")]
        public static unsafe void PortGetLatencyRange(this Jack thisApi, Span<Port> port, JackLatencyCallbackMode mode, Span<LatencyRange> range)
        {
            // SpanOverloader
            thisApi.PortGetLatencyRange(ref port.GetPinnableReference(), mode, ref range.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        public static unsafe void PortSetLatencyRange(this Jack thisApi, Port* port, JackLatencyCallbackMode mode, Span<LatencyRange> range)
        {
            // SpanOverloader
            thisApi.PortSetLatencyRange(port, mode, ref range.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        public static unsafe void PortSetLatencyRange(this Jack thisApi, Span<Port> port, JackLatencyCallbackMode mode, LatencyRange* range)
        {
            // SpanOverloader
            thisApi.PortSetLatencyRange(ref port.GetPinnableReference(), mode, range);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 6 in jack.h")]
        public static unsafe void PortSetLatencyRange(this Jack thisApi, Span<Port> port, JackLatencyCallbackMode mode, Span<LatencyRange> range)
        {
            // SpanOverloader
            thisApi.PortSetLatencyRange(ref port.GetPinnableReference(), mode, ref range.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 5 in jack.h")]
        public static unsafe int RecomputeTotalLatencies(this Jack thisApi, Span<Client> client)
        {
            // SpanOverloader
            return thisApi.RecomputeTotalLatencies(ref client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 16 in jack.h")]
        public static unsafe uint PortGetLatency(this Jack thisApi, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortGetLatency(ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        public static unsafe uint PortGetTotalLatency(this Jack thisApi, Client* client, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortGetTotalLatency(client, ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        public static unsafe uint PortGetTotalLatency(this Jack thisApi, Span<Client> client, Port* port)
        {
            // SpanOverloader
            return thisApi.PortGetTotalLatency(ref client.GetPinnableReference(), port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 16 in jack.h")]
        public static unsafe uint PortGetTotalLatency(this Jack thisApi, Span<Client> client, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.PortGetTotalLatency(ref client.GetPinnableReference(), ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        public static unsafe int RecomputeTotalLatency(this Jack thisApi, Client* arg0, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.RecomputeTotalLatency(arg0, ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        public static unsafe int RecomputeTotalLatency(this Jack thisApi, Span<Client> arg0, Port* port)
        {
            // SpanOverloader
            return thisApi.RecomputeTotalLatency(ref arg0.GetPinnableReference(), port);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1262, Column 5 in jack.h")]
        public static unsafe int RecomputeTotalLatency(this Jack thisApi, Span<Client> arg0, Span<Port> port)
        {
            // SpanOverloader
            return thisApi.RecomputeTotalLatency(ref arg0.GetPinnableReference(), ref port.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] ReadOnlySpan<byte> type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(client, port_name_pattern, in type_name_pattern.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(client, in port_name_pattern.GetPinnableReference(), type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name_pattern, [Flow(FlowDirection.In)] ReadOnlySpan<byte> type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(client, in port_name_pattern.GetPinnableReference(), in type_name_pattern.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(client, in port_name_pattern.GetPinnableReference(), type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Client* client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] ReadOnlySpan<byte> type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(client, port_name_pattern, in type_name_pattern.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), port_name_pattern, type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In)] ReadOnlySpan<byte> type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), port_name_pattern, in type_name_pattern.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), port_name_pattern, type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), in port_name_pattern.GetPinnableReference(), type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name_pattern, [Flow(FlowDirection.In)] ReadOnlySpan<byte> type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), in port_name_pattern.GetPinnableReference(), in type_name_pattern.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), in port_name_pattern.GetPinnableReference(), type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] byte* type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), port_name_pattern, type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In)] ReadOnlySpan<byte> type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), port_name_pattern, in type_name_pattern.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 15 in jack.h")]
        public static unsafe byte** GetPorts(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name_pattern, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string type_name_pattern, uint flags)
        {
            // SpanOverloader
            return thisApi.GetPorts(ref client.GetPinnableReference(), port_name_pattern, type_name_pattern, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        public static unsafe Port* PortByName(this Jack thisApi, Client* client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortByName(client, in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        public static unsafe Port* PortByName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] byte* port_name)
        {
            // SpanOverloader
            return thisApi.PortByName(ref client.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        public static unsafe Port* PortByName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In)] ReadOnlySpan<byte> port_name)
        {
            // SpanOverloader
            return thisApi.PortByName(ref client.GetPinnableReference(), in port_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1297, Column 15 in jack.h")]
        public static unsafe Port* PortByName(this Jack thisApi, Span<Client> client, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string port_name)
        {
            // SpanOverloader
            return thisApi.PortByName(ref client.GetPinnableReference(), port_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 15 in jack.h")]
        public static unsafe Port* PortById(this Jack thisApi, Span<Client> client, uint port_id)
        {
            // SpanOverloader
            return thisApi.PortById(ref client.GetPinnableReference(), port_id);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 16 in jack.h")]
        public static unsafe uint FramesSinceCycleStart(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> arg0)
        {
            // SpanOverloader
            return thisApi.FramesSinceCycleStart(in arg0.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1328, Column 16 in jack.h")]
        public static unsafe uint FrameTime(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> arg0)
        {
            // SpanOverloader
            return thisApi.FrameTime(in arg0.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1344, Column 16 in jack.h")]
        public static unsafe uint LastFrameTime(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client)
        {
            // SpanOverloader
            return thisApi.LastFrameTime(in client.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, current_usecs, next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, current_usecs, ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, ulong* current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, current_usecs, ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, Span<ulong> current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, ref current_usecs.GetPinnableReference(), next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, Span<ulong> current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, ref current_usecs.GetPinnableReference(), next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, uint* current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, current_frames, ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), current_usecs, next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, ulong* current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), current_usecs, next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, ulong* current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), current_usecs, ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, ulong* current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), current_usecs, ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, Span<ulong> current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, Span<ulong> current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] Client* client, Span<uint> current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(client, ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, current_usecs, next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, ulong* current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, current_usecs, next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, ulong* current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, current_usecs, ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, ulong* current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, current_usecs, ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, Span<ulong> current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, ref current_usecs.GetPinnableReference(), next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, Span<ulong> current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, ref current_usecs.GetPinnableReference(), next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint* current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), current_frames, ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, ulong* current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), current_usecs, next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, ulong* current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), current_usecs, next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, ulong* current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), current_usecs, ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, ulong* current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), current_usecs, ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, Span<ulong> current_usecs, ulong* next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), next_usecs, period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, Span<ulong> current_usecs, ulong* next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), next_usecs, ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, float* period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), period_usecs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1389, Column 5 in jack.h")]
        public static unsafe int GetCycleTimes(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, Span<uint> current_frames, Span<ulong> current_usecs, Span<ulong> next_usecs, Span<float> period_usecs)
        {
            // SpanOverloader
            return thisApi.GetCycleTimes(in client.GetPinnableReference(), ref current_frames.GetPinnableReference(), ref current_usecs.GetPinnableReference(), ref next_usecs.GetPinnableReference(), ref period_usecs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1398, Column 13 in jack.h")]
        public static unsafe ulong FramesToTime(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, uint arg1)
        {
            // SpanOverloader
            return thisApi.FramesToTime(in client.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 16 in jack.h")]
        public static unsafe uint TimeToFrames(this Jack thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Client> client, ulong arg1)
        {
            // SpanOverloader
            return thisApi.TimeToFrames(in client.GetPinnableReference(), arg1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 6 in jack.h")]
        public static unsafe void Free<T0>(this Jack thisApi, Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Free(ref ptr.GetPinnableReference());
        }

    }
}

