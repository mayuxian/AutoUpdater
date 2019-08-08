using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;
using Updater.GRPCService.Protocol;

namespace Updater.gRPCService.Server
{
   public class GrpcService
    {
        private static Grpc.Core.Server _server;

        public static void Startup()
        {
            _server = new Grpc.Core.Server
            {
                Services = { IUpdateService.BindService(new GrpcUpdateServer()) },
                Ports = { new ServerPort("localhost", 40001, ServerCredentials.Insecure) }
            };
            _server.Start();


            Console.WriteLine("grpc ServerListening On Port 40001");
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            _server?.ShutdownAsync().Wait();
        }
    }
}
