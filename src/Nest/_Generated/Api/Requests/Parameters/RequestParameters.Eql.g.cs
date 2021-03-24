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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public class EqlDeleteRequestParameters : RequestParameters<EqlDeleteRequestParameters>
    {
        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }
    }

    public class EqlGetRequestParameters : RequestParameters<EqlGetRequestParameters>
    {
        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }
    }

    public class EqlGetStatusRequestParameters : RequestParameters<EqlGetStatusRequestParameters>
    {
        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }
    }

    public class EqlSearchRequestParameters : RequestParameters<EqlSearchRequestParameters>
    {
        public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }
    }
}