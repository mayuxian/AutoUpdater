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
            "cm90b2NvbCIjChRHZXRWZXJzaW9uSW5mb1JxdWVzdBILCgNVcmwYASABKAki",
            "TwoLVmVyc2lvbkluZm8SCgoCSWQYASABKAkSDAoETmFtZRgCIAEoCRITCgtE",
            "ZXNjcmlwdGlvbhgDIAEoCRIRCglUaW1lU3RhbXAYBCABKAkiNAoPRG93bmxv",
            "YWRSZXF1ZXN0EgsKA1VybBgBIAEoCRIUCgxkb3dubG9hZFBhdGgYAiABKAki",
            "IQoORG93bmxvYWRSZXN1bHQSDwoHU3VjY2VzcxgBIAEoCDLyAQoOSVVwZGF0",
            "ZVNlcnZpY2UScQoOR2V0VmVyc2lvbkluZm8SMi5VcGRhdGVyLmdSUENTZXJ2",
            "aWNlLlByb3RvY29sLkdldFZlcnNpb25JbmZvUnF1ZXN0GikuVXBkYXRlci5n",
            "UlBDU2VydmljZS5Qcm90b2NvbC5WZXJzaW9uSW5mbyIAEm0KDERvd25sb2Fk",
            "RmlsZRItLlVwZGF0ZXIuZ1JQQ1NlcnZpY2UuUHJvdG9jb2wuRG93bmxvYWRS",
            "ZXF1ZXN0GiwuVXBkYXRlci5nUlBDU2VydmljZS5Qcm90b2NvbC5Eb3dubG9h",
            "ZFJlc3VsdCIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Updater.GRPCService.Protocol.GetVersionInfoRquest), global::Updater.GRPCService.Protocol.GetVersionInfoRquest.Parser, new[]{ "Url" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Updater.GRPCService.Protocol.VersionInfo), global::Updater.GRPCService.Protocol.VersionInfo.Parser, new[]{ "Id", "Name", "Description", "TimeStamp" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Updater.GRPCService.Protocol.DownloadRequest), global::Updater.GRPCService.Protocol.DownloadRequest.Parser, new[]{ "Url", "DownloadPath" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Updater.GRPCService.Protocol.DownloadResult), global::Updater.GRPCService.Protocol.DownloadResult.Parser, new[]{ "Success" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetVersionInfoRquest : pb::IMessage<GetVersionInfoRquest> {
    private static readonly pb::MessageParser<GetVersionInfoRquest> _parser = new pb::MessageParser<GetVersionInfoRquest>(() => new GetVersionInfoRquest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetVersionInfoRquest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Updater.GRPCService.Protocol.IUpdateServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetVersionInfoRquest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetVersionInfoRquest(GetVersionInfoRquest other) : this() {
      url_ = other.url_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetVersionInfoRquest Clone() {
      return new GetVersionInfoRquest(this);
    }

    /// <summary>Field number for the "Url" field.</summary>
    public const int UrlFieldNumber = 1;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetVersionInfoRquest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetVersionInfoRquest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Url.Length != 0) hash ^= Url.GetHashCode();
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
      if (Url.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetVersionInfoRquest other) {
      if (other == null) {
        return;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
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
            Url = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VersionInfo : pb::IMessage<VersionInfo> {
    private static readonly pb::MessageParser<VersionInfo> _parser = new pb::MessageParser<VersionInfo>(() => new VersionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Updater.GRPCService.Protocol.IUpdateServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo(VersionInfo other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      description_ = other.description_;
      timeStamp_ = other.timeStamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo Clone() {
      return new VersionInfo(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    ///Ψһ��ʶ  
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "TimeStamp" field.</summary>
    public const int TimeStampFieldNumber = 4;
    private string timeStamp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeStamp {
      get { return timeStamp_; }
      set {
        timeStamp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (TimeStamp != other.TimeStamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (TimeStamp.Length != 0) hash ^= TimeStamp.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (TimeStamp.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TimeStamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (TimeStamp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeStamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.TimeStamp.Length != 0) {
        TimeStamp = other.TimeStamp;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            TimeStamp = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DownloadRequest : pb::IMessage<DownloadRequest> {
    private static readonly pb::MessageParser<DownloadRequest> _parser = new pb::MessageParser<DownloadRequest>(() => new DownloadRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Updater.GRPCService.Protocol.IUpdateServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRequest(DownloadRequest other) : this() {
      url_ = other.url_;
      downloadPath_ = other.downloadPath_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRequest Clone() {
      return new DownloadRequest(this);
    }

    /// <summary>Field number for the "Url" field.</summary>
    public const int UrlFieldNumber = 1;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "downloadPath" field.</summary>
    public const int DownloadPathFieldNumber = 2;
    private string downloadPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DownloadPath {
      get { return downloadPath_; }
      set {
        downloadPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownloadRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Url != other.Url) return false;
      if (DownloadPath != other.DownloadPath) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (DownloadPath.Length != 0) hash ^= DownloadPath.GetHashCode();
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
      if (Url.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Url);
      }
      if (DownloadPath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DownloadPath);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (DownloadPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DownloadPath);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownloadRequest other) {
      if (other == null) {
        return;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.DownloadPath.Length != 0) {
        DownloadPath = other.DownloadPath;
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
            Url = input.ReadString();
            break;
          }
          case 18: {
            DownloadPath = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DownloadResult : pb::IMessage<DownloadResult> {
    private static readonly pb::MessageParser<DownloadResult> _parser = new pb::MessageParser<DownloadResult>(() => new DownloadResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Updater.GRPCService.Protocol.IUpdateServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadResult(DownloadResult other) : this() {
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadResult Clone() {
      return new DownloadResult(this);
    }

    /// <summary>Field number for the "Success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownloadResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownloadResult other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
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
          case 8: {
            Success = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
