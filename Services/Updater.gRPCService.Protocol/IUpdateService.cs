// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IUpdateService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Updater.GRPCService.Protocol {

  /// <summary>Holder for reflection information generated from IUpdateService.proto</summary>
  public static partial class IUpdateServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for IUpdateService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IUpdateServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRJVXBkYXRlU2VydmljZS5wcm90bxIcVXBkYXRlci5nUlBDU2VydmljZS5Q",
            "cm90b2NvbCJGCgdSZXF1ZXN0Eg8KB0NvbnRlbnQYASABKAwSFQoNQ29udGVu",
            "dExlbmd0aBgCIAEoBRITCgtDb250ZW50VHlwZRgDIAEoCSJbCghSZXNwb25z",
            "ZRIPCgdDb250ZW50GAEgASgMEhIKClN0YXR1c0NvZGUYAiABKAUSFQoNQ29u",
            "dGVudExlbmd0aBgDIAEoBRITCgtDb250ZW50VHlwZRgEIAEoCTLgAQoOSVVw",
            "ZGF0ZVNlcnZpY2USYQoQR2V0UmVzcG9uc2VBc3luYxIlLlVwZGF0ZXIuZ1JQ",
            "Q1NlcnZpY2UuUHJvdG9jb2wuUmVxdWVzdBomLlVwZGF0ZXIuZ1JQQ1NlcnZp",
            "Y2UuUHJvdG9jb2wuUmVzcG9uc2USawoWR2V0UmVzcG9uc2VTdHJlYW1Bc3lu",
            "YxIlLlVwZGF0ZXIuZ1JQQ1NlcnZpY2UuUHJvdG9jb2wuUmVxdWVzdBomLlVw",
            "ZGF0ZXIuZ1JQQ1NlcnZpY2UuUHJvdG9jb2wuUmVzcG9uc2UiADABYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Updater.GRPCService.Protocol.Request), global::Updater.GRPCService.Protocol.Request.Parser, new[]{ "Content", "ContentLength", "ContentType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Updater.GRPCService.Protocol.Response), global::Updater.GRPCService.Protocol.Response.Parser, new[]{ "Content", "StatusCode", "ContentLength", "ContentType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Updater.GRPCService.Protocol.IUpdateServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      content_ = other.content_;
      contentLength_ = other.contentLength_;
      contentType_ = other.contentType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "Content" field.</summary>
    public const int ContentFieldNumber = 1;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ContentLength" field.</summary>
    public const int ContentLengthFieldNumber = 2;
    private int contentLength_;
    /// <summary>
    ///要检查数据长度
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ContentLength {
      get { return contentLength_; }
      set {
        contentLength_ = value;
      }
    }

    /// <summary>Field number for the "ContentType" field.</summary>
    public const int ContentTypeFieldNumber = 3;
    private string contentType_ = "";
    /// <summary>
    ///内容类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContentType {
      get { return contentType_; }
      set {
        contentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (ContentLength != other.ContentLength) return false;
      if (ContentType != other.ContentType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (ContentLength != 0) hash ^= ContentLength.GetHashCode();
      if (ContentType.Length != 0) hash ^= ContentType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Content);
      }
      if (ContentLength != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ContentLength);
      }
      if (ContentType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ContentType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      if (ContentLength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ContentLength);
      }
      if (ContentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContentType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.ContentLength != 0) {
        ContentLength = other.ContentLength;
      }
      if (other.ContentType.Length != 0) {
        ContentType = other.ContentType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Content = input.ReadBytes();
            break;
          }
          case 16: {
            ContentLength = input.ReadInt32();
            break;
          }
          case 26: {
            ContentType = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Updater.GRPCService.Protocol.IUpdateServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      content_ = other.content_;
      statusCode_ = other.statusCode_;
      contentLength_ = other.contentLength_;
      contentType_ = other.contentType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "Content" field.</summary>
    public const int ContentFieldNumber = 1;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StatusCode" field.</summary>
    public const int StatusCodeFieldNumber = 2;
    private int statusCode_;
    /// <summary>
    ///应该是个枚举，状态码
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "ContentLength" field.</summary>
    public const int ContentLengthFieldNumber = 3;
    private int contentLength_;
    /// <summary>
    ///要检查数据长度
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ContentLength {
      get { return contentLength_; }
      set {
        contentLength_ = value;
      }
    }

    /// <summary>Field number for the "ContentType" field.</summary>
    public const int ContentTypeFieldNumber = 4;
    private string contentType_ = "";
    /// <summary>
    ///内容类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContentType {
      get { return contentType_; }
      set {
        contentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (StatusCode != other.StatusCode) return false;
      if (ContentLength != other.ContentLength) return false;
      if (ContentType != other.ContentType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (ContentLength != 0) hash ^= ContentLength.GetHashCode();
      if (ContentType.Length != 0) hash ^= ContentType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Content);
      }
      if (StatusCode != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(StatusCode);
      }
      if (ContentLength != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ContentLength);
      }
      if (ContentType.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ContentType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
      }
      if (ContentLength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ContentLength);
      }
      if (ContentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContentType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.ContentLength != 0) {
        ContentLength = other.ContentLength;
      }
      if (other.ContentType.Length != 0) {
        ContentType = other.ContentType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Content = input.ReadBytes();
            break;
          }
          case 16: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 24: {
            ContentLength = input.ReadInt32();
            break;
          }
          case 34: {
            ContentType = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
