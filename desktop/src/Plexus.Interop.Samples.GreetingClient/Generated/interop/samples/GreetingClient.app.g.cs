/**
 * Copyright 2017 Plexus Interop Deutsche Bank AG
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
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: interop\samples\greeting_client.interop
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Samples.GreetingClient.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
					
	internal partial interface IGreetingClient: IClient {
		GreetingClient.IGreetingServiceProxy GreetingService { get; }
	}
	
	internal sealed partial class GreetingClient: ClientBase, IGreetingClient {
		
		public const string Id = "interop.samples.GreetingClient";
		
		private static ClientOptions CreateClientOptions(Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null) {
			ClientOptionsBuilder builder = new ClientOptionsBuilder().WithApplicationId(Id).WithDefaultConfiguration();
			if (setup != null) {
				builder = setup(builder);
			}									
			return builder.Build();					
		}
		
		public GreetingClient(Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null): base(CreateClientOptions(setup)) 
		{ 
			GreetingService = new GreetingClient.GreetingServiceProxy(this.CallInvoker);
		}
		
		public partial interface IGreetingServiceProxy:
			global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingService.IUnaryProxy,
			global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingService.IServerStreamingProxy,
			global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingService.IClientStreamingProxy,
			global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingService.IDuplexStreamingProxy
		{ }
		
		public sealed partial class GreetingServiceProxy: IGreetingServiceProxy {
			
			public static global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingService.Descriptor Descriptor = global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingService.DefaultDescriptor;
			
			private readonly IClientCallInvoker _callInvoker;
									
			public GreetingServiceProxy(IClientCallInvoker callInvoker) {
				_callInvoker = callInvoker;
			}						
			
			public IUnaryMethodCall<global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingResponse> Unary(global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingRequest request) {
				return _callInvoker.Call(Descriptor.UnaryMethod, request);
			}
			
			public IServerStreamingMethodCall<global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingResponse> ServerStreaming(global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingRequest request) {
				return _callInvoker.Call(Descriptor.ServerStreamingMethod, request);
			}
			
			public IClientStreamingMethodCall<global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingRequest, global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingResponse> ClientStreaming() {
				return _callInvoker.Call(Descriptor.ClientStreamingMethod);
			}
			
			public IDuplexStreamingMethodCall<global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingRequest, global::Plexus.Interop.Samples.GreetingClient.Generated.GreetingResponse> DuplexStreaming() {
				return _callInvoker.Call(Descriptor.DuplexStreamingMethod);
			}
		}
		
		public IGreetingServiceProxy GreetingService { get; private set; }
	}
}
#endregion Designer generated code
