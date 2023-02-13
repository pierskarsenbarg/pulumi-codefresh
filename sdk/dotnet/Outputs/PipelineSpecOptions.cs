// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Codefresh.Outputs
{

    [OutputType]
    public sealed class PipelineSpecOptions
    {
        /// <summary>
        /// Boolean for the Settings under pending approval: `When build enters "Pending Approval" state, volume should`:
        /// * Default (attribute not specified): "Use Setting accounts"
        /// * true: "Remain (build remains active)"
        /// * false: "Be removed"
        /// </summary>
        public readonly bool? KeepPvcsForPendingApproval;
        /// <summary>
        /// Boolean for the Settings under pending approval: `Pipeline concurrency policy: Builds on "Pending Approval" state should be`:
        /// * Default (attribute not specified): "Use Setting accounts"
        /// * true: "Included in concurrency"
        /// * false: "Not included in concurrency"
        /// </summary>
        public readonly bool? PendingApprovalConcurrencyApplied;

        [OutputConstructor]
        private PipelineSpecOptions(
            bool? keepPvcsForPendingApproval,

            bool? pendingApprovalConcurrencyApplied)
        {
            KeepPvcsForPendingApproval = keepPvcsForPendingApproval;
            PendingApprovalConcurrencyApplied = pendingApprovalConcurrencyApplied;
        }
    }
}
