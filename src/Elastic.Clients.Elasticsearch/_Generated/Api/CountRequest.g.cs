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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

public sealed class CountRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.</para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Analyzer to use for the query string.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

	/// <summary>
	/// <para>If `true`, wildcard and prefix queries are analyzed.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

	/// <summary>
	/// <para>The default operator for query string query: `AND` or `OR`.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

	/// <summary>
	/// <para>Field to use as default where no field prefix is given in the query string.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	public string? Df { get => Q<string?>("df"); set => Q("df", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, concrete, expanded or aliased indices are ignored when frozen.</para>
	/// </summary>
	public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>If `true`, format-based query failures (such as providing text to a numeric field) in the query string will be ignored.</para>
	/// </summary>
	public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

	/// <summary>
	/// <para>Sets the minimum `_score` value that documents must have to be included in the result.</para>
	/// </summary>
	public double? MinScore { get => Q<double?>("min_score"); set => Q("min_score", value); }

	/// <summary>
	/// <para>Specifies the node or shard the operation should be performed on.<br/>Random by default.</para>
	/// </summary>
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Maximum number of documents to collect for each shard.<br/>If a query reaches this limit, Elasticsearch terminates the query early.<br/>Elasticsearch collects documents before sorting.</para>
	/// </summary>
	public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

	/// <summary>
	/// <para>Query in the Lucene query string syntax.</para>
	/// </summary>
	public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }
}

/// <summary>
/// <para>Returns number of documents matching a query.</para>
/// </summary>
public partial class CountRequest : PlainRequest<CountRequestParameters>
{
	public CountRequest()
	{
	}

	public CountRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceCount;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "count";

	/// <summary>
	/// <para>If `false`, the request returns an error if any wildcard expression, index alias, or `_all` value targets only missing or closed indices.<br/>This behavior applies even if the request targets other open indices.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>Analyzer to use for the query string.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	[JsonIgnore]
	public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

	/// <summary>
	/// <para>If `true`, wildcard and prefix queries are analyzed.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

	/// <summary>
	/// <para>The default operator for query string query: `AND` or `OR`.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

	/// <summary>
	/// <para>Field to use as default where no field prefix is given in the query string.<br/>This parameter can only be used when the `q` query string parameter is specified.</para>
	/// </summary>
	[JsonIgnore]
	public string? Df { get => Q<string?>("df"); set => Q("df", value); }

	/// <summary>
	/// <para>Type of index that wildcard patterns can match.<br/>If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.<br/>Supports comma-separated values, such as `open,hidden`.</para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>If `true`, concrete, expanded or aliased indices are ignored when frozen.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

	/// <summary>
	/// <para>If `false`, the request returns an error if it targets a missing or closed index.</para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>If `true`, format-based query failures (such as providing text to a numeric field) in the query string will be ignored.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

	/// <summary>
	/// <para>Sets the minimum `_score` value that documents must have to be included in the result.</para>
	/// </summary>
	[JsonIgnore]
	public double? MinScore { get => Q<double?>("min_score"); set => Q("min_score", value); }

	/// <summary>
	/// <para>Specifies the node or shard the operation should be performed on.<br/>Random by default.</para>
	/// </summary>
	[JsonIgnore]
	public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

	/// <summary>
	/// <para>Custom value used to route operations to a specific shard.</para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>Maximum number of documents to collect for each shard.<br/>If a query reaches this limit, Elasticsearch terminates the query early.<br/>Elasticsearch collects documents before sorting.</para>
	/// </summary>
	[JsonIgnore]
	public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

	/// <summary>
	/// <para>Query in the Lucene query string syntax.</para>
	/// </summary>
	[JsonIgnore]
	public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

	/// <summary>
	/// <para>Defines the search definition using the Query DSL.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query? Query { get; set; }
}

/// <summary>
/// <para>Returns number of documents matching a query.</para>
/// </summary>
public sealed partial class CountRequestDescriptor<TDocument> : RequestDescriptor<CountRequestDescriptor<TDocument>, CountRequestParameters>
{
	internal CountRequestDescriptor(Action<CountRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public CountRequestDescriptor() : this(typeof(TDocument))
	{
	}

	public CountRequestDescriptor(Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceCount;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "count";

	public CountRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public CountRequestDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard = true) => Qs("analyze_wildcard", analyzeWildcard);
	public CountRequestDescriptor<TDocument> Analyzer(string? analyzer) => Qs("analyzer", analyzer);
	public CountRequestDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
	public CountRequestDescriptor<TDocument> Df(string? df) => Qs("df", df);
	public CountRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public CountRequestDescriptor<TDocument> IgnoreThrottled(bool? ignoreThrottled = true) => Qs("ignore_throttled", ignoreThrottled);
	public CountRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public CountRequestDescriptor<TDocument> Lenient(bool? lenient = true) => Qs("lenient", lenient);
	public CountRequestDescriptor<TDocument> MinScore(double? minScore) => Qs("min_score", minScore);
	public CountRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
	public CountRequestDescriptor<TDocument> QueryLuceneSyntax(string? q) => Qs("q", q);
	public CountRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public CountRequestDescriptor<TDocument> TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);

	public CountRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private QueryDsl.QueryDescriptor<TDocument> QueryDescriptor { get; set; }
	private Action<QueryDsl.QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	/// <summary>
	/// <para>Defines the search definition using the Query DSL.</para>
	/// </summary>
	public CountRequestDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public CountRequestDescriptor<TDocument> Query(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public CountRequestDescriptor<TDocument> Query(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Returns number of documents matching a query.</para>
/// </summary>
public sealed partial class CountRequestDescriptor : RequestDescriptor<CountRequestDescriptor, CountRequestParameters>
{
	internal CountRequestDescriptor(Action<CountRequestDescriptor> configure) => configure.Invoke(this);

	public CountRequestDescriptor(Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public CountRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceCount;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "count";

	public CountRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public CountRequestDescriptor AnalyzeWildcard(bool? analyzeWildcard = true) => Qs("analyze_wildcard", analyzeWildcard);
	public CountRequestDescriptor Analyzer(string? analyzer) => Qs("analyzer", analyzer);
	public CountRequestDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
	public CountRequestDescriptor Df(string? df) => Qs("df", df);
	public CountRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public CountRequestDescriptor IgnoreThrottled(bool? ignoreThrottled = true) => Qs("ignore_throttled", ignoreThrottled);
	public CountRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public CountRequestDescriptor Lenient(bool? lenient = true) => Qs("lenient", lenient);
	public CountRequestDescriptor MinScore(double? minScore) => Qs("min_score", minScore);
	public CountRequestDescriptor Preference(string? preference) => Qs("preference", preference);
	public CountRequestDescriptor QueryLuceneSyntax(string? q) => Qs("q", q);
	public CountRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
	public CountRequestDescriptor TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);

	public CountRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query? QueryValue { get; set; }
	private QueryDsl.QueryDescriptor QueryDescriptor { get; set; }
	private Action<QueryDsl.QueryDescriptor> QueryDescriptorAction { get; set; }

	/// <summary>
	/// <para>Defines the search definition using the Query DSL.</para>
	/// </summary>
	public CountRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public CountRequestDescriptor Query(QueryDsl.QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public CountRequestDescriptor Query(Action<QueryDsl.QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		writer.WriteEndObject();
	}
}