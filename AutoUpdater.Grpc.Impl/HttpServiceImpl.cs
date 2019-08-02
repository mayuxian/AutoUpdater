using Grpc.Core;
using Snai.GrpcService.Protocol;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdater.Grpc.Impl
{
    public class HttpServiceImpl : MsgService.MsgServiceBase
    {
        public HttpServiceImpl()
        {

        }

        public override async Task<GetMsgSumReply> GetSum(GetMsgNumRequest request, ServerCallContext context)
        {
            // base.GetSum(request, context);
            var result = new GetMsgSumReply();

            result.Sum = request.Num1 + request.Num2;

            return result;
        }
    }
}
