using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Server
{
    //protobuf的ByteString与数据转换的参照地址：https://blog.csdn.net/xhyzdai/article/details/46789733
    public class GrpcUpdateServer : IUpdateService.IUpdateServiceBase
    {
        public override Task<RpcResponse> GetResponse(RpcRequest request, ServerCallContext context)
        {
            Console.WriteLine($"请求信息：{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}: {request.Content.ToString()}");

            RpcResponse response = new RpcResponse();
            string responseContent = "我是服务端!调用方法:GetResponse";
            response.Content = ByteString.CopyFromUtf8(responseContent);
            Console.WriteLine("响应信息："+ responseContent);

            return Task.FromResult<RpcResponse>(response);
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
