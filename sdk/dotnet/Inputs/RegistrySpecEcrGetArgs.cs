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

    public sealed class RegistrySpecEcrGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// _(Required)_ String representing access key id
        /// </summary>
        [Input("accessKeyId", required: true)]
        public Input<string> AccessKeyId { get; set; } = null!;

        /// <summary>
        /// _(Required)_ String representing one of the Amazon regions
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// _(Optional)_ String. See the [docs](https://codefresh.io/docs/docs/integrations/docker-registries/#using-an-optional-repository-prefix).
        /// </summary>
        [Input("repositoryPrefix")]
        public Input<string>? RepositoryPrefix { get; set; }

        /// <summary>
        /// _(Required)_ String representing secret access key
        /// </summary>
        [Input("secretAccessKey", required: true)]
        public Input<string> SecretAccessKey { get; set; } = null!;

        public RegistrySpecEcrGetArgs()
        {
        }
        public static new RegistrySpecEcrGetArgs Empty => new RegistrySpecEcrGetArgs();
    }
}
