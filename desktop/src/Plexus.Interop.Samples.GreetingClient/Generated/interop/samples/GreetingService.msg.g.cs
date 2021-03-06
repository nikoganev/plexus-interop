/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: interop/samples/greeting_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Samples.GreetingClient.Generated {

  /// <summary>Holder for reflection information generated from interop/samples/greeting_service.proto</summary>
  internal static partial class GreetingServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/samples/greeting_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetingServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZpbnRlcm9wL3NhbXBsZXMvZ3JlZXRpbmdfc2VydmljZS5wcm90bxIPaW50",
            "ZXJvcC5zYW1wbGVzGhVpbnRlcm9wL29wdGlvbnMucHJvdG8iRAoPR3JlZXRp",
            "bmdSZXF1ZXN0EgwKBG5hbWUYASABKAk6I5LbBB9pbnRlcm9wLnNhbXBsZXMu",
            "R3JlZXRpbmdSZXF1ZXN0IkoKEEdyZWV0aW5nUmVzcG9uc2USEAoIZ3JlZXRp",
            "bmcYASABKAk6JJLbBCBpbnRlcm9wLnNhbXBsZXMuR3JlZXRpbmdSZXNwb25z",
            "ZTKUAwoPR3JlZXRpbmdTZXJ2aWNlEkwKBVVuYXJ5EiAuaW50ZXJvcC5zYW1w",
            "bGVzLkdyZWV0aW5nUmVxdWVzdBohLmludGVyb3Auc2FtcGxlcy5HcmVldGlu",
            "Z1Jlc3BvbnNlElgKD1NlcnZlclN0cmVhbWluZxIgLmludGVyb3Auc2FtcGxl",
            "cy5HcmVldGluZ1JlcXVlc3QaIS5pbnRlcm9wLnNhbXBsZXMuR3JlZXRpbmdS",
            "ZXNwb25zZTABElgKD0NsaWVudFN0cmVhbWluZxIgLmludGVyb3Auc2FtcGxl",
            "cy5HcmVldGluZ1JlcXVlc3QaIS5pbnRlcm9wLnNhbXBsZXMuR3JlZXRpbmdS",
            "ZXNwb25zZSgBEloKD0R1cGxleFN0cmVhbWluZxIgLmludGVyb3Auc2FtcGxl",
            "cy5HcmVldGluZ1JlcXVlc3QaIS5pbnRlcm9wLnNhbXBsZXMuR3JlZXRpbmdS",
            "ZXNwb25zZSgBMAEaI5LbBB9pbnRlcm9wLnNhbXBsZXMuR3JlZXRpbmdTZXJ2",
            "aWNlQjKqAi9QbGV4dXMuSW50ZXJvcC5TYW1wbGVzLkdyZWV0aW5nQ2xpZW50",
            "LkdlbmVyYXRlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Samples.GreetingClient.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingRequest), global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingResponse), global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingResponse.Parser, new[]{ "Greeting" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class GreetingRequest : pb::IMessage<GreetingRequest> {
    private static readonly pb::MessageParser<GreetingRequest> _parser = new pb::MessageParser<GreetingRequest>(() => new GreetingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GreetingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingRequest(GreetingRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingRequest Clone() {
      return new GreetingRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GreetingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GreetingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GreetingRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class GreetingResponse : pb::IMessage<GreetingResponse> {
    private static readonly pb::MessageParser<GreetingResponse> _parser = new pb::MessageParser<GreetingResponse>(() => new GreetingResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GreetingResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingResponse(GreetingResponse other) : this() {
      greeting_ = other.greeting_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GreetingResponse Clone() {
      return new GreetingResponse(this);
    }

    /// <summary>Field number for the "greeting" field.</summary>
    public const int GreetingFieldNumber = 1;
    private string greeting_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Greeting {
      get { return greeting_; }
      set {
        greeting_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GreetingResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GreetingResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Greeting != other.Greeting) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Greeting.Length != 0) hash ^= Greeting.GetHashCode();
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
      if (Greeting.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Greeting);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Greeting.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Greeting);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GreetingResponse other) {
      if (other == null) {
        return;
      }
      if (other.Greeting.Length != 0) {
        Greeting = other.Greeting;
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
            Greeting = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
