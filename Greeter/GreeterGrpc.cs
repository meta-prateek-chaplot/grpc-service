// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Greeter/protos/greeter.proto
// Original file comments:
// Copyright 2017, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Com.Example.Grpc {
  public static partial class GreetingService
  {
    static readonly string __ServiceName = "com.example.grpc.GreetingService";

    static readonly grpc::Marshaller<global::Com.Example.Grpc.HelloRequest> __Marshaller_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Grpc.HelloResponse> __Marshaller_HelloResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.HelloResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Grpc.QueryRequest> __Marshaller_QueryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.QueryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Grpc.QueryResponse> __Marshaller_QueryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.QueryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Grpc.InsertRequest> __Marshaller_InsertRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.InsertRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Com.Example.Grpc.InsertResponse> __Marshaller_InsertResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.InsertResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Com.Example.Grpc.HelloRequest, global::Com.Example.Grpc.HelloResponse> __Method_greeting = new grpc::Method<global::Com.Example.Grpc.HelloRequest, global::Com.Example.Grpc.HelloResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "greeting",
        __Marshaller_HelloRequest,
        __Marshaller_HelloResponse);

    static readonly grpc::Method<global::Com.Example.Grpc.QueryRequest, global::Com.Example.Grpc.QueryResponse> __Method_query = new grpc::Method<global::Com.Example.Grpc.QueryRequest, global::Com.Example.Grpc.QueryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "query",
        __Marshaller_QueryRequest,
        __Marshaller_QueryResponse);

    static readonly grpc::Method<global::Com.Example.Grpc.InsertRequest, global::Com.Example.Grpc.InsertResponse> __Method_insert = new grpc::Method<global::Com.Example.Grpc.InsertRequest, global::Com.Example.Grpc.InsertResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "insert",
        __Marshaller_InsertRequest,
        __Marshaller_InsertResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GreetingService</summary>
    public abstract partial class GreetingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Com.Example.Grpc.HelloResponse> greeting(global::Com.Example.Grpc.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Com.Example.Grpc.QueryResponse> query(global::Com.Example.Grpc.QueryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Com.Example.Grpc.InsertResponse> insert(global::Com.Example.Grpc.InsertRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GreetingService</summary>
    public partial class GreetingServiceClient : grpc::ClientBase<GreetingServiceClient>
    {
      /// <summary>Creates a new client for GreetingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreetingServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GreetingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreetingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreetingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreetingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Com.Example.Grpc.HelloResponse greeting(global::Com.Example.Grpc.HelloRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return greeting(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Grpc.HelloResponse greeting(global::Com.Example.Grpc.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_greeting, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Grpc.HelloResponse> greetingAsync(global::Com.Example.Grpc.HelloRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return greetingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Grpc.HelloResponse> greetingAsync(global::Com.Example.Grpc.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_greeting, null, options, request);
      }
      public virtual global::Com.Example.Grpc.QueryResponse query(global::Com.Example.Grpc.QueryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return query(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Grpc.QueryResponse query(global::Com.Example.Grpc.QueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_query, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Grpc.QueryResponse> queryAsync(global::Com.Example.Grpc.QueryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return queryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Grpc.QueryResponse> queryAsync(global::Com.Example.Grpc.QueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_query, null, options, request);
      }
      public virtual global::Com.Example.Grpc.InsertResponse insert(global::Com.Example.Grpc.InsertRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return insert(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Grpc.InsertResponse insert(global::Com.Example.Grpc.InsertRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_insert, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Grpc.InsertResponse> insertAsync(global::Com.Example.Grpc.InsertRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return insertAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Grpc.InsertResponse> insertAsync(global::Com.Example.Grpc.InsertRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_insert, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreetingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreetingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreetingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_greeting, serviceImpl.greeting)
          .AddMethod(__Method_query, serviceImpl.query)
          .AddMethod(__Method_insert, serviceImpl.insert).Build();
    }

  }
}
#endregion
