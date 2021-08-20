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

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest.Global.Search
{
	public enum BoundaryScanner
	{
		[EnumMember(Value = "word")]
		Word,
		[EnumMember(Value = "sentence")]
		Sentence,
		[EnumMember(Value = "chars")]
		Chars
	}

	public enum HighlighterEncoder
	{
		[EnumMember(Value = "html")]
		Html,
		[EnumMember(Value = "default")]
		Default
	}

	public enum HighlighterFragmenter
	{
		[EnumMember(Value = "span")]
		Span,
		[EnumMember(Value = "simple")]
		Simple
	}

	public enum HighlighterOrder
	{
		[EnumMember(Value = "score")]
		Score
	}

	public enum HighlighterTagsSchema
	{
		[EnumMember(Value = "styled")]
		Styled
	}

	public enum HighlighterType
	{
		[EnumMember(Value = "unified")]
		Unified,
		[EnumMember(Value = "plain")]
		Plain,
		[EnumMember(Value = "fvh")]
		Fvh
	}

	public enum ScoreMode
	{
		[EnumMember(Value = "total")]
		Total,
		[EnumMember(Value = "multiply")]
		Multiply,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum SortMode
	{
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "median")]
		Median,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}

	public enum SortOrder
	{
		[EnumMember(Value = "desc")]
		Desc,
		[EnumMember(Value = "asc")]
		Asc,
		[EnumMember(Value = "_doc")]
		Document
	}

	public enum StringDistance
	{
		[EnumMember(Value = "ngram")]
		Ngram,
		[EnumMember(Value = "levenshtein")]
		Levenshtein,
		[EnumMember(Value = "jaro_winkler")]
		JaroWinkler,
		[EnumMember(Value = "internal")]
		Internal,
		[EnumMember(Value = "damerau_levenshtein")]
		DamerauLevenshtein
	}

	public enum SuggestSort
	{
		[EnumMember(Value = "score")]
		Score,
		[EnumMember(Value = "frequency")]
		Frequency
	}

	public enum TotalHitsRelation
	{
		[EnumMember(Value = "gte")]
		Gte,
		[EnumMember(Value = "eq")]
		Eq
	}
}