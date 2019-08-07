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
            : base(channel)
        {

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
