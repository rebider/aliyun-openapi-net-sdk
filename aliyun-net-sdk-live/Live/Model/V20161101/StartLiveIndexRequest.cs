/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class StartLiveIndexRequest : RpcAcsRequest<StartLiveIndexResponse>
    {
        public StartLiveIndexRequest()
            : base("live", "2016-11-01", "StartLiveIndex", "live", "openAPI")
        {
        }

		private string ossBucket;

		private string tokenId;

		private string domainName;

		private string ossEndpoint;

		private string inputUrl;

		private long? ownerId;

		private string appName;

		private int? interval;

		private string ossRamRole;

		private string streamName;

		private string ossUserId;

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
				DictionaryUtil.Add(QueryParameters, "OssBucket", value);
			}
		}

		public string TokenId
		{
			get
			{
				return tokenId;
			}
			set	
			{
				tokenId = value;
				DictionaryUtil.Add(QueryParameters, "TokenId", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "OssEndpoint", value);
			}
		}

		public string InputUrl
		{
			get
			{
				return inputUrl;
			}
			set	
			{
				inputUrl = value;
				DictionaryUtil.Add(QueryParameters, "InputUrl", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public int? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
			}
		}

		public string OssRamRole
		{
			get
			{
				return ossRamRole;
			}
			set	
			{
				ossRamRole = value;
				DictionaryUtil.Add(QueryParameters, "OssRamRole", value);
			}
		}

		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
			}
		}

		public string OssUserId
		{
			get
			{
				return ossUserId;
			}
			set	
			{
				ossUserId = value;
				DictionaryUtil.Add(QueryParameters, "OssUserId", value);
			}
		}

        public override StartLiveIndexResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartLiveIndexResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
