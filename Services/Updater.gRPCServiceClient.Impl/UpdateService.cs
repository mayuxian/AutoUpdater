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
        private CommOptions _commOptions;

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

        public Task<Response> GetAsync(string url, CommOptions setting = null)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetBytesAsync(string url, CommOptions setting = null)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetStringAsync(string url, CommOptions setting = null)
        {
            return await GetRpcStringAsync(url);
        }

        public Task<Response> PostAsync(string url, CommOptions setting = null)
        {
            throw new NotImplementedException();
        }

        private async Task<string> GetRpcStringAsync(string url)
        {
            var response = _updateServiceClient.GetResponseAsync(new GRPCService.Protocol.Request(), new CallOptions());
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
