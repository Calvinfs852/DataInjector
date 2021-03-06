﻿#region Apache License

// Copyright 2014 EventBooking.com, LLC
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

#endregion

#region

using System;

#endregion

namespace AntiShaun
{
	public class DocumentInformation
	{
		public DocumentInformation( OdfHandlerService.FileType fileType, Byte[] document, string content, OdfMetadata metadata )
		{
			FileType = fileType;
			Document = document;
			Content = content;
			Metadata = metadata;
		}

		public virtual OdfHandlerService.FileType FileType { get; private set; }
		public virtual Byte[] Document { get; private set; }
		public virtual String Content { get; private set; }
		public virtual OdfMetadata Metadata { get; private set; }
	}
}