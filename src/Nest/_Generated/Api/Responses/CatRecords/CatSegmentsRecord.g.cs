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

#nullable restore
namespace Nest
{
	public class CatSegmentsRecord
	{
		[JsonInclude, JsonPropertyName("committed")]
		private string? _committed = default;
		[JsonInclude, JsonPropertyName("compound")]
		private string? _compound = default;
		[JsonInclude, JsonPropertyName("dc")]
		private string? _dc = default;
		[JsonInclude, JsonPropertyName("dd")]
		private string? _dd = default;
		[JsonInclude, JsonPropertyName("docs.count")]
		private string? _docs_count = default;
		[JsonInclude, JsonPropertyName("docs.deleted")]
		private string? _docs_deleted = default;
		[JsonInclude, JsonPropertyName("docsCount")]
		private string? _docsCount = default;
		[JsonInclude, JsonPropertyName("docsDeleted")]
		private string? _docsDeleted = default;
		[JsonInclude, JsonPropertyName("g")]
		private string? _g = default;
		[JsonInclude, JsonPropertyName("gen")]
		private string? _gen = default;
		[JsonInclude, JsonPropertyName("generation")]
		private string? _generation = default;
		[JsonInclude, JsonPropertyName("i")]
		private IndexName? _i = default;
		[JsonInclude, JsonPropertyName("ic")]
		private string? _ic = default;
		[JsonInclude, JsonPropertyName("ico")]
		private string? _ico = default;
		[JsonInclude, JsonPropertyName("idx")]
		private IndexName? _idx = default;
		[JsonInclude, JsonPropertyName("index")]
		private IndexName? _index = default;
		[JsonInclude, JsonPropertyName("is")]
		private string? _is = default;
		[JsonInclude, JsonPropertyName("isCommitted")]
		private string? _isCommitted = default;
		[JsonInclude, JsonPropertyName("isCompound")]
		private string? _isCompound = default;
		[JsonInclude, JsonPropertyName("isSearchable")]
		private string? _isSearchable = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("pr")]
		private string? _pr = default;
		[JsonInclude, JsonPropertyName("primaryOrReplica")]
		private string? _primaryOrReplica = default;
		[JsonInclude, JsonPropertyName("prirep")]
		private string? _prirep = default;
		[JsonInclude, JsonPropertyName("s")]
		private string? _s = default;
		[JsonInclude, JsonPropertyName("searchable")]
		private string? _searchable = default;
		[JsonInclude, JsonPropertyName("seg")]
		private string? _seg = default;
		[JsonInclude, JsonPropertyName("segment")]
		private string? _segment = default;
		[JsonInclude, JsonPropertyName("sh")]
		private string? _sh = default;
		[JsonInclude, JsonPropertyName("shard")]
		private string? _shard = default;
		[JsonInclude, JsonPropertyName("si")]
		private ByteSize? _si = default;
		[JsonInclude, JsonPropertyName("size")]
		private ByteSize? _size = default;
		[JsonInclude, JsonPropertyName("size.memory")]
		private ByteSize? _size_memory = default;
		[JsonInclude, JsonPropertyName("sizeMemory")]
		private ByteSize? _sizeMemory = default;
		[JsonInclude, JsonPropertyName("sm")]
		private ByteSize? _sm = default;
		[JsonInclude, JsonPropertyName("v")]
		private VersionString? _v = default;
		[JsonInclude, JsonPropertyName("version")]
		private VersionString? _version = default;
		public string? Committed => _committed ?? _ic ?? _isCommitted;
		public string? Compound => _compound ?? _ico ?? _isCompound;
		public string? DocsCount => _docs_count ?? _dc ?? _docsCount;
		public string? DocsDeleted => _docs_deleted ?? _dd ?? _docsDeleted;
		public string? Generation => _generation ?? _g ?? _gen;
		[JsonPropertyName("id")]
		public NodeId? Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public IndexName? Index => _index ?? _i ?? _idx;
		[JsonPropertyName("ip")]
		public string? Ip
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? Prirep => _prirep ?? _primaryOrReplica ?? _p ?? _pr;
		public string? Searchable => _searchable ?? _is ?? _isSearchable;
		public string? Segment => _seg ?? _segment;
		public string? Shard => _shard ?? _s ?? _sh;
		public ByteSize? Size => _si ?? _size;
		public ByteSize? SizeMemory => _size_memory ?? _sm ?? _sizeMemory;
		public VersionString? Version => _v ?? _version;
	}
}