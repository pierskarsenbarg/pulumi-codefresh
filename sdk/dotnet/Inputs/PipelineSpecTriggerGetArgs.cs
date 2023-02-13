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

    public sealed class PipelineSpecTriggerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A regular expression and will only trigger for branches that match this naming pattern.
        /// </summary>
        [Input("branchRegex")]
        public Input<string>? BranchRegex { get; set; }

        /// <summary>
        /// Flag to manage how the `branch_regex` field is interpreted. Possible values: "multiselect-exclude", "multiselect", "regex". Default: "regex"
        /// </summary>
        [Input("branchRegexInput")]
        public Input<string>? BranchRegexInput { get; set; }

        /// <summary>
        /// A regular expression and will only trigger for pull requests where a comment matches this naming pattern.
        /// </summary>
        [Input("commentRegex")]
        public Input<string>? CommentRegex { get; set; }

        /// <summary>
        /// The commit status title pushed to the GIT version control system.
        /// </summary>
        [Input("commitStatusTitle")]
        public Input<string>? CommitStatusTitle { get; set; }

        /// <summary>
        /// Codefresh Git context.
        /// </summary>
        [Input("context")]
        public Input<string>? Context { get; set; }

        [Input("contexts")]
        private InputList<string>? _contexts;

        /// <summary>
        /// A list of strings representing the contexts ([shared_configuration](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/shared-configuration/)) to be loaded when the trigger is executed
        /// </summary>
        public InputList<string> Contexts
        {
            get => _contexts ?? (_contexts = new InputList<string>());
            set => _contexts = value;
        }

        /// <summary>
        /// The trigger description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Boolean. If true, trigger will never be activated.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        [Input("events")]
        private InputList<string>? _events;

        /// <summary>
        /// A list of GitHub events for which a Pipeline is triggered. Default value - **push.heads**.
        /// </summary>
        public InputList<string> Events
        {
            get => _events ?? (_events = new InputList<string>());
            set => _events = value;
        }

        /// <summary>
        /// Allows to constrain the build and trigger it only if the modified files from the commit match this glob expression.
        /// </summary>
        [Input("modifiedFilesGlob")]
        public Input<string>? ModifiedFilesGlob { get; set; }

        /// <summary>
        /// The display name for the pipeline.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("options")]
        private InputList<Inputs.PipelineSpecTriggerOptionGetArgs>? _options;

        /// <summary>
        /// A `options` block as documented below.
        /// </summary>
        public InputList<Inputs.PipelineSpecTriggerOptionGetArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.PipelineSpecTriggerOptionGetArgs>());
            set => _options = value;
        }

        /// <summary>
        /// Default value - **github**.
        /// </summary>
        [Input("provider")]
        public Input<string>? Provider { get; set; }

        /// <summary>
        /// Boolean. If this trigger is also applicable to Git forks.
        /// </summary>
        [Input("pullRequestAllowForkEvents")]
        public Input<bool>? PullRequestAllowForkEvents { get; set; }

        /// <summary>
        /// A regular expression and will only trigger for pull requests to branches that match this naming pattern.
        /// </summary>
        [Input("pullRequestTargetBranchRegex")]
        public Input<string>? PullRequestTargetBranchRegex { get; set; }

        /// <summary>
        /// The GitHub `account/repo_name`.
        /// </summary>
        [Input("repo")]
        public Input<string>? Repo { get; set; }

        [Input("runtimeEnvironments")]
        private InputList<Inputs.PipelineSpecTriggerRuntimeEnvironmentGetArgs>? _runtimeEnvironments;

        /// <summary>
        /// A collection of `runtime_environment` blocks as documented below.
        /// - `options`: (Optional) A collection `option` blocks as documented below.
        /// ---
        /// </summary>
        public InputList<Inputs.PipelineSpecTriggerRuntimeEnvironmentGetArgs> RuntimeEnvironments
        {
            get => _runtimeEnvironments ?? (_runtimeEnvironments = new InputList<Inputs.PipelineSpecTriggerRuntimeEnvironmentGetArgs>());
            set => _runtimeEnvironments = value;
        }

        /// <summary>
        /// The trigger type. Default value - **git**.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// Trigger variables.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public PipelineSpecTriggerGetArgs()
        {
        }
        public static new PipelineSpecTriggerGetArgs Empty => new PipelineSpecTriggerGetArgs();
    }
}
