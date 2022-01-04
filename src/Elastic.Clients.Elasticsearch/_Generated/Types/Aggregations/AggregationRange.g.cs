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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class AggregationRange
	{
		[JsonInclude]
		[JsonPropertyName("from")]
		public object? From { get; set; }

		[JsonInclude]
		[JsonPropertyName("key")]
		public string? Key { get; set; }

		[JsonInclude]
		[JsonPropertyName("to")]
		public object? To { get; set; }
	}

	public sealed partial class AggregationRangeDescriptor : DescriptorBase<AggregationRangeDescriptor>
	{
		public AggregationRangeDescriptor()
		{
		}

		internal AggregationRangeDescriptor(Action<AggregationRangeDescriptor> configure) => configure.Invoke(this);
		internal object? FromValue { get; private set; }

		internal string? KeyValue { get; private set; }

		internal object? ToValue { get; private set; }

		public AggregationRangeDescriptor From(object? from) => Assign(from, (a, v) => a.FromValue = v);
		public AggregationRangeDescriptor Key(string? key) => Assign(key, (a, v) => a.KeyValue = v);
		public AggregationRangeDescriptor To(object? to) => Assign(to, (a, v) => a.ToValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FromValue is not null)
			{
				writer.WritePropertyName("from");
				JsonSerializer.Serialize(writer, FromValue, options);
			}

			if (!string.IsNullOrEmpty(KeyValue))
			{
				writer.WritePropertyName("key");
				writer.WriteStringValue(KeyValue);
			}

			if (ToValue is not null)
			{
				writer.WritePropertyName("to");
				JsonSerializer.Serialize(writer, ToValue, options);
			}

			writer.WriteEndObject();
		}
	}
}