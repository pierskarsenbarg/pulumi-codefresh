// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Codefresh.Inputs
{

    public sealed class PipelineSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum amount of concurrent builds that may run for each branch
        /// </summary>
        [Input("branchConcurrency")]
        public Input<int>? BranchConcurrency { get; set; }

        /// <summary>
        /// The maximum amount of concurrent builds.
        /// </summary>
        [Input("concurrency")]
        public Input<int>? Concurrency { get; set; }

        [Input("contexts")]
        private InputList<string>? _contexts;

        /// <summary>
        /// A list of strings representing the contexts ([shared_configuration](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/shared-configuration/)) to be configured for the pipeline
        /// </summary>
        public InputList<string> Contexts
        {
            get => _contexts ?? (_contexts = new InputList<string>());
            set => _contexts = value;
        }

        /// <summary>
        /// A `options` block as documented below.
        /// </summary>
        [Input("options")]
        public Input<Inputs.PipelineSpecOptionsArgs>? Options { get; set; }

        /// <summary>
        /// SAAS pack (`5cd1746617313f468d669013` for Small; `5cd1746717313f468d669014` for Medium; `5cd1746817313f468d669015` for Large; `5cd1746817313f468d669017` for XL; `5cd1746817313f468d669018` for XXL)
        /// </summary>
        [Input("packId")]
        public Input<string>? PackId { get; set; }

        /// <summary>
        /// Helps to organize the order of builds execution in case of reaching the concurrency limit.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// Minimum disk space required for build filesystem ( unit Gi is required)
        /// </summary>
        [Input("requiredAvailableStorage")]
        public Input<string>? RequiredAvailableStorage { get; set; }

        [Input("runtimeEnvironments")]
        private InputList<Inputs.PipelineSpecRuntimeEnvironmentArgs>? _runtimeEnvironments;

        /// <summary>
        /// A collection of `runtime_environment` blocks as documented below.
        /// </summary>
        public InputList<Inputs.PipelineSpecRuntimeEnvironmentArgs> RuntimeEnvironments
        {
            get => _runtimeEnvironments ?? (_runtimeEnvironments = new InputList<Inputs.PipelineSpecRuntimeEnvironmentArgs>());
            set => _runtimeEnvironments = value;
        }

        [Input("specTemplates")]
        private InputList<Inputs.PipelineSpecSpecTemplateArgs>? _specTemplates;

        /// <summary>
        /// A collection of `spec_template` blocks as documented below.
        /// </summary>
        public InputList<Inputs.PipelineSpecSpecTemplateArgs> SpecTemplates
        {
            get => _specTemplates ?? (_specTemplates = new InputList<Inputs.PipelineSpecSpecTemplateArgs>());
            set => _specTemplates = value;
        }

        /// <summary>
        /// A `termination_policy` block as documented below.
        /// </summary>
        [Input("terminationPolicy")]
        public Input<Inputs.PipelineSpecTerminationPolicyArgs>? TerminationPolicy { get; set; }

        /// <summary>
        /// The maximum amount of concurrent builds that may run for each trigger.
        /// </summary>
        [Input("triggerConcurrency")]
        public Input<int>? TriggerConcurrency { get; set; }

        [Input("triggers")]
        private InputList<Inputs.PipelineSpecTriggerArgs>? _triggers;

        /// <summary>
        /// A collection of `trigger` blocks as documented below. Triggers [documentation](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/triggers/git-triggers/).
        /// </summary>
        public InputList<Inputs.PipelineSpecTriggerArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.PipelineSpecTriggerArgs>());
            set => _triggers = value;
        }

        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// Pipeline variables.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public PipelineSpecArgs()
        {
        }
        public static new PipelineSpecArgs Empty => new PipelineSpecArgs();
    }
}