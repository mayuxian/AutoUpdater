
##1.后续通过gRpc实现服务科发现式自动更新。如下：
https://github.com/GameBelial/Abp.Grpc/blob/master/Abp.Grpc.Client/Infrastructure/GrpcChannel/GrpcChannelManager.cs

##2.把基础通信也抽象成接口
 rpc GetResponseAsync(Request) returns (Response);
  rpc GetResponseStreamAsync(Request) returns (stream Response){};
  
## 再自动更新中，应用23种设计模式，主要是为了能更好的设计，反向推理。
   可参考：https://www.cnblogs.com/revoid/p/9486668.html#16
  



