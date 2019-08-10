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
    public class UpdateService : ICommServiceBase<Response, object>
    {
        //private static Server _server;
        private static Channel _channel;
        private IUpdateService.IUpdateServiceClient _updateServiceClient;
        //private GrpcUpdateServiceClient _updateServiceClient;

        private CommOptions _defaultCommOptions = new CommOptions();
        public CommOptions DefaultCommOptions { get => _defaultCommOptions; set => _defaultCommOptions = value; }

        public UpdateService()
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

        public Task<Response> GetAsync(string url, string requestContent = null, CommOptions options = null)
        {
            //_updateServiceClient.GetResponseAsync
            throw new NotImplementedException();
        }

        public async Task<byte[]> GetBytesAsync(string url, string requestContent = null, CommOptions options = null)
        {
            var service = CreateClientService(url);
            var callOptions = CommOptionsConverter.ConvertToGrpcOptions(CommMethod.GET, (options == null) ? DefaultCommOptions : options);
            var rpcRequest = new RpcRequest();
            //rpcRequest.Content
            var result = await service.GetResponseAsync(rpcRequest, callOptions).ResponseAsync;
            return result.Content.ToByteArray();
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
            cts.CancelAfter(TimeSpan.FromMinutes(10)); //TODO:有待完善

            var stream = new MemoryStream();

            using (var response = service.GetResponseStream(rpcRequest, callOptions))
            {
                try
                {

                    while (await response.ResponseStream.MoveNext(cts.Token))
                    {
                        var data = response.ResponseStream.Current.Content.ToByteArray();
                        stream.Write(data, 0, data.Length);  //TODO:需要完善成async方式。
                    }
                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.Cancelled)
                {
                    Console.WriteLine("Stream cancelled.");
                    //throw;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            return await Task.FromResult<Stream>(stream);
        }
    }

    public class Response : IResponse<object>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public IResponseError Error { get; set; }
    }
}
