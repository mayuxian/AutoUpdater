using System;
using System.Threading.Tasks;
using Grpc.Core;
using Updater.CommService.Interface;

namespace Updater.gRPCService.Impl
{
    public class UpdateService //: ICommService
    {
        private GrpcUpdateService grpcUpdateService;

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
            var result = await grpcUpdateService.GetStringAsync(null, null);
            //result.Test1
            return null;
        }

        public Task<Response> PostAsync(string url, CommOptions setting = null)
        {
            throw new NotImplementedException();
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
