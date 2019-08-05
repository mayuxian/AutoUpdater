using System;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.CommService.Interface;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    public class UpdateService //: ICommService
    {
        private static Server _server;
        private GrpcUpdateService grpcUpdateService;
        private CommOptions _commOptions;

        public UpdateService()
        {
            grpcUpdateService = new GrpcUpdateService();
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
            var result = await grpcUpdateService.GetResponseAsync(new GRPCService.Protocol.Request(), null);
            return result.Content.ToString();
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
