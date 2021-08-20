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
using OneOf;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	public partial class ByteSize
	{
	}

	public partial class EpochMillis
	{
	}

	public partial class ExpandWildcards
	{
	}

	public partial class Fields : IUrlParameter
	{
		public string GetString(ITransportConfiguration settings) =>  string . Empty ;
	}

	public partial class Fuzziness
	{
	}

	public partial class Ids : IUrlParameter
	{
		public string GetString(ITransportConfiguration settings) =>  string . Empty ;
	}

	public partial class Indices : IUrlParameter
	{
		public string GetString(ITransportConfiguration settings) =>  string . Empty ;
	}

	public partial class Metrics : IUrlParameter
	{
		public string GetString(ITransportConfiguration settings) =>  string . Empty ;
	}

	public partial class MinimumShouldMatch
	{
	}

	public partial class Names : IUrlParameter
	{
		public string GetString(ITransportConfiguration settings) =>  string . Empty ;
	}

	public partial class Percentage
	{
	}

	public partial class Refresh
	{
	}

	public partial class Script
	{
	}

	public partial class TaskId : IUrlParameter
	{
		public string GetString(ITransportConfiguration settings) =>  string . Empty ;
	}

	public partial class Time
	{
	}

	public partial class WaitForActiveShards
	{
	}
}