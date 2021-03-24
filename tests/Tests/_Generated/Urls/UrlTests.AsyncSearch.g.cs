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
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.Threading.Tasks;
using Tests.Domain;
using Tests.Framework.EndpointTests;

namespace Tests.Urls.AsyncSearch
{
    public class AsyncSearchSubmitUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.POST("/_async_search").Request(c => c.AsyncSearch.Submit(new AsyncSearchSubmitRequest())).RequestAsync(c => c.AsyncSearch.SubmitAsync(new AsyncSearchSubmitRequest()));
            await UrlTester.POST("/_all/_async_search").Request(c => c.AsyncSearch.Submit(new AsyncSearchSubmitRequest(Nest.Indices.All))).RequestAsync(c => c.AsyncSearch.SubmitAsync(new AsyncSearchSubmitRequest(Nest.Indices.All)));
            await UrlTester.POST("/project/_async_search").Request(c => c.AsyncSearch.Submit(new AsyncSearchSubmitRequest(Nest.IndexName.From<Project>()))).RequestAsync(c => c.AsyncSearch.SubmitAsync(new AsyncSearchSubmitRequest(Nest.IndexName.From<Project>())));
        }
    }
}