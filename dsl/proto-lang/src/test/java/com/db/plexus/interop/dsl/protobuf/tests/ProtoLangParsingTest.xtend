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
/*
 * generated by Xtext 2.12.0
 */
package com.db.plexus.interop.dsl.protobuf.tests

import com.google.inject.Inject
import org.eclipse.xtext.testing.XtextRunner
import org.junit.Assert
import org.junit.Test
import org.junit.runner.RunWith
import org.eclipse.emf.ecore.resource.ResourceSet
import org.eclipse.emf.common.util.URI
import org.eclipse.xtext.validation.IResourceValidator
import org.eclipse.xtext.util.CancelIndicator
import org.eclipse.xtext.validation.CheckMode
import org.eclipse.emf.ecore.resource.Resource
import org.eclipse.xtext.EcoreUtil2
import org.eclipse.xtext.resource.XtextResource
import org.eclipse.xtext.validation.Issue
import java.util.List
import java.util.LinkedList
import org.eclipse.xtext.testing.InjectWith

@RunWith(XtextRunner)
@InjectWith(ProtoLangInjectorProvider)
class ProtoLangParsingTest {
	
	@Inject
	ResourceSet rs	

	@Test
	def void loadFile() {
		loadAndValidateResource("com/db/plexus/interop/dsl/protobuf/tests/example1.proto", 4)									
	}
		
	@Test
	def void loadOptionsProto() {		
		loadAndValidateResource("com/db/plexus/interop/dsl/protobuf/tests/option_usage.proto", 4)									
	}
	
	@Test
	def void loadDescriptorProto() {
		loadAndValidateResource("google/protobuf/descriptor.proto", 1)		
	}
	
	@Test
	def void loadApiProto() {
		loadAndValidateResource("google/protobuf/api.proto", 5)		
	}
	
	@Test
	def void loadScopingProto() {
		loadAndValidateResource("com/db/plexus/interop/dsl/protobuf/tests/scoping/test1.proto", 3)
	}
	
	@Test
	def void loadEnumValuesNamingProto() {
		val resourceUri = "com/db/plexus/interop/dsl/protobuf/tests/enum_values_naming.proto"
		val uri = URI.createURI(ClassLoader.getSystemClassLoader().getResource(resourceUri).toURI().toString())
		System.out.println("Parsing " + uri)
		Assert.assertEquals(0, rs.resources.length)
		rs.getResource(uri, true)
		EcoreUtil2.resolveAll(rs);
		val allResources = rs.resources
		val issues = new LinkedList<Issue>()		
		for (r : allResources) {
			validateResource(r, issues)
		}
		Assert.assertEquals(8, issues.length)
		System.out.println(issues.length + " expected issues found: ")
		for (issue : issues) {
			System.out.println(issue);
		}			
	}
	
	def loadAndValidateResource(String resourceUri, int expectedResourceCount) {
		val uri = URI.createURI(ClassLoader.getSystemClassLoader().getResource(resourceUri).toURI().toString())
		System.out.println("Parsing " + uri)
		Assert.assertEquals(0, rs.resources.length)
		val resource = rs.getResource(uri, true)
		EcoreUtil2.resolveAll(rs);
		val allResources = rs.resources
		val issues = new LinkedList<Issue>()		
		for (r : allResources) {
			validateResource(r, issues)
		}
		for (issue : issues) {
			System.err.println(issue);
		}
		Assert.assertEquals(0, issues.length)
		Assert.assertEquals(expectedResourceCount, allResources.length)
		return resource
	}
	
	def validateResource(Resource r, List<Issue> issues) {
		val validator = (r as XtextResource).getResourceServiceProvider().get(typeof(IResourceValidator));
		System.out.println("Validating " + r.URI)
		issues.addAll(validator.validate(r, CheckMode.ALL, CancelIndicator.NullImpl))								
	}	
}