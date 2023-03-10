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

    public sealed class PipelineSpecTriggerOptionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean. If false the pipeline will not send notifications to Slack and status updates back to the Git provider. Default false
        /// </summary>
        [Input("enableNotifications")]
        public Input<bool>? EnableNotifications { get; set; }

        /// <summary>
        /// Boolean. If true, docker layer cache is disabled. Default false
        /// </summary>
        [Input("noCache")]
        public Input<bool>? NoCache { get; set; }

        /// <summary>
        /// Boolean. If true, extra Codefresh caching is disabled. Default false
        /// </summary>
        [Input("noCfCache")]
        public Input<bool>? NoCfCache { get; set; }

        /// <summary>
        /// Boolean. If true, all files on volume will be deleted before each execution. Default false
        /// </summary>
        [Input("resetVolume")]
        public Input<bool>? ResetVolume { get; set; }

        public PipelineSpecTriggerOptionGetArgs()
        {
        }
        public static new PipelineSpecTriggerOptionGetArgs Empty => new PipelineSpecTriggerOptionGetArgs();
    }
}
