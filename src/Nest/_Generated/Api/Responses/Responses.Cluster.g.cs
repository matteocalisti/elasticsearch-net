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
    public class ClusterAllocationExplainResponse : ResponseBase
    {
        [JsonPropertyName("allocate_explanation")]
        public string AllocateExplanation { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("allocation_delay")]
        public string AllocationDelay { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("allocation_delay_in_millis")]
        public long AllocationDelayInMillis { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("can_allocate")]
        public Decision CanAllocate { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("can_move_to_other_node")]
        public Decision CanMoveToOtherNode { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("can_rebalance_cluster")]
        public Decision CanRebalanceCluster { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("can_rebalance_to_other_node")]
        public Decision CanRebalanceToOtherNode { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("can_remain_on_current_node")]
        public Decision CanRemainOnCurrentNode { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("configured_delay")]
        public string ConfiguredDelay { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("configured_delay_in_millis")]
        public long ConfiguredDelayInMillis { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("current_state")]
        public string CurrentState { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("index")]
        public string Index { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("move_explanation")]
        public string MoveExplanation { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("primary")]
        public bool Primary { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("rebalance_explanation")]
        public string RebalanceExplanation { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("remaining_delay")]
        public string RemainingDelay { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("remaining_delay_in_millis")]
        public long RemainingDelayInMillis { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("shard")]
        public int Shard { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class ClusterDeleteComponentTemplateResponse : AcknowledgedResponseBase
    {
    }

    public class ClusterDeleteVotingConfigExclusionsResponse : ResponseBase
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

    public class ClusterComponentTemplateExistsResponse : ResponseBase
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

    public class ClusterGetComponentTemplateResponse : ResponseBase
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

    public class ClusterGetSettingsResponse : ResponseBase
    {
    }

    public class ClusterHealthResponse : ResponseBase
    {
        [JsonPropertyName("active_primary_shards")]
        public int ActivePrimaryShards { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("active_shards")]
        public int ActiveShards { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("cluster_name")]
        public string ClusterName { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("delayed_unassigned_shards")]
        public int DelayedUnassignedShards { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("initializing_shards")]
        public int InitializingShards { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("number_of_data_nodes")]
        public int NumberOfDataNodes { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("number_of_in_flight_fetch")]
        public int NumberOfInFlightFetch { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("number_of_nodes")]
        public int NumberOfNodes { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("number_of_pending_tasks")]
        public int NumberOfPendingTasks { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("relocating_shards")]
        public int RelocatingShards { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("status")]
        public Health Status { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("timed_out")]
        public bool TimedOut { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("unassigned_shards")]
        public int UnassignedShards { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class ClusterPendingTasksResponse : ResponseBase
    {
    }

    public class ClusterPostVotingConfigExclusionsResponse : ResponseBase
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

    public class ClusterPutComponentTemplateResponse : ResponseBase
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

    public class ClusterPutSettingsResponse : ResponseBase
    {
    }

    public class RemoteInfoResponse : DictionaryResponseBase
    {
    }

    public class ClusterRerouteResponse : ResponseBase
    {
    }

    public class ClusterStateResponse : ResponseBase
    {
        [JsonPropertyName("cluster_name")]
        public string ClusterName { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("master_node")]
        public string MasterNode { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class ClusterStatsResponse : NodesResponseBase
    {
        [JsonPropertyName("status")]
        public ClusterStatus Status { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }
}