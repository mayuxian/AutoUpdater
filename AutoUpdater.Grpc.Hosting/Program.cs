using System;
using AutoUpdater.Grpc.Impl;

namespace AutoUpdater.Grpc.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            RpcConfig.Start();
        }
    }
}
