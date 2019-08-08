using System;
using System.Collections.Generic;
using System.IO;
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
            RpcResponse response = new RpcResponse();
            Stream stream = new MemoryStream();
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("我是服务端!调用方法:GetResponse");
            }
            response.Content.WriteTo(stream);
            return Task.FromResult<RpcResponse>(response);
            //return base.GetResponse(request, context);
        }

        public override async Task GetResponseStream(RpcRequest request, IServerStreamWriter<RpcResponse> responseStream, ServerCallContext context)
        {
            RpcResponse response = new RpcResponse();
            //Stream stream = new MemoryStream();
            //using (StreamWriter writer = new StreamWriter(stream))
            //{
            //    writer.WriteLine("我是服务端!调用方法:GetResponseStream");
            //}
            //response.Content.WriteTo(stream);

            //TODO:实现下载文件的服务，读取文件，返回数据流

            await responseStream.WriteAsync(response);
            //return Task.FromResult<RpcResponse>(response);
            //return base.GetResponseStream(request, responseStream, context);
        }
    }
}
