using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Updater.CommService.Interface;

namespace Updater.gRPCServiceClient.Impl
{
    public class CommOptionsConverter
    {
        public static CallOptions ConvertToCallOptions(CommMethod method, CommOptions commOptions)
        {
            var metadata = new Metadata();
            metadata.Add("grpc-encoding", commOptions.ContentEncoding.ToString());
            //metadata.Add("grpc-encoding", "gzip"); //TODO:压缩编码指定到了消息编码
            //TODO：:scheme = http / https  这个配置??
            metadata.Add("grpc-accept-encoding", commOptions.AcceptContentEncoding.ToString());
            metadata.Add("content-type", commOptions.ContentType);
            
            metadata.Add("grpc-timeout", commOptions.Timeout.ToString() + "m");
            //metadata.Add("grpc-timeout", commOptions.AcceptContentEncoding.ToString());
            //TODO:timeout和deadline的区别？
            //            超时 → “grpc - timeout” 超时时间值 超时时间单位
            //超时时间值 → { 至少8位数字正整数的 ASCII 码字符串}
            //            超时时间单位 → 时 / 分 / 秒 / 毫秒 / 微秒 / 纳秒
            //时 → “H”
            //分 → “M”
            //秒 → “S”
            //毫秒 → “m”
            //微秒 → “u”
            //纳秒 → “n”
            metadata.Add("method", method.ToString());
            metadata.Add("user-agent", commOptions.UserAgent);
            //metadata.Add("grpc-message-type", ??);   //消息类型 → “grpc-message-type” {消息模式的类型名}

            var deadline = new DateTime(10 * commOptions.Timeout); //单位为100纳秒，所以需要*10

            var callOptions = new CallOptions(metadata, deadline);
            return callOptions;
        }
    }
}
