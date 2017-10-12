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
namespace Plexus.Interop.Apps.Internal
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Plexus.Interop.Apps.Internal.Generated;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Plexus.Processes;

    internal sealed class NativeAppLauncher : ProcessBase
    {
        private static readonly ILogger Log = LogManager.GetLogger<NativeAppLauncher>();

        private readonly SubProcessLauncher _subProcessLauncher;
        private readonly string _cmdBasePath;
        private readonly JsonSerializer _jsonSerializer;
        private readonly CancellationToken _cancellationToken;
        private IClient _client;

        public Plexus.UniqueId Id { get; }

        public NativeAppLauncher(
            string cmdBasePath, 
            SubProcessLauncher subProcessLauncher, 
            JsonSerializer jsonSerializer,
            CancellationToken cancellationToken)
        {
            Id = Plexus.UniqueId.Generate();
            _cmdBasePath = cmdBasePath;
            _subProcessLauncher = subProcessLauncher;
            _jsonSerializer = jsonSerializer;
            _cancellationToken = cancellationToken;
        }

        protected override async Task<Task> StartCoreAsync()
        {
            var options = new ClientOptionsBuilder()
                .WithDefaultConfiguration(Directory.GetCurrentDirectory())
                .WithApplicationId("interop.NativeAppLauncher")
                .WithAppInstanceId(Id)
                .WithProvidedService(
                    "interop.AppLauncherService",
                    s => s.WithUnaryMethod<AppLaunchRequest, AppLaunchResponse>("Launch", LaunchAsync))
                .WithCancellationToken(_cancellationToken)
                .Build();
            _client = ClientFactory.Instance.Create(options);
            await _client.ConnectAsync().ConfigureAwait(false);
            Log.Debug("Connected");
            return ProcessAsync();
        }
        
        private Task<AppLaunchResponse> LaunchAsync(AppLaunchRequest request, MethodCallContext context)
        {
            Log.Debug("Launch request received: {0}", request);
            var paramsDto = _jsonSerializer.Deserialize<NativeAppLauncherParamsDto>(
                new JTokenReader(JToken.Parse(request.LaunchParamsJson)));
            var cmd = Path.Combine(_cmdBasePath, paramsDto.Cmd);
            var id = _subProcessLauncher.Launch(cmd, paramsDto.Args);
            Log.Trace("Launched app instance {0} by request: {1}", id, request);
            return Task.FromResult(new AppLaunchResponse
            {
                AppInstanceId = new UniqueId
                {
                    Lo = id.Lo,
                    Hi = id.Hi
                }
            });
        }

        private async Task ProcessAsync()
        {
            await _client.Completion.ConfigureAwait(false);
        }
    }
}
