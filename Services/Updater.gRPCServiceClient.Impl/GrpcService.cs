using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.CommService.Interface;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    //TODO:此处应该是通信服务。 更新服务应该重新定义接口，并实现下载文件和获取版本信息等服务。
    public class GrpcService : ICommService
    {
        //private static Server _server;
        private static Channel _channel;
        private IUpdateService.IUpdateServiceClient _updateServiceClient;
        //private GrpcUpdateServiceClient _updateServiceClient;

        private CommOptions _defaultCommOptions = new CommOptions();
        public CommOptions DefaultCommOptions { get => _defaultCommOptions; set => _defaultCommOptions = value; }

        public GrpcService()
        {
        }

        public IUpdateService.IUpdateServiceClient CreateClientService(string url)
        {
            //TODO:ChannelOption的具体功能
            ChannelOption co = new ChannelOption("", ""); ;
            var cos = new Collection<ChannelOption>();
            cos.Add(co);

            var channel = new Channel(url, ChannelCredentials.Insecure);
            return new IUpdateService.IUpdateServiceClient(channel);
        }

        /// <summary>
        /// 获取byte数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestContent"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<byte[]> GetBytesAsync(string url, string requestContent = null, CommOptions options = null)
        {
            //var service = CreateClientService(url);
            //var callOptions = CommOptionsConverter.ConvertToGrpcOptions(CommMethod.GET, (options == null) ? DefaultCommOptions : options);
            //var rpcRequest = new RpcRequest();
            ////TODO:此块读取byte数据，到时是否使用 GetResponseStream？ 参见GetStreamAsync函数
            //var result = await service.GetResponseAsync(rpcRequest, callOptions).ResponseAsync;
            //return result.Content.ToByteArray();

            using (var stream = await GetStreamAsync(url, requestContent, options))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Seek(0, SeekOrigin.Begin);
                return buffer;
            }
        }

        public async Task<string> GetStringAsync(string url, string requestContent = null, CommOptions options = null)
        {
            var service = CreateClientService(url);

            var rpcRequest = new RpcRequest();
            rpcRequest.Content = Google.Protobuf.ByteString.CopyFromUtf8(url);

            var commOptions = (options == null) ? DefaultCommOptions : options;
            var callOptions = CommOptionsConverter.ConvertToGrpcOptions(CommMethod.GET, commOptions);

            var result = await service.GetResponseAsync(rpcRequest, callOptions).ResponseAsync;
            return result.Content.ToString(commOptions.AcceptContentEncoding);
        }

        public async Task<Stream> GetStreamAsync(string url, string requestContent = null, CommOptions options = null)
        {
            var service = CreateClientService(url);

            var rpcRequest = new RpcRequest();
            rpcRequest.Content = Google.Protobuf.ByteString.CopyFromUtf8(requestContent);

            var commOptions = (options == null) ? DefaultCommOptions : options;
            var callOptions = CommOptionsConverter.ConvertToGrpcOptions(CommMethod.GET, commOptions);

            var cts = new CancellationTokenSource();
            cts.CancelAfter(TimeSpan.FromMinutes(10)); //TODO:有待调整

            var stream = new MemoryStream();

            using (var response = service.GetResponseStream(rpcRequest, null, null, cts.Token))
            {
                try
                {
                    while (await response.ResponseStream.MoveNext(cts.Token))
                    {
                        var buffer = response.ResponseStream.Current.Content.ToByteArray();
                        stream.Write(buffer, 0, buffer.Length);  //TODO:需要完善成async方式。
                    }
                    stream.Seek(0, SeekOrigin.Begin);
                    //response.ResponseStream
                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.Cancelled)
                {
                    stream.Dispose();
                    Console.WriteLine("Stream cancelled.");
                }
                catch (Exception ex)
                {
                    stream.Dispose();
                    throw;
                }
            }

            return await Task.FromResult<Stream>(stream);
        }
    }
}
