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
    public sealed class PipelineSpec
    {
        /// <summary>
        /// The maximum amount of concurrent builds that may run for each branch
        /// </summary>
        public readonly int? BranchConcurrency;
        /// <summary>
        /// The maximum amount of concurrent builds.
        /// </summary>
        public readonly int? Concurrency;
        /// <summary>
        /// A list of strings representing the contexts ([shared_configuration](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/shared-configuration/)) to be configured for the pipeline
        /// </summary>
        public readonly ImmutableArray<string> Contexts;
        /// <summary>
        /// A `options` block as documented below.
        /// </summary>
        public readonly Outputs.PipelineSpecOptions? Options;
        /// <summary>
        /// SAAS pack (`5cd1746617313f468d669013` for Small; `5cd1746717313f468d669014` for Medium; `5cd1746817313f468d669015` for Large; `5cd1746817313f468d669017` for XL; `5cd1746817313f468d669018` for XXL)
        /// </summary>
        public readonly string? PackId;
        /// <summary>
        /// Helps to organize the order of builds execution in case of reaching the concurrency limit.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// Minimum disk space required for build filesystem ( unit Gi is required)
        /// </summary>
        public readonly string? RequiredAvailableStorage;
        /// <summary>
        /// A collection of `runtime_environment` blocks as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.PipelineSpecRuntimeEnvironment> RuntimeEnvironments;
        /// <summary>
        /// A collection of `spec_template` blocks as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.PipelineSpecSpecTemplate> SpecTemplates;
        /// <summary>
        /// A `termination_policy` block as documented below.
        /// </summary>
        public readonly Outputs.PipelineSpecTerminationPolicy? TerminationPolicy;
        /// <summary>
        /// The maximum amount of concurrent builds that may run for each trigger.
        /// </summary>
        public readonly int? TriggerConcurrency;
        /// <summary>
        /// A collection of `trigger` blocks as documented below. Triggers [documentation](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/triggers/git-triggers/).
        /// </summary>
        public readonly ImmutableArray<Outputs.PipelineSpecTrigger> Triggers;
        /// <summary>
        /// Pipeline variables.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Variables;

        [OutputConstructor]
        private PipelineSpec(
            int? branchConcurrency,

            int? concurrency,

            ImmutableArray<string> contexts,

            Outputs.PipelineSpecOptions? options,

            string? packId,

            int? priority,

            string? requiredAvailableStorage,

            ImmutableArray<Outputs.PipelineSpecRuntimeEnvironment> runtimeEnvironments,

            ImmutableArray<Outputs.PipelineSpecSpecTemplate> specTemplates,

            Outputs.PipelineSpecTerminationPolicy? terminationPolicy,

            int? triggerConcurrency,

            ImmutableArray<Outputs.PipelineSpecTrigger> triggers,

            ImmutableDictionary<string, string>? variables)
        {
            BranchConcurrency = branchConcurrency;
            Concurrency = concurrency;
            Contexts = contexts;
            Options = options;
            PackId = packId;
            Priority = priority;
            RequiredAvailableStorage = requiredAvailableStorage;
            RuntimeEnvironments = runtimeEnvironments;
            SpecTemplates = specTemplates;
            TerminationPolicy = terminationPolicy;
            TriggerConcurrency = triggerConcurrency;
            Triggers = triggers;
            Variables = variables;
        }
    }
}
