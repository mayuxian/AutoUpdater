
##1.后续通过gRpc实现服务科发现式自动更新。如下：
https://github.com/GameBelial/Abp.Grpc/blob/master/Abp.Grpc.Client/Infrastructure/GrpcChannel/GrpcChannelManager.cs

##2.把基础通信也抽象成接口
 rpc GetResponseAsync(Request) returns (Response);
  rpc GetResponseStreamAsync(Request) returns (stream Response){};

