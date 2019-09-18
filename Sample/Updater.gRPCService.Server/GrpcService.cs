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

        public static void Start(string host = "localhost", int port = 8080)
        {
            _server = new Grpc.Core.Server
            {
                Services = { IUpdateService.BindService(new GrpcUpdateServer()) },
                Ports = { new ServerPort(host, port, ServerCredentials.Insecure) }
            };
            _server.Start();

            Console.WriteLine("grpc ServerListening On Port " + port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            _server?.ShutdownAsync().Wait();
        }
    }
}
