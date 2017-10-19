﻿/**
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
 namespace Plexus.Interop.Broker.Internal
{
    using Plexus.Channels;
    using Plexus.Interop.Protocol;
    using Plexus.Interop.Protocol.Discovery;
    using Plexus.Interop.Protocol.Invocation;
    using Plexus.Interop.Transport;
    using System;
    using System.Threading.Tasks;

    internal sealed class ClientRequestHandler : IClientRequestHandler
    {
        private static readonly ILogger Log = LogManager.GetLogger<ClientRequestHandler>();

        private readonly IProtocolSerializer _protocolSerializer;
        private readonly ClientToBrokerRequestHandler<Task, (IClientConnection, ITransportChannel)> _clientToBrokerRequestHandler;
        private readonly IDiscoveryRequestHandler _discoveryRequestHandler;
        private readonly IInvocationRequestHandler _invocationRequestHandler;

        public ClientRequestHandler(
            IClientConnectionTracker clientConnectionTracker,
            IProtocolImplementation protocol,
            IRegistryService registryService)
        {
            _protocolSerializer = protocol.Serializer;
            _discoveryRequestHandler = new DiscoveryRequestHandler(clientConnectionTracker, protocol, registryService);
            _invocationRequestHandler = new InvocationRequestHandler(clientConnectionTracker, protocol, registryService);
            _clientToBrokerRequestHandler =
                new ClientToBrokerRequestHandler<Task, (IClientConnection, ITransportChannel)>(
                    HandleInvocationAsync,
                    HandleDiscoveryAsync,
                    HandleDiscoveryAsync);
        }

        public async Task HandleChannelAsync(IClientConnection connection, ITransportChannel channel)
        {
            try
            {
                Log.Debug("Starting processing new request {0} from {1}", channel, connection);
                var frame = await channel.In.ReadAsync().ConfigureAwait(false);
                var request = _protocolSerializer.DeserializeClientToBrokerRequest(frame.Payload);
                await request.Handle(_clientToBrokerRequestHandler, (connection, channel)).ConfigureAwait(false);
                channel.Out.TryCompleteWriting();
            }
            catch (Exception ex)
            {
                channel.Out.TryTerminateWriting(ex);
            }
            finally
            {
                await channel.Completion.ConfigureAwait(false);
            }
        }

        private async Task HandleDiscoveryAsync(
            IServiceDiscoveryRequest request,
            (IClientConnection SourceConnection, ITransportChannel SourceChannel) args)
        {
            var (sourceConnection, sourceChannel) = args;
            await _discoveryRequestHandler.HandleAsync(request, sourceConnection, sourceChannel).ConfigureAwait(false);
        }

        private async Task HandleDiscoveryAsync(IMethodDiscoveryRequest request, (IClientConnection, ITransportChannel) args)
        {
            var (sourceConnection, sourceChannel) = args;
            await _discoveryRequestHandler.HandleAsync(request, sourceConnection, sourceChannel).ConfigureAwait(false);
        }

        private async Task HandleInvocationAsync(
            IInvocationStart request,
            (IClientConnection SourceConnection, ITransportChannel SourceChannel) args)
        {
            var (sourceConnection, sourceChannel) = args;
            await _invocationRequestHandler.HandleAsync(request, sourceConnection, sourceChannel).ConfigureAwait(false);
        }
    }
}
