// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Greeter/protos/greeter.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Example.Grpc {

  /// <summary>Holder for reflection information generated from Greeter/protos/greeter.proto</summary>
  public static partial class GreeterReflection {

    #region Descriptor
    /// <summary>File descriptor for Greeter/protos/greeter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreeterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHcmVldGVyL3Byb3Rvcy9ncmVldGVyLnByb3RvEhBjb20uZXhhbXBsZS5n",
            "cnBjIuQBCgxIZWxsb1JlcXVlc3QSDAoEbmFtZRgBIAEoCRILCgNhZ2UYAiAB",
            "KAUSDwoHaG9iYmllcxgDIAMoCRJECgtiYWdPZlRyaWNrcxgEIAMoCzIvLmNv",
            "bS5leGFtcGxlLmdycGMuSGVsbG9SZXF1ZXN0LkJhZ09mVHJpY2tzRW50cnkS",
            "LgoJc2VudGltZW50GAUgASgOMhsuY29tLmV4YW1wbGUuZ3JwYy5TZW50aW1l",
            "bnQaMgoQQmFnT2ZUcmlja3NFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY",
            "AiABKAk6AjgBIiEKDUhlbGxvUmVzcG9uc2USEAoIZ3JlZXRpbmcYASABKAki",
            "DgoMUXVlcnlSZXF1ZXN0IiAKDVF1ZXJ5UmVzcG9uc2USDwoHc3FsRGF0YRgB",
            "IAEoCSIsCg1JbnNlcnRSZXF1ZXN0EgwKBG5hbWUYASABKAkSDQoFcHJpY2UY",
            "AiABKAEiEAoOSW5zZXJ0UmVzcG9uc2UqLQoJU2VudGltZW50EgkKBUhBUFBZ",
            "EAASCgoGU0xFRVBZEAESCQoFQU5HUlkQAjL1AQoPR3JlZXRpbmdTZXJ2aWNl",
            "EksKCGdyZWV0aW5nEh4uY29tLmV4YW1wbGUuZ3JwYy5IZWxsb1JlcXVlc3Qa",
            "Hy5jb20uZXhhbXBsZS5ncnBjLkhlbGxvUmVzcG9uc2USSAoFcXVlcnkSHi5j",
            "b20uZXhhbXBsZS5ncnBjLlF1ZXJ5UmVxdWVzdBofLmNvbS5leGFtcGxlLmdy",
            "cGMuUXVlcnlSZXNwb25zZRJLCgZpbnNlcnQSHy5jb20uZXhhbXBsZS5ncnBj",
            "Lkluc2VydFJlcXVlc3QaIC5jb20uZXhhbXBsZS5ncnBjLkluc2VydFJlc3Bv",
            "bnNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Com.Example.Grpc.Sentiment), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.HelloRequest), global::Com.Example.Grpc.HelloRequest.Parser, new[]{ "Name", "Age", "Hobbies", "BagOfTricks", "Sentiment" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.HelloResponse), global::Com.Example.Grpc.HelloResponse.Parser, new[]{ "Greeting" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.QueryRequest), global::Com.Example.Grpc.QueryRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.QueryResponse), global::Com.Example.Grpc.QueryResponse.Parser, new[]{ "SqlData" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.InsertRequest), global::Com.Example.Grpc.InsertRequest.Parser, new[]{ "Name", "Price" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Grpc.InsertResponse), global::Com.Example.Grpc.InsertResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Sentiment {
    [pbr::OriginalName("HAPPY")] Happy = 0,
    [pbr::OriginalName("SLEEPY")] Sleepy = 1,
    [pbr::OriginalName("ANGRY")] Angry = 2,
  }

  #endregion

  #region Messages
  public sealed partial class HelloRequest : pb::IMessage<HelloRequest> {
    private static readonly pb::MessageParser<HelloRequest> _parser = new pb::MessageParser<HelloRequest>(() => new HelloRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest(HelloRequest other) : this() {
      name_ = other.name_;
      age_ = other.age_;
      hobbies_ = other.hobbies_.Clone();
      bagOfTricks_ = other.bagOfTricks_.Clone();
      sentiment_ = other.sentiment_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloRequest Clone() {
      return new HelloRequest(this);
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

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 2;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    /// <summary>Field number for the "hobbies" field.</summary>
    public const int HobbiesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_hobbies_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> hobbies_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Hobbies {
      get { return hobbies_; }
    }

    /// <summary>Field number for the "bagOfTricks" field.</summary>
    public const int BagOfTricksFieldNumber = 4;
    private static readonly pbc::MapField<string, string>.Codec _map_bagOfTricks_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 34);
    private readonly pbc::MapField<string, string> bagOfTricks_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> BagOfTricks {
      get { return bagOfTricks_; }
    }

    /// <summary>Field number for the "sentiment" field.</summary>
    public const int SentimentFieldNumber = 5;
    private global::Com.Example.Grpc.Sentiment sentiment_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Example.Grpc.Sentiment Sentiment {
      get { return sentiment_; }
      set {
        sentiment_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HelloRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Age != other.Age) return false;
      if(!hobbies_.Equals(other.hobbies_)) return false;
      if (!BagOfTricks.Equals(other.BagOfTricks)) return false;
      if (Sentiment != other.Sentiment) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
      hash ^= hobbies_.GetHashCode();
      hash ^= BagOfTricks.GetHashCode();
      if (Sentiment != 0) hash ^= Sentiment.GetHashCode();
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
      if (Age != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Age);
      }
      hobbies_.WriteTo(output, _repeated_hobbies_codec);
      bagOfTricks_.WriteTo(output, _map_bagOfTricks_codec);
      if (Sentiment != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Sentiment);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      size += hobbies_.CalculateSize(_repeated_hobbies_codec);
      size += bagOfTricks_.CalculateSize(_map_bagOfTricks_codec);
      if (Sentiment != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Sentiment);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Age != 0) {
        Age = other.Age;
      }
      hobbies_.Add(other.hobbies_);
      bagOfTricks_.Add(other.bagOfTricks_);
      if (other.Sentiment != 0) {
        Sentiment = other.Sentiment;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Age = input.ReadInt32();
            break;
          }
          case 26: {
            hobbies_.AddEntriesFrom(input, _repeated_hobbies_codec);
            break;
          }
          case 34: {
            bagOfTricks_.AddEntriesFrom(input, _map_bagOfTricks_codec);
            break;
          }
          case 40: {
            sentiment_ = (global::Com.Example.Grpc.Sentiment) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class HelloResponse : pb::IMessage<HelloResponse> {
    private static readonly pb::MessageParser<HelloResponse> _parser = new pb::MessageParser<HelloResponse>(() => new HelloResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloResponse(HelloResponse other) : this() {
      greeting_ = other.greeting_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloResponse Clone() {
      return new HelloResponse(this);
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
      return Equals(other as HelloResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Greeting != other.Greeting) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Greeting.Length != 0) hash ^= Greeting.GetHashCode();
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Greeting.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Greeting);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloResponse other) {
      if (other == null) {
        return;
      }
      if (other.Greeting.Length != 0) {
        Greeting = other.Greeting;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Greeting = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class QueryRequest : pb::IMessage<QueryRequest> {
    private static readonly pb::MessageParser<QueryRequest> _parser = new pb::MessageParser<QueryRequest>(() => new QueryRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryRequest(QueryRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryRequest Clone() {
      return new QueryRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class QueryResponse : pb::IMessage<QueryResponse> {
    private static readonly pb::MessageParser<QueryResponse> _parser = new pb::MessageParser<QueryResponse>(() => new QueryResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QueryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryResponse(QueryResponse other) : this() {
      sqlData_ = other.sqlData_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QueryResponse Clone() {
      return new QueryResponse(this);
    }

    /// <summary>Field number for the "sqlData" field.</summary>
    public const int SqlDataFieldNumber = 1;
    private string sqlData_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SqlData {
      get { return sqlData_; }
      set {
        sqlData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QueryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QueryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SqlData != other.SqlData) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SqlData.Length != 0) hash ^= SqlData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SqlData.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SqlData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SqlData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SqlData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QueryResponse other) {
      if (other == null) {
        return;
      }
      if (other.SqlData.Length != 0) {
        SqlData = other.SqlData;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SqlData = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class InsertRequest : pb::IMessage<InsertRequest> {
    private static readonly pb::MessageParser<InsertRequest> _parser = new pb::MessageParser<InsertRequest>(() => new InsertRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InsertRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertRequest(InsertRequest other) : this() {
      name_ = other.name_;
      price_ = other.price_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertRequest Clone() {
      return new InsertRequest(this);
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

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 2;
    private double price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InsertRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InsertRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Price != other.Price) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Price != 0D) hash ^= Price.GetHashCode();
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
      if (Price != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Price);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Price != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InsertRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Price != 0D) {
        Price = other.Price;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 17: {
            Price = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class InsertResponse : pb::IMessage<InsertResponse> {
    private static readonly pb::MessageParser<InsertResponse> _parser = new pb::MessageParser<InsertResponse>(() => new InsertResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InsertResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertResponse(InsertResponse other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertResponse Clone() {
      return new InsertResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InsertResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InsertResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InsertResponse other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
