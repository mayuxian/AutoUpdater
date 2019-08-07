using System;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.CommService.Interface;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    public class UpdateService //: ICommService
    {
        //private static Server _server;
        private static Channel _channel;
        //private IUpdateService.IUpdateServiceClient _updateServiceClient;
        private GrpcUpdateServiceClient _updateServiceClient;
        private CommOptions _defaultCommOptions = new CommOptions();

        public UpdateService()
        {
            //_updateServiceClient = new IUpdateService.IUpdateServiceClient(_channel);
            //Collection<ChannelOption> list = new Collection<ChannelOption>();
            //ChannelOption channelOption = new ChannelOption(ChannelOptions.SoReuseport)

            _channel = new Channel("", ChannelCredentials.Insecure, null);
            _updateServiceClient = new GrpcUpdateServiceClient(_channel);
            //_channel.ConnectAsync(null);
            //_channel.State==ChannelState.TransientFailure
        }

        public void ConfigDefaultOptions(CommOptions options)
        {
            _defaultCommOptions = options;
        }

        public async Task<Response> PostAsync(string url, CommOptions options = null)
        {
            //Header等的添加，参照：https://blog.csdn.net/xuduorui/article/details/78278808
            //http://doc.oschina.net/grpc?t=58011
            var rpcRequest = new RpcRequest();
            var metadata = new Metadata();
            metadata.Add("Method", "GET");
            var callOptions = new CallOptions(metadata, new DateTime());

            callOptions.WithDeadline(new DateTime());

            var r1 = await _updateServiceClient.GetResponseAsync(rpcRequest, callOptions);
            var r2 = await _updateServiceClient.GetResponseAsync(rpcRequest, new Metadata(), new DateTime());

            var result = _updateServiceClient.GetResponseStream(rpcRequest, callOptions);
            var streamReader = result.ResponseStream;
            //streamReader.MoveNext(new System.Threading.CancellationToken(true));

            return await Task.FromResult<Response>(null);
        }


        public Task<Response> GetAsync(string url, CommOptions options = null)
        {
            //_updateServiceClient.GetResponseAsync
            throw new NotImplementedException();
        }

        public Task<byte[]> GetBytesAsync(string url, CommOptions options = null)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetStringAsync(string url, CommOptions options = null)
        {
            return await GetRpcStringAsync(url);
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
