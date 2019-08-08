using System;
using System.Collections.ObjectModel;
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

        public UpdateService()
        {
        }

        public IUpdateService.IUpdateServiceClient CreateClientService(string url)
        {
            ChannelOption co = new ChannelOption("", ""); ;
            var cos = new Collection<ChannelOption>();
            cos.Add(co);

            var channel = new Channel(url, ChannelCredentials.Insecure, null);
            return new IUpdateService.IUpdateServiceClient(channel);
        }

        public void ConfigDefaultOptions(CommOptions options)
        {
            _defaultCommOptions = options;
        }

        public Task<Response> GetAsync(string url, CommOptions options = null)
        {
            //_updateServiceClient.GetResponseAsync
            throw new NotImplementedException();
        }

        public async Task<byte[]> GetBytesAsync(string url, CommOptions options = null)
        {
            var service = CreateClientService(url);
            var callOptions = CommOptionsConverter.ConvertToCallOptions(CommMethod.GET, (options == null) ? _defaultCommOptions : options);
            var rpcRequest = new RpcRequest();
            var result = await service.GetResponseAsync(rpcRequest, callOptions).ResponseAsync;
            return result.Content.ToByteArray();
        }

        public async Task<string> GetStringAsync(string url, CommOptions options = null)
        {
            var service = CreateClientService(url);
            var callOptions = CommOptionsConverter.ConvertToCallOptions(CommMethod.GET, (options == null) ? _defaultCommOptions : options);
            var rpcRequest = new RpcRequest();
            var result = await service.GetResponseAsync(rpcRequest, callOptions).ResponseAsync;
            return result.Content.ToString();
        }

        public async Task<Response> PostAsync(string url, CommOptions options = null)
        {
            var service = CreateClientService(url);
            var callOptions = CommOptionsConverter.ConvertToCallOptions(CommMethod.POST, (options == null) ? _defaultCommOptions : options);
            var rpcRequest = new RpcRequest();
            var r1 = await service.GetResponseAsync(rpcRequest, callOptions);

            //var result = service.GetResponseStream(rpcRequest, callOptions);
            //var streamReader = result.ResponseStream;
            //streamReader.MoveNext(new System.Threading.CancellationToken(true));

            return await Task.FromResult<Response>(null);
        }

        private async Task<string> GetRpcStringAsync(string url)
        {
            var response = _updateServiceClient.GetResponseAsync(new RpcRequest(), new CallOptions());
            //response.Content

            //EventHandler<GrpcErrorEventArgs> errorHandler = null;
            //errorHandler = (sender, e) =>
            //{
            //    _updateServiceClient.GrpcCommunicationError -= errorHandler;
            //    throw e.Exception;
            //};
            //_updateServiceClient.GrpcCommunicationError += errorHandler;

            //var result = await grpcUpdateService.GetResponseAsync(new GRPCService.Protocol.Request(), null);
            ////TODO:需要识别，出异常后返回，还是未出异常返回。
            //return result.Content.ToString();
            return await Task.FromResult<string>(null);
        }

        private async Task<bool> GetRpcStreamAsync(string url)
        {
            return await Task.FromResult<bool>(false);
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
