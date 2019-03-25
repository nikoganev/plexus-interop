// <auto-generated>
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: interop\app_lifecycle_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Testing.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
	public static partial class AppLifecycleService {
		
		public const string Id = "interop.AppLifecycleService";			
		public const string ResolveAppMethodId = "ResolveApp";
		public const string GetLifecycleEventStreamMethodId = "GetLifecycleEventStream";
		public const string GetInvocationEventStreamMethodId = "GetInvocationEventStream";
		
		public static readonly AppLifecycleService.Descriptor DefaultDescriptor = CreateDescriptor();
		
		public static AppLifecycleService.Descriptor CreateDescriptor() {
			return new AppLifecycleService.Descriptor();
		} 
		
		public static AppLifecycleService.Descriptor CreateDescriptor(string alias) {
			return new AppLifecycleService.Descriptor(alias);
		}				
	
		public partial interface IResolveAppProxy {
			IUnaryMethodCall<global::Plexus.Interop.Testing.Generated.ResolveAppResponse> ResolveApp(global::Plexus.Interop.Testing.Generated.ResolveAppRequest request);
		}
		
		public partial interface IGetLifecycleEventStreamProxy {
			IServerStreamingMethodCall<global::Plexus.Interop.Testing.Generated.AppLifecycleEvent> GetLifecycleEventStream(global::Google.Protobuf.WellKnownTypes.Empty request);
		}
		
		public partial interface IGetInvocationEventStreamProxy {
			IServerStreamingMethodCall<global::Plexus.Interop.Testing.Generated.InvocationEvent> GetInvocationEventStream(global::Google.Protobuf.WellKnownTypes.Empty request);
		}
		
		public partial interface IResolveAppImpl {
			Task<global::Plexus.Interop.Testing.Generated.ResolveAppResponse> ResolveApp(global::Plexus.Interop.Testing.Generated.ResolveAppRequest request, MethodCallContext context);
		}
		
		public partial interface IGetLifecycleEventStreamImpl {
			Task GetLifecycleEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Testing.Generated.AppLifecycleEvent> responseStream, MethodCallContext context);
		}
		
		public partial interface IGetInvocationEventStreamImpl {
			Task GetInvocationEventStream(global::Google.Protobuf.WellKnownTypes.Empty request, IWritableChannel<global::Plexus.Interop.Testing.Generated.InvocationEvent> responseStream, MethodCallContext context);
		}
		
		public sealed partial class Descriptor {
		
			public UnaryMethod<global::Plexus.Interop.Testing.Generated.ResolveAppRequest, global::Plexus.Interop.Testing.Generated.ResolveAppResponse> ResolveAppMethod {get; private set; }
			public ServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Testing.Generated.AppLifecycleEvent> GetLifecycleEventStreamMethod {get; private set; }
			public ServerStreamingMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Testing.Generated.InvocationEvent> GetInvocationEventStreamMethod {get; private set; }
			
			public Descriptor() {				
				ResolveAppMethod = Method.Unary<global::Plexus.Interop.Testing.Generated.ResolveAppRequest, global::Plexus.Interop.Testing.Generated.ResolveAppResponse>(Id, ResolveAppMethodId);
				GetLifecycleEventStreamMethod = Method.ServerStreaming<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Testing.Generated.AppLifecycleEvent>(Id, GetLifecycleEventStreamMethodId);
				GetInvocationEventStreamMethod = Method.ServerStreaming<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Testing.Generated.InvocationEvent>(Id, GetInvocationEventStreamMethodId);
			}
		
			public Descriptor(string alias) {
				ResolveAppMethod = Method.Unary<global::Plexus.Interop.Testing.Generated.ResolveAppRequest, global::Plexus.Interop.Testing.Generated.ResolveAppResponse>(Id, alias, ResolveAppMethodId);
				GetLifecycleEventStreamMethod = Method.ServerStreaming<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Testing.Generated.AppLifecycleEvent>(Id, alias, GetLifecycleEventStreamMethodId);
				GetInvocationEventStreamMethod = Method.ServerStreaming<global::Google.Protobuf.WellKnownTypes.Empty, global::Plexus.Interop.Testing.Generated.InvocationEvent>(Id, alias, GetInvocationEventStreamMethodId);
			}
		}
	}
					
}
#endregion Designer generated code