using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    public class GrpcUpdateServiceClient : IUpdateService.IUpdateServiceClient
    {
        public EventHandler<GrpcErrorEventArgs> GrpcCommunicationError;

        public GrpcUpdateServiceClient(Channel channel)
            :base(channel)
        {
        
        }

        public override GRPCService.Protocol.Response GetResponseAsync(Request request, CallOptions options)
        {
          return  base.GetResponseAsync(request, options);
        }
        public override GRPCService.Protocol.Response GetResponseAsync(Request request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
        {
            return base.GetResponseAsync(request, headers, deadline, cancellationToken);
        }
        public override AsyncUnaryCall<GRPCService.Protocol.Response> GetResponseAsyncAsync(Request request, CallOptions options)
        {
            return base.GetResponseAsyncAsync(request, options);
        }

        public override AsyncUnaryCall<GRPCService.Protocol.Response> GetResponseAsyncAsync(Request request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
        {
            return base.GetResponseAsyncAsync(request, headers, deadline, cancellationToken);
        }

        public override AsyncServerStreamingCall<GRPCService.Protocol.Response> GetResponseStreamAsync(Request request, CallOptions options)
        {
            return base.GetResponseStreamAsync(request, options);
        }

        public override AsyncServerStreamingCall<GRPCService.Protocol.Response> GetResponseStreamAsync(Request request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
        {
            return base.GetResponseStreamAsync(request, headers, deadline, cancellationToken);
        }
    }

    public class GrpcErrorEventArgs : EventArgs
    {
        /// <summary>
        /// 错误
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="exception"></param>
        public GrpcErrorEventArgs(Exception exception)
        {
            this.Exception = exception;
        }
    }
}
