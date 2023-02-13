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

    public sealed class RegistrySpecGarArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// _(Required)_ String representing service account json file contents
        /// </summary>
        [Input("keyfile", required: true)]
        public Input<string> Keyfile { get; set; } = null!;

        /// <summary>
        /// _(Required)_ String representing one of the Google's gar locations
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// _(Optional)_ String. See the [docs](https://codefresh.io/docs/docs/integrations/docker-registries/#using-an-optional-repository-prefix).
        /// </summary>
        [Input("repositoryPrefix")]
        public Input<string>? RepositoryPrefix { get; set; }

        public RegistrySpecGarArgs()
        {
        }
        public static new RegistrySpecGarArgs Empty => new RegistrySpecGarArgs();
    }
}
