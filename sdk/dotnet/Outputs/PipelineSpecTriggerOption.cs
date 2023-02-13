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
    public sealed class PipelineSpecTriggerOption
    {
        /// <summary>
        /// Boolean. If false the pipeline will not send notifications to Slack and status updates back to the Git provider. Default false
        /// </summary>
        public readonly bool? EnableNotifications;
        /// <summary>
        /// Boolean. If true, docker layer cache is disabled. Default false
        /// </summary>
        public readonly bool? NoCache;
        /// <summary>
        /// Boolean. If true, extra Codefresh caching is disabled. Default false
        /// </summary>
        public readonly bool? NoCfCache;
        /// <summary>
        /// Boolean. If true, all files on volume will be deleted before each execution. Default false
        /// </summary>
        public readonly bool? ResetVolume;

        [OutputConstructor]
        private PipelineSpecTriggerOption(
            bool? enableNotifications,

            bool? noCache,

            bool? noCfCache,

            bool? resetVolume)
        {
            EnableNotifications = enableNotifications;
            NoCache = noCache;
            NoCfCache = noCfCache;
            ResetVolume = resetVolume;
        }
    }
}