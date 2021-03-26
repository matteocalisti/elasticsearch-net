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
	public class CatFielddataRecord
	{
		[JsonInclude, JsonPropertyName("f")]
		private string? _f = default;
		[JsonInclude, JsonPropertyName("field")]
		private string? _field = default;
		[JsonInclude, JsonPropertyName("h")]
		private string? _h = default;
		[JsonInclude, JsonPropertyName("host")]
		private string? _host = default;
		[JsonInclude, JsonPropertyName("n")]
		private string? _n = default;
		[JsonInclude, JsonPropertyName("node")]
		private string? _node = default;
		public string? Field => _f ?? _field;
		public string? Host => _h ?? _host;
		[JsonPropertyName("id")]
		public string? Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

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

		public string? Node => _n ?? _node;
		[JsonPropertyName("size")]
		public string? Size
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}
}