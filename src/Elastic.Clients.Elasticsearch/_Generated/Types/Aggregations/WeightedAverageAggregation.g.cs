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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

internal sealed class WeightedAverageAggregationConverter : JsonConverter<WeightedAverageAggregation>
{
	public override WeightedAverageAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "weighted_avg")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new WeightedAverageAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("value"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Value = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("value_type"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.ValueType?>(ref reader, options);
					if (value is not null)
					{
						agg.ValueType = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("weight"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Weight = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, WeightedAverageAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("weighted_avg");
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(value.Format))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
		}

		if (value.Value is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, value.Value, options);
		}

		if (value.ValueType is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, value.ValueType, options);
		}

		if (value.Weight is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, value.Weight, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(WeightedAverageAggregationConverter))]
public sealed partial class WeightedAverageAggregation : SearchAggregation
{
	public WeightedAverageAggregation(string name) => Name = name;

	internal WeightedAverageAggregation()
	{
	}

	/// <summary>
	/// <para>A numeric response formatter.</para>
	/// </summary>
	public string? Format { get; set; }
	public IDictionary<string, object>? Meta { get; set; }
	override public string? Name { get; internal set; }

	/// <summary>
	/// <para>Configuration for the field that provides the values.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? Value { get; set; }
	public Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueType { get; set; }

	/// <summary>
	/// <para>Configuration for the field or script that provides the weights.</para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? Weight { get; set; }
}

public sealed partial class WeightedAverageAggregationDescriptor<TDocument> : SerializableDescriptor<WeightedAverageAggregationDescriptor<TDocument>>
{
	internal WeightedAverageAggregationDescriptor(Action<WeightedAverageAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public WeightedAverageAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? ValueValue { get; set; }
	private WeightedAverageValueDescriptor<TDocument> ValueDescriptor { get; set; }
	private Action<WeightedAverageValueDescriptor<TDocument>> ValueDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? WeightValue { get; set; }
	private WeightedAverageValueDescriptor<TDocument> WeightDescriptor { get; set; }
	private Action<WeightedAverageValueDescriptor<TDocument>> WeightDescriptorAction { get; set; }
	private string? FormatValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; set; }

	/// <summary>
	/// <para>Configuration for the field that provides the values.</para>
	/// </summary>
	public WeightedAverageAggregationDescriptor<TDocument> Value(Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? value)
	{
		ValueDescriptor = null;
		ValueDescriptorAction = null;
		ValueValue = value;
		return Self;
	}

	public WeightedAverageAggregationDescriptor<TDocument> Value(WeightedAverageValueDescriptor<TDocument> descriptor)
	{
		ValueValue = null;
		ValueDescriptorAction = null;
		ValueDescriptor = descriptor;
		return Self;
	}

	public WeightedAverageAggregationDescriptor<TDocument> Value(Action<WeightedAverageValueDescriptor<TDocument>> configure)
	{
		ValueValue = null;
		ValueDescriptor = null;
		ValueDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Configuration for the field or script that provides the weights.</para>
	/// </summary>
	public WeightedAverageAggregationDescriptor<TDocument> Weight(Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? weight)
	{
		WeightDescriptor = null;
		WeightDescriptorAction = null;
		WeightValue = weight;
		return Self;
	}

	public WeightedAverageAggregationDescriptor<TDocument> Weight(WeightedAverageValueDescriptor<TDocument> descriptor)
	{
		WeightValue = null;
		WeightDescriptorAction = null;
		WeightDescriptor = descriptor;
		return Self;
	}

	public WeightedAverageAggregationDescriptor<TDocument> Weight(Action<WeightedAverageValueDescriptor<TDocument>> configure)
	{
		WeightValue = null;
		WeightDescriptor = null;
		WeightDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>A numeric response formatter.</para>
	/// </summary>
	public WeightedAverageAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public WeightedAverageAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public WeightedAverageAggregationDescriptor<TDocument> ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("weighted_avg");
		writer.WriteStartObject();
		if (ValueDescriptor is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueDescriptor, options);
		}
		else if (ValueDescriptorAction is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, new WeightedAverageValueDescriptor<TDocument>(ValueDescriptorAction), options);
		}
		else if (ValueValue is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueValue, options);
		}

		if (WeightDescriptor is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, WeightDescriptor, options);
		}
		else if (WeightDescriptorAction is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, new WeightedAverageValueDescriptor<TDocument>(WeightDescriptorAction), options);
		}
		else if (WeightValue is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, WeightValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (ValueTypeValue is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, ValueTypeValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class WeightedAverageAggregationDescriptor : SerializableDescriptor<WeightedAverageAggregationDescriptor>
{
	internal WeightedAverageAggregationDescriptor(Action<WeightedAverageAggregationDescriptor> configure) => configure.Invoke(this);

	public WeightedAverageAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? ValueValue { get; set; }
	private WeightedAverageValueDescriptor ValueDescriptor { get; set; }
	private Action<WeightedAverageValueDescriptor> ValueDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? WeightValue { get; set; }
	private WeightedAverageValueDescriptor WeightDescriptor { get; set; }
	private Action<WeightedAverageValueDescriptor> WeightDescriptorAction { get; set; }
	private string? FormatValue { get; set; }
	private IDictionary<string, object>? MetaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; set; }

	/// <summary>
	/// <para>Configuration for the field that provides the values.</para>
	/// </summary>
	public WeightedAverageAggregationDescriptor Value(Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? value)
	{
		ValueDescriptor = null;
		ValueDescriptorAction = null;
		ValueValue = value;
		return Self;
	}

	public WeightedAverageAggregationDescriptor Value(WeightedAverageValueDescriptor descriptor)
	{
		ValueValue = null;
		ValueDescriptorAction = null;
		ValueDescriptor = descriptor;
		return Self;
	}

	public WeightedAverageAggregationDescriptor Value(Action<WeightedAverageValueDescriptor> configure)
	{
		ValueValue = null;
		ValueDescriptor = null;
		ValueDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Configuration for the field or script that provides the weights.</para>
	/// </summary>
	public WeightedAverageAggregationDescriptor Weight(Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? weight)
	{
		WeightDescriptor = null;
		WeightDescriptorAction = null;
		WeightValue = weight;
		return Self;
	}

	public WeightedAverageAggregationDescriptor Weight(WeightedAverageValueDescriptor descriptor)
	{
		WeightValue = null;
		WeightDescriptorAction = null;
		WeightDescriptor = descriptor;
		return Self;
	}

	public WeightedAverageAggregationDescriptor Weight(Action<WeightedAverageValueDescriptor> configure)
	{
		WeightValue = null;
		WeightDescriptor = null;
		WeightDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>A numeric response formatter.</para>
	/// </summary>
	public WeightedAverageAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public WeightedAverageAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public WeightedAverageAggregationDescriptor ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("weighted_avg");
		writer.WriteStartObject();
		if (ValueDescriptor is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueDescriptor, options);
		}
		else if (ValueDescriptorAction is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, new WeightedAverageValueDescriptor(ValueDescriptorAction), options);
		}
		else if (ValueValue is not null)
		{
			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueValue, options);
		}

		if (WeightDescriptor is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, WeightDescriptor, options);
		}
		else if (WeightDescriptorAction is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, new WeightedAverageValueDescriptor(WeightDescriptorAction), options);
		}
		else if (WeightValue is not null)
		{
			writer.WritePropertyName("weight");
			JsonSerializer.Serialize(writer, WeightValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (ValueTypeValue is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, ValueTypeValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}