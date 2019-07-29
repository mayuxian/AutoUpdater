using Grpc.Core;
using Snai.GrpcService.Protocol;
using System;
using System.Threading.Tasks;

namespace AutoUpdater.Grpc.Impl
{
    public class Class1 : MsgService.MsgServiceBase
    {
        public override Task<GetMsgSumReply> GetSum(GetMsgNumRequest request, ServerCallContext context)
        {
            return base.GetSum(request, context);
        }
    }
}
