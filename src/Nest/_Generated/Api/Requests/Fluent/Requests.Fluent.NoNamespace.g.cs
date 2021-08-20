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
//
// ------------------------------------------------

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public partial class BulkDescriptor<TSource> : RequestDescriptorBase<BulkDescriptor<TSource>, BulkRequestParameters, IBulkRequest<TSource>>, IBulkRequest<TSource>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceBulk;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_bulk</summary>
        public BulkDescriptor() : base()
		{
		}

		///<summary>/{index}/_bulk</summary>
        public BulkDescriptor(Nest.IndexName? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class ClearScrollDescriptor : RequestDescriptorBase<ClearScrollDescriptor, ClearScrollRequestParameters, IClearScrollRequest>, IClearScrollRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClearScroll;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_search/scroll</summary>
        public ClearScrollDescriptor() : base()
		{
		}
	}

	public partial class ClosePointInTimeDescriptor : RequestDescriptorBase<ClosePointInTimeDescriptor, ClosePointInTimeRequestParameters, IClosePointInTimeRequest>, IClosePointInTimeRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClosePointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_pit</summary>
        public ClosePointInTimeDescriptor() : base()
		{
		}
	}

	public partial class CountDescriptor : RequestDescriptorBase<CountDescriptor, CountRequestParameters, ICountRequest>, ICountRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCount;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_count</summary>
        public CountDescriptor() : base()
		{
		}

		///<summary>/{index}/_count</summary>
        public CountDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class CreateDescriptor<TDocument> : RequestDescriptorBase<CreateDescriptor<TDocument>, CreateRequestParameters, ICreateRequest<TDocument>>, ICreateRequest<TDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_create/{id}</summary>
        public CreateDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class DeleteDescriptor : RequestDescriptorBase<DeleteDescriptor, DeleteRequestParameters, IDeleteRequest>, IDeleteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public DeleteDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class DeleteByQueryDescriptor : RequestDescriptorBase<DeleteByQueryDescriptor, DeleteByQueryRequestParameters, IDeleteByQueryRequest>, IDeleteByQueryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_delete_by_query</summary>
        public DeleteByQueryDescriptor(Nest.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class DeleteByQueryRethrottleDescriptor : RequestDescriptorBase<DeleteByQueryRethrottleDescriptor, DeleteByQueryRethrottleRequestParameters, IDeleteByQueryRethrottleRequest>, IDeleteByQueryRethrottleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQueryRethrottle;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_delete_by_query/{task_id}/_rethrottle</summary>
        public DeleteByQueryRethrottleDescriptor(Nest.Id task_id) : base(r => r.Required("task_id", task_id))
		{
		}
	}

	public partial class DeleteScriptDescriptor : RequestDescriptorBase<DeleteScriptDescriptor, DeleteScriptRequestParameters, IDeleteScriptRequest>, IDeleteScriptRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteScript;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_scripts/{id}</summary>
        public DeleteScriptDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class ExistsDescriptor : RequestDescriptorBase<ExistsDescriptor, ExistsRequestParameters, IExistsRequest>, IExistsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExists;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public ExistsDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class ExistsSourceDescriptor : RequestDescriptorBase<ExistsSourceDescriptor, ExistsSourceRequestParameters, IExistsSourceRequest>, IExistsSourceRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExistsSource;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_source/{id}</summary>
        public ExistsSourceDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class ExplainDescriptor : RequestDescriptorBase<ExplainDescriptor, ExplainRequestParameters, IExplainRequest>, IExplainRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExplain;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_explain/{id}</summary>
        public ExplainDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class FieldCapsDescriptor : RequestDescriptorBase<FieldCapsDescriptor, FieldCapsRequestParameters, IFieldCapsRequest>, IFieldCapsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceFieldCaps;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_field_caps</summary>
        public FieldCapsDescriptor() : base()
		{
		}

		///<summary>/{index}/_field_caps</summary>
        public FieldCapsDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class GetDescriptor : RequestDescriptorBase<GetDescriptor, GetRequestParameters, IGetRequest>, IGetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public GetDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class GetScriptDescriptor : RequestDescriptorBase<GetScriptDescriptor, GetScriptRequestParameters, IGetScriptRequest>, IGetScriptRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScript;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_scripts/{id}</summary>
        public GetScriptDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class GetScriptContextDescriptor : RequestDescriptorBase<GetScriptContextDescriptor, GetScriptContextRequestParameters, IGetScriptContextRequest>, IGetScriptContextRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScriptContext;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_script_context</summary>
        public GetScriptContextDescriptor() : base()
		{
		}
	}

	public partial class GetScriptLanguagesDescriptor : RequestDescriptorBase<GetScriptLanguagesDescriptor, GetScriptLanguagesRequestParameters, IGetScriptLanguagesRequest>, IGetScriptLanguagesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScriptLanguages;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_script_language</summary>
        public GetScriptLanguagesDescriptor() : base()
		{
		}
	}

	public partial class GetSourceDescriptor : RequestDescriptorBase<GetSourceDescriptor, GetSourceRequestParameters, IGetSourceRequest>, IGetSourceRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetSource;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_source/{id}</summary>
        public GetSourceDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class IndexDescriptor<TDocument> : RequestDescriptorBase<IndexDescriptor<TDocument>, IndexRequestParameters, IIndexRequest<TDocument>>, IIndexRequest<TDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceIndex;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public IndexDescriptor(Nest.IndexName index, Nest.Id? id) : base(r => r.Required("index", index).Optional("id", id))
		{
		}

		///<summary>/{index}/_doc</summary>
        public IndexDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class InfoDescriptor : RequestDescriptorBase<InfoDescriptor, InfoRequestParameters, IInfoRequest>, IInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/</summary>
        public InfoDescriptor() : base()
		{
		}
	}

	public partial class MgetDescriptor : RequestDescriptorBase<MgetDescriptor, MgetRequestParameters, IMgetRequest>, IMgetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMget;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_mget</summary>
        public MgetDescriptor() : base()
		{
		}

		///<summary>/{index}/_mget</summary>
        public MgetDescriptor(Nest.IndexName? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class MsearchDescriptor : RequestDescriptorBase<MsearchDescriptor, MsearchRequestParameters, IMsearchRequest>, IMsearchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMsearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_msearch</summary>
        public MsearchDescriptor() : base()
		{
		}

		///<summary>/{index}/_msearch</summary>
        public MsearchDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class MsearchTemplateDescriptor : RequestDescriptorBase<MsearchTemplateDescriptor, MsearchTemplateRequestParameters, IMsearchTemplateRequest>, IMsearchTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMsearchTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_msearch/template</summary>
        public MsearchTemplateDescriptor() : base()
		{
		}

		///<summary>/{index}/_msearch/template</summary>
        public MsearchTemplateDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class MtermvectorsDescriptor : RequestDescriptorBase<MtermvectorsDescriptor, MtermvectorsRequestParameters, IMtermvectorsRequest>, IMtermvectorsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceMtermvectors;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_mtermvectors</summary>
        public MtermvectorsDescriptor() : base()
		{
		}

		///<summary>/{index}/_mtermvectors</summary>
        public MtermvectorsDescriptor(Nest.IndexName? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class OpenPointInTimeDescriptor : RequestDescriptorBase<OpenPointInTimeDescriptor, OpenPointInTimeRequestParameters, IOpenPointInTimeRequest>, IOpenPointInTimeRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceOpenPointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_pit</summary>
        public OpenPointInTimeDescriptor() : base()
		{
		}

		///<summary>/{index}/_pit</summary>
        public OpenPointInTimeDescriptor(Nest.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class PingDescriptor : RequestDescriptorBase<PingDescriptor, PingRequestParameters, IPingRequest>, IPingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/</summary>
        public PingDescriptor() : base()
		{
		}
	}

	public partial class PutScriptDescriptor : RequestDescriptorBase<PutScriptDescriptor, PutScriptRequestParameters, IPutScriptRequest>, IPutScriptRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePutScript;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_scripts/{id}</summary>
        public PutScriptDescriptor(Nest.Id id) : base(r => r.Required("id", id))
		{
		}

		///<summary>/_scripts/{id}/{context}</summary>
        public PutScriptDescriptor(Nest.Id id, Nest.Name? context) : base(r => r.Required("id", id).Optional("context", context))
		{
		}
	}

	public partial class RankEvalDescriptor : RequestDescriptorBase<RankEvalDescriptor, RankEvalRequestParameters, IRankEvalRequest>, IRankEvalRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceRankEval;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_rank_eval</summary>
        public RankEvalDescriptor() : base()
		{
		}

		///<summary>/{index}/_rank_eval</summary>
        public RankEvalDescriptor(Nest.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class ReindexDescriptor : RequestDescriptorBase<ReindexDescriptor, ReindexRequestParameters, IReindexRequest>, IReindexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceReindex;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_reindex</summary>
        public ReindexDescriptor() : base()
		{
		}
	}

	public partial class ReindexRethrottleDescriptor : RequestDescriptorBase<ReindexRethrottleDescriptor, ReindexRethrottleRequestParameters, IReindexRethrottleRequest>, IReindexRethrottleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceReindexRethrottle;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_reindex/{task_id}/_rethrottle</summary>
        public ReindexRethrottleDescriptor(Nest.Id task_id) : base(r => r.Required("task_id", task_id))
		{
		}
	}

	public partial class RenderSearchTemplateDescriptor : RequestDescriptorBase<RenderSearchTemplateDescriptor, RenderSearchTemplateRequestParameters, IRenderSearchTemplateRequest>, IRenderSearchTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceRenderSearchTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_render/template</summary>
        public RenderSearchTemplateDescriptor() : base()
		{
		}
	}

	public partial class ScriptsPainlessExecuteDescriptor : RequestDescriptorBase<ScriptsPainlessExecuteDescriptor, ScriptsPainlessExecuteRequestParameters, IScriptsPainlessExecuteRequest>, IScriptsPainlessExecuteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceScriptsPainlessExecute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_scripts/painless/_execute</summary>
        public ScriptsPainlessExecuteDescriptor() : base()
		{
		}
	}

	public partial class ScrollDescriptor : RequestDescriptorBase<ScrollDescriptor, ScrollRequestParameters, IScrollRequest>, IScrollRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceScroll;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search/scroll</summary>
        public ScrollDescriptor() : base()
		{
		}
	}

	public partial class SearchDescriptor : RequestDescriptorBase<SearchDescriptor, SearchRequestParameters, ISearchRequest>, ISearchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search</summary>
        public SearchDescriptor() : base()
		{
		}

		///<summary>/{index}/_search</summary>
        public SearchDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class SearchShardsDescriptor : RequestDescriptorBase<SearchShardsDescriptor, SearchShardsRequestParameters, ISearchShardsRequest>, ISearchShardsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearchShards;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search_shards</summary>
        public SearchShardsDescriptor() : base()
		{
		}

		///<summary>/{index}/_search_shards</summary>
        public SearchShardsDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class SearchTemplateDescriptor : RequestDescriptorBase<SearchTemplateDescriptor, SearchTemplateRequestParameters, ISearchTemplateRequest>, ISearchTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearchTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search/template</summary>
        public SearchTemplateDescriptor() : base()
		{
		}

		///<summary>/{index}/_search/template</summary>
        public SearchTemplateDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class TermsEnumDescriptor : RequestDescriptorBase<TermsEnumDescriptor, TermsEnumRequestParameters, ITermsEnumRequest>, ITermsEnumRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceTermsEnum;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_terms_enum</summary>
        public TermsEnumDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class TermvectorsDescriptor<TDocument> : RequestDescriptorBase<TermvectorsDescriptor<TDocument>, TermvectorsRequestParameters, ITermvectorsRequest<TDocument>>, ITermvectorsRequest<TDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceTermvectors;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_termvectors/{id}</summary>
        public TermvectorsDescriptor(Nest.IndexName index, Nest.Id? id) : base(r => r.Required("index", index).Optional("id", id))
		{
		}

		///<summary>/{index}/_termvectors</summary>
        public TermvectorsDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class UpdateDescriptor<TDocument, TPartialDocument> : RequestDescriptorBase<UpdateDescriptor<TDocument, TPartialDocument>, UpdateRequestParameters, IUpdateRequest<TDocument,TPartialDocument>>, IUpdateRequest<TDocument,TPartialDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceUpdate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_update/{id}</summary>
        public UpdateDescriptor(Nest.IndexName index, Nest.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class UpdateByQueryDescriptor : RequestDescriptorBase<UpdateByQueryDescriptor, UpdateByQueryRequestParameters, IUpdateByQueryRequest>, IUpdateByQueryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceUpdateByQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_update_by_query</summary>
        public UpdateByQueryDescriptor(Nest.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class UpdateByQueryRethrottleDescriptor : RequestDescriptorBase<UpdateByQueryRethrottleDescriptor, UpdateByQueryRethrottleRequestParameters, IUpdateByQueryRethrottleRequest>, IUpdateByQueryRethrottleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceUpdateByQueryRethrottle;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_update_by_query/{task_id}/_rethrottle</summary>
        public UpdateByQueryRethrottleDescriptor(Nest.Id task_id) : base(r => r.Required("task_id", task_id))
		{
		}
	}
}