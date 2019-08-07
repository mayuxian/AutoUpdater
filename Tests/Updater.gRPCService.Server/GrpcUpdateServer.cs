using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Server
{
    public class GrpcUpdateServer : IUpdateService.IUpdateServiceBase
    {
        public override Task<RpcResponse> GetResponse(RpcRequest request, ServerCallContext context)
        {
            return base.GetResponse(request, context);
        }

        public override Task GetResponseStream(RpcRequest request, IServerStreamWriter<RpcResponse> responseStream, ServerCallContext context)
        {
            return base.GetResponseStream(request, responseStream, context);
        }
    }
}
