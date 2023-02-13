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
    public sealed class RegistrySpecEcr
    {
        /// <summary>
        /// _(Required)_ String representing access key id
        /// </summary>
        public readonly string AccessKeyId;
        /// <summary>
        /// _(Required)_ String representing one of the Amazon regions
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// _(Optional)_ String. See the [docs](https://codefresh.io/docs/docs/integrations/docker-registries/#using-an-optional-repository-prefix).
        /// </summary>
        public readonly string? RepositoryPrefix;
        /// <summary>
        /// _(Required)_ String representing secret access key
        /// </summary>
        public readonly string SecretAccessKey;

        [OutputConstructor]
        private RegistrySpecEcr(
            string accessKeyId,

            string region,

            string? repositoryPrefix,

            string secretAccessKey)
        {
            AccessKeyId = accessKeyId;
            Region = region;
            RepositoryPrefix = repositoryPrefix;
            SecretAccessKey = secretAccessKey;
        }
    }
}
