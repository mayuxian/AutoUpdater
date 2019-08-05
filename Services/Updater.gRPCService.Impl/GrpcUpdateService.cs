using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    public class GrpcUpdateService : IUpdateService.IUpdateServiceBase
    {
        private static Channel _channel;
        private static IUpdateService.IUpdateServiceClient _client;
        public EventHandler<GrpcErrorEventArgs> GrpcCommunicationError;

        public GrpcUpdateService()
        {
            Collection<ChannelOption> list = new Collection<ChannelOption>();
            //ChannelOption channelOption = new ChannelOption(ChannelOptions.SoReuseport)

            _channel = new Channel("", ChannelCredentials.Insecure, list);
            _client = new IUpdateService.IUpdateServiceClient(_channel);
            //_channel.ConnectAsync(null);
            //_channel.State==ChannelState.TransientFailure
        }

        public override async Task<GRPCService.Protocol.Response> GetResponseAsync(Request request, ServerCallContext context)
        {
            try
            {
                var result = await base.GetResponseAsync(request, context);
                return result;
            }
            catch (Exception)
            {
                GrpcCommunicationError?.Invoke(this, new GrpcErrorEventArgs(ex));
                throw;
            }
        }

        public override async Task GetResponseStreamAsync(Request request, IServerStreamWriter<GRPCService.Protocol.Response> responseStream, ServerCallContext context)
        {
            try
            {
                await base.GetResponseStreamAsync(request, responseStream, context);
            }
            catch (Exception ex)
            {
                GrpcCommunicationError?.Invoke(this, new GrpcErrorEventArgs(ex));
                throw;
            }
        }
    }


    [Serializable]
    public class GrpcException : Exception
    {
        public GrpcException() { }
        public GrpcException(string message) : base(message) { }
        public GrpcException(string message, Exception inner) : base(message, inner) { }
        protected GrpcException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public class GrpcErrorEventArgs : EventArgs
    {
        /// <summary>
        /// 错误
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// 是否继续执行
        /// </summary>
        public bool Continue { get; set; }

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
