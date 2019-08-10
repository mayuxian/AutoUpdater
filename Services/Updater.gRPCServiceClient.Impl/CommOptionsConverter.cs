using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Updater.CommService.Interface;

namespace Updater.gRPCService.Impl
{
    public class CommOptionsConverter
    {
        //Header等的添加，参照：https://blog.csdn.net/xuduorui/article/details/78278808
        //http://doc.oschina.net/grpc?t=58011
        public static CallOptions ConvertToGrpcOptions(CommMethod method, CommOptions commOptions)
        {
            var metadata = new Metadata();
            metadata.Add("grpc-encoding", commOptions.ContentEncoding.WebName);
            metadata.Add("grpc-accept-encoding", commOptions.AcceptContentEncoding.WebName);
     
            //metadata.Add("grpc-encoding", "gzip"); //TODO:压缩编码指定到了消息编码
            //TODO：:scheme = http / https  这个配置是否要配置??
            //metadata.Add("content-type", commOptions.ContentType);

            //时 → “H” 分 → “M”秒 → “S” 毫秒 → “m” 微秒 → “u” 纳秒 → “n”
            //TODO:timeout和deadline的区别？
            //metadata.Add("grpc-timeout", commOptions.Timeout.ToString() + "m");

            //metadata.Add("grpc-message-type", ??);   //消息类型 → “grpc-message-type” {消息模式的类型名}

            metadata.Add("method", method.ToString());
            //metadata.Add("user-agent", commOptions.UserAgent);

            var deadline = DateTime.MinValue; //单位为100纳秒，所以需要*10
            deadline.AddMilliseconds(commOptions.Timeout);

            var callOptions = new CallOptions(); //暂时不添加超时
            callOptions.WithHeaders(metadata);
            return callOptions;
        }
    }
}
