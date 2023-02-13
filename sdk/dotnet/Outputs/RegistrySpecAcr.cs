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
    public sealed class RegistrySpecAcr
    {
        /// <summary>
        /// _(Required)_ String representing client id.
        /// </summary>
        public readonly string ClientId;
        /// <summary>
        /// _(Required)_ String representing client secret.
        /// </summary>
        public readonly string ClientSecret;
        /// <summary>
        /// _(Required)_ String representing your acr registry domain.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// _(Optional)_ String. See the [docs](https://codefresh.io/docs/docs/integrations/docker-registries/#using-an-optional-repository-prefix).
        /// </summary>
        public readonly string? RepositoryPrefix;

        [OutputConstructor]
        private RegistrySpecAcr(
            string clientId,

            string clientSecret,

            string domain,

            string? repositoryPrefix)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Domain = domain;
            RepositoryPrefix = repositoryPrefix;
        }
    }
}
