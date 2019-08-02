using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    public class GrpcUpdateService : IUpdateService.IUpdateServiceBase
    {
        public override Task<UpdateResponse> GetStringAsync(UpdateRequest request, ServerCallContext context)
        {
            return base.GetStringAsync(request, context);
        }
    }
}
