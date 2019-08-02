using System.Threading.Tasks;
using Grpc.Core;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Impl
{
    public class GrpcUpdateService : IUpdateService.IUpdateServiceBase
    {
        private static Server _server;

        public override Task<GRPCService.Protocol.VersionInfo> GetVersionInfo(GetVersionInfoRquest request, ServerCallContext context)
        {
            return base.GetVersionInfo(request, context);
        }

        public override Task<DownloadResult> DownloadFile(DownloadRequest request, ServerCallContext context)
        {
            return base.DownloadFile(request, context);
        }
    }
}
