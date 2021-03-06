﻿// Copyright 2014 EventBooking.com, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, 
// software distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and limitations under the License

#region

using System;
using RazorEngine;
using RazorEngine.Templating;

#endregion

namespace AntiShaun
{
	public interface ICompileService
	{
		void Compile( ITemplate template, String cacheName );
	}

	public class CompileService : ICompileService
	{
		private readonly ITemplateService _templateService;

		public CompileService ( ITemplateService templateService )
		{
			_templateService = templateService;
		}


		public void Compile( ITemplate template, String cacheName )
		{

			_templateService.Compile( template.Content, template.Meta.Type, cacheName );
			template.CachedTemplateIdentifier = cacheName;
		}
	}
}