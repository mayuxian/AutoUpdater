﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Updater.GRPCService.Protocol;
using FileInfo = System.IO.FileInfo;

namespace Updater.gRPCService.Server
{
    //protobuf的ByteString与数据转换的参照地址：https://blog.csdn.net/xhyzdai/article/details/46789733
    public class GrpcUpdateServer : IUpdateService.IUpdateServiceBase
    {
        public override Task<RpcResponse> GetResponse(RpcRequest request, ServerCallContext context)
        {
            Console.WriteLine($"请求信息：{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}: {request.Content.ToString()}");

            //var requestHeaders = context.RequestHeaders.GetEnumerator();
            //StringBuilder sb = new StringBuilder();
            //bool moveNextEnabled = true;
            //while (moveNextEnabled && requestHeaders.Current != null)
            //{
            //    var header = requestHeaders.Current.Key + ":" + requestHeaders.Current.Value;
            //    sb.AppendLine(header);
            //    moveNextEnabled = requestHeaders.MoveNext();
            //}
            //Console.WriteLine("请求头RequestHeaders：" + sb.ToString());

            RpcResponse response = new RpcResponse();
            string responseContent = "我是服务端!  调用方法:GetResponse";
            response.Content = ByteString.CopyFromUtf8(responseContent);
            Console.WriteLine("响应信息：" + responseContent);

            return Task.FromResult<RpcResponse>(response);
        }

        public override async Task GetResponseStream(RpcRequest request, IServerStreamWriter<RpcResponse> responseStream, ServerCallContext context)
        {
            var fileRelativePath = request.Content.ToStringUtf8();
            var filePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileRelativePath));

            FileInfo fi = new FileInfo(filePath);
            long dataLength = fi.Length;

            using (StreamReader reader = new StreamReader(filePath))
            {
                //reader.ReadAsync(null, 0, 1000);
                RpcResponse response = new RpcResponse();

                var data = reader.ReadLine();
                response.Content = ByteString.CopyFromUtf8(data);
                response.ContentLength =(int)dataLength; //TODO:ContentLength应该设置为long

                await responseStream.WriteAsync(response);
            }

        }
    }
}
