/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the 'License');
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an 'AS IS' BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
import { InteropRegistryService, Application } from '@plexus-interop/metadata';
import { GenericClientApi } from '@plexus-interop/client';
import { Method, InvokeResult } from '../api/client-api';
import { isMethod } from '../types';
import { getProvidedMethodByAlias } from '../metadata';
import { GenericRequest } from '@plexus-interop/client-api';
import { DiscoverMethodHandler } from './DiscoverMethodHandler';

export class InvokeHandler {

    public constructor(
        private readonly registryService: InteropRegistryService,
        private readonly genericClienApi: GenericClientApi,
        private readonly app: Application
    ) { }

    public async handle(method: string | Method, args?: any): Promise<InvokeResult> {

        const methodAlias: string = isMethod(method) ? method.name : method;
        const providedMethod = getProvidedMethodByAlias(methodAlias, this.app, this.registryService);
        const requestType = providedMethod.method.requestMessage.id;
        const responseType = providedMethod.method.responseMessage.id;

        let requestInfo: GenericRequest = 
            await new DiscoverMethodHandler(this.registryService, this.genericClienApi, this.app)
                .findRequestInfo(method);
                
        return new Promise<InvokeResult>((resolve, reject) => {
            this.genericClienApi.sendUnaryRequest(requestInfo, args, {
                value: v => resolve(v),
                error: e => reject(e)
            }, requestType, responseType);
        });
    }
}