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
using System.Text.Json.Serialization;

namespace Nest
{
    public class LogstashDeletePipelineResponse : ResponseBase
    {
        [JsonPropertyName("stub")]
        public int Stub { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class LogstashGetPipelineResponse : ResponseBase
    {
        [JsonPropertyName("stub")]
        public int Stub { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class LogstashPutPipelineResponse : ResponseBase
    {
        [JsonPropertyName("stub")]
        public int Stub { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }
}