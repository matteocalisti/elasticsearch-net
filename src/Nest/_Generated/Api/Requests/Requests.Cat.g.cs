// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatAliasesRequest, CatAliasesRequest>))]
	public interface ICatAliasesRequest : IRequest<CatAliasesRequestParameters>
	{
	}

	public class CatAliasesRequest : PlainRequestBase<CatAliasesRequestParameters>, ICatAliasesRequest
	{
		protected ICatAliasesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAliases;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/aliases</summary>
        public CatAliasesRequest() : base()
		{
		}

		///<summary>/_cat/aliases/{name}</summary>
        public CatAliasesRequest(Names name) : base(r => r.Optional("name", name))
		{
		}

		[JsonIgnore]
		public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatAllocationRequest, CatAllocationRequest>))]
	public interface ICatAllocationRequest : IRequest<CatAllocationRequestParameters>
	{
	}

	public class CatAllocationRequest : PlainRequestBase<CatAllocationRequestParameters>, ICatAllocationRequest
	{
		protected ICatAllocationRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAllocation;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/allocation</summary>
        public CatAllocationRequest() : base()
		{
		}

		///<summary>/_cat/allocation/{node_id}</summary>
        public CatAllocationRequest(NodeIds nodeId) : base(r => r.Optional("node_id", nodeId))
		{
		}

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatCountRequest, CatCountRequest>))]
	public interface ICatCountRequest : IRequest<CatCountRequestParameters>
	{
	}

	public class CatCountRequest : PlainRequestBase<CatCountRequestParameters>, ICatCountRequest
	{
		protected ICatCountRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatCount;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/count</summary>
        public CatCountRequest() : base()
		{
		}

		///<summary>/_cat/count/{index}</summary>
        public CatCountRequest(Indices index) : base(r => r.Optional("index", index))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatFielddataRequest, CatFielddataRequest>))]
	public interface ICatFielddataRequest : IRequest<CatFielddataRequestParameters>
	{
	}

	public class CatFielddataRequest : PlainRequestBase<CatFielddataRequestParameters>, ICatFielddataRequest
	{
		protected ICatFielddataRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatFielddata;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/fielddata</summary>
        public CatFielddataRequest() : base()
		{
		}

		///<summary>/_cat/fielddata/{fields}</summary>
        public CatFielddataRequest(Fields fields) : base(r => r.Optional("fields", fields))
		{
		}

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatHealthRequest, CatHealthRequest>))]
	public interface ICatHealthRequest : IRequest<CatHealthRequestParameters>
	{
	}

	public class CatHealthRequest : PlainRequestBase<CatHealthRequestParameters>, ICatHealthRequest
	{
		protected ICatHealthRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/health</summary>
        public CatHealthRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? IncludeTimestamp { get => Q<bool?>("include_timestamp"); set => Q("include_timestamp", value); }

		[JsonIgnore]
		public bool? Ts { get => Q<bool?>("ts"); set => Q("ts", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatHelpRequest, CatHelpRequest>))]
	public interface ICatHelpRequest : IRequest<CatHelpRequestParameters>
	{
	}

	public class CatHelpRequest : PlainRequestBase<CatHelpRequestParameters>, ICatHelpRequest
	{
		protected ICatHelpRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHelp;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat</summary>
        public CatHelpRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatIndicesRequest, CatIndicesRequest>))]
	public interface ICatIndicesRequest : IRequest<CatIndicesRequestParameters>
	{
	}

	public class CatIndicesRequest : PlainRequestBase<CatIndicesRequestParameters>, ICatIndicesRequest
	{
		protected ICatIndicesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatIndices;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/indices</summary>
        public CatIndicesRequest() : base()
		{
		}

		///<summary>/_cat/indices/{index}</summary>
        public CatIndicesRequest(Indices index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }

		[JsonIgnore]
		public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public Health? Health { get => Q<Health?>("health"); set => Q("health", value); }

		[JsonIgnore]
		public bool? IncludeUnloadedSegments { get => Q<bool?>("include_unloaded_segments"); set => Q("include_unloaded_segments", value); }

		[JsonIgnore]
		public bool? Pri { get => Q<bool?>("pri"); set => Q("pri", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatMasterRequest, CatMasterRequest>))]
	public interface ICatMasterRequest : IRequest<CatMasterRequestParameters>
	{
	}

	public class CatMasterRequest : PlainRequestBase<CatMasterRequestParameters>, ICatMasterRequest
	{
		protected ICatMasterRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMaster;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/master</summary>
        public CatMasterRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatDataFrameAnalyticsRequest, CatDataFrameAnalyticsRequest>))]
	public interface ICatDataFrameAnalyticsRequest : IRequest<CatDataFrameAnalyticsRequestParameters>
	{
	}

	public class CatDataFrameAnalyticsRequest : PlainRequestBase<CatDataFrameAnalyticsRequestParameters>, ICatDataFrameAnalyticsRequest
	{
		protected ICatDataFrameAnalyticsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/ml/data_frame/analytics</summary>
        public CatDataFrameAnalyticsRequest() : base()
		{
		}

		///<summary>/_cat/ml/data_frame/analytics/{id}</summary>
        public CatDataFrameAnalyticsRequest(Id id) : base(r => r.Optional("id", id))
		{
		}

		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatDatafeedsRequest, CatDatafeedsRequest>))]
	public interface ICatDatafeedsRequest : IRequest<CatDatafeedsRequestParameters>
	{
	}

	public class CatDatafeedsRequest : PlainRequestBase<CatDatafeedsRequestParameters>, ICatDatafeedsRequest
	{
		protected ICatDatafeedsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlDatafeeds;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/ml/datafeeds</summary>
        public CatDatafeedsRequest() : base()
		{
		}

		///<summary>/_cat/ml/datafeeds/{datafeed_id}</summary>
        public CatDatafeedsRequest(Id datafeedId) : base(r => r.Optional("datafeed_id", datafeedId))
		{
		}

		[JsonIgnore]
		public bool? AllowNoDatafeeds { get => Q<bool?>("allow_no_datafeeds"); set => Q("allow_no_datafeeds", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatJobsRequest, CatJobsRequest>))]
	public interface ICatJobsRequest : IRequest<CatJobsRequestParameters>
	{
	}

	public class CatJobsRequest : PlainRequestBase<CatJobsRequestParameters>, ICatJobsRequest
	{
		protected ICatJobsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlJobs;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/ml/anomaly_detectors</summary>
        public CatJobsRequest() : base()
		{
		}

		///<summary>/_cat/ml/anomaly_detectors/{job_id}</summary>
        public CatJobsRequest(Id jobId) : base(r => r.Optional("job_id", jobId))
		{
		}

		[JsonIgnore]
		public bool? AllowNoJobs { get => Q<bool?>("allow_no_jobs"); set => Q("allow_no_jobs", value); }

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatTrainedModelsRequest, CatTrainedModelsRequest>))]
	public interface ICatTrainedModelsRequest : IRequest<CatTrainedModelsRequestParameters>
	{
	}

	public class CatTrainedModelsRequest : PlainRequestBase<CatTrainedModelsRequestParameters>, ICatTrainedModelsRequest
	{
		protected ICatTrainedModelsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlTrainedModels;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/ml/trained_models</summary>
        public CatTrainedModelsRequest() : base()
		{
		}

		///<summary>/_cat/ml/trained_models/{model_id}</summary>
        public CatTrainedModelsRequest(Id modelId) : base(r => r.Optional("model_id", modelId))
		{
		}

		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatNodeAttributesRequest, CatNodeAttributesRequest>))]
	public interface ICatNodeAttributesRequest : IRequest<CatNodeAttributesRequestParameters>
	{
	}

	public class CatNodeAttributesRequest : PlainRequestBase<CatNodeAttributesRequestParameters>, ICatNodeAttributesRequest
	{
		protected ICatNodeAttributesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodeattrs;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/nodeattrs</summary>
        public CatNodeAttributesRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatNodesRequest, CatNodesRequest>))]
	public interface ICatNodesRequest : IRequest<CatNodesRequestParameters>
	{
	}

	public class CatNodesRequest : PlainRequestBase<CatNodesRequestParameters>, ICatNodesRequest
	{
		protected ICatNodesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodes;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/nodes</summary>
        public CatNodesRequest() : base()
		{
		}

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatPendingTasksRequest, CatPendingTasksRequest>))]
	public interface ICatPendingTasksRequest : IRequest<CatPendingTasksRequestParameters>
	{
	}

	public class CatPendingTasksRequest : PlainRequestBase<CatPendingTasksRequestParameters>, ICatPendingTasksRequest
	{
		protected ICatPendingTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/pending_tasks</summary>
        public CatPendingTasksRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatPluginsRequest, CatPluginsRequest>))]
	public interface ICatPluginsRequest : IRequest<CatPluginsRequestParameters>
	{
	}

	public class CatPluginsRequest : PlainRequestBase<CatPluginsRequestParameters>, ICatPluginsRequest
	{
		protected ICatPluginsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPlugins;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/plugins</summary>
        public CatPluginsRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatRecoveryRequest, CatRecoveryRequest>))]
	public interface ICatRecoveryRequest : IRequest<CatRecoveryRequestParameters>
	{
	}

	public class CatRecoveryRequest : PlainRequestBase<CatRecoveryRequestParameters>, ICatRecoveryRequest
	{
		protected ICatRecoveryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/recovery</summary>
        public CatRecoveryRequest() : base()
		{
		}

		///<summary>/_cat/recovery/{index}</summary>
        public CatRecoveryRequest(Indices index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public bool? ActiveOnly { get => Q<bool?>("active_only"); set => Q("active_only", value); }

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatRepositoriesRequest, CatRepositoriesRequest>))]
	public interface ICatRepositoriesRequest : IRequest<CatRepositoriesRequestParameters>
	{
	}

	public class CatRepositoriesRequest : PlainRequestBase<CatRepositoriesRequestParameters>, ICatRepositoriesRequest
	{
		protected ICatRepositoriesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRepositories;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/repositories</summary>
        public CatRepositoriesRequest() : base()
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatSegmentsRequest, CatSegmentsRequest>))]
	public interface ICatSegmentsRequest : IRequest<CatSegmentsRequestParameters>
	{
	}

	public class CatSegmentsRequest : PlainRequestBase<CatSegmentsRequestParameters>, ICatSegmentsRequest
	{
		protected ICatSegmentsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSegments;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/segments</summary>
        public CatSegmentsRequest() : base()
		{
		}

		///<summary>/_cat/segments/{index}</summary>
        public CatSegmentsRequest(Indices index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatShardsRequest, CatShardsRequest>))]
	public interface ICatShardsRequest : IRequest<CatShardsRequestParameters>
	{
	}

	public class CatShardsRequest : PlainRequestBase<CatShardsRequestParameters>, ICatShardsRequest
	{
		protected ICatShardsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatShards;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/shards</summary>
        public CatShardsRequest() : base()
		{
		}

		///<summary>/_cat/shards/{index}</summary>
        public CatShardsRequest(Indices index) : base(r => r.Optional("index", index))
		{
		}

		[JsonIgnore]
		public Bytes? Bytes { get => Q<Bytes?>("bytes"); set => Q("bytes", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatSnapshotsRequest, CatSnapshotsRequest>))]
	public interface ICatSnapshotsRequest : IRequest<CatSnapshotsRequestParameters>
	{
	}

	public class CatSnapshotsRequest : PlainRequestBase<CatSnapshotsRequestParameters>, ICatSnapshotsRequest
	{
		protected ICatSnapshotsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSnapshots;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/snapshots</summary>
        public CatSnapshotsRequest() : base()
		{
		}

		///<summary>/_cat/snapshots/{repository}</summary>
        public CatSnapshotsRequest(Names repository) : base(r => r.Optional("repository", repository))
		{
		}

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatTasksRequest, CatTasksRequest>))]
	public interface ICatTasksRequest : IRequest<CatTasksRequestParameters>
	{
	}

	public class CatTasksRequest : PlainRequestBase<CatTasksRequestParameters>, ICatTasksRequest
	{
		protected ICatTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/tasks</summary>
        public CatTasksRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }

		[JsonIgnore]
		public long? ParentTask { get => Q<long?>("parent_task"); set => Q("parent_task", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatTemplatesRequest, CatTemplatesRequest>))]
	public interface ICatTemplatesRequest : IRequest<CatTemplatesRequestParameters>
	{
	}

	public class CatTemplatesRequest : PlainRequestBase<CatTemplatesRequestParameters>, ICatTemplatesRequest
	{
		protected ICatTemplatesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTemplates;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/templates</summary>
        public CatTemplatesRequest() : base()
		{
		}

		///<summary>/_cat/templates/{name}</summary>
        public CatTemplatesRequest(Name name) : base(r => r.Optional("name", name))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatThreadPoolRequest, CatThreadPoolRequest>))]
	public interface ICatThreadPoolRequest : IRequest<CatThreadPoolRequestParameters>
	{
	}

	public class CatThreadPoolRequest : PlainRequestBase<CatThreadPoolRequestParameters>, ICatThreadPoolRequest
	{
		protected ICatThreadPoolRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatThreadPool;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/thread_pool</summary>
        public CatThreadPoolRequest() : base()
		{
		}

		///<summary>/_cat/thread_pool/{thread_pool_patterns}</summary>
        public CatThreadPoolRequest(Names threadPoolPatterns) : base(r => r.Optional("thread_pool_patterns", threadPoolPatterns))
		{
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<ICatTransformsRequest, CatTransformsRequest>))]
	public interface ICatTransformsRequest : IRequest<CatTransformsRequestParameters>
	{
	}

	public class CatTransformsRequest : PlainRequestBase<CatTransformsRequestParameters>, ICatTransformsRequest
	{
		protected ICatTransformsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTransforms;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_cat/transforms</summary>
        public CatTransformsRequest() : base()
		{
		}

		///<summary>/_cat/transforms/{transform_id}</summary>
        public CatTransformsRequest(Id transformId) : base(r => r.Optional("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }
	}
}