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
    public sealed class RegistrySpecOther
    {
        /// <summary>
        /// _(Optional, Default = false)_ Bool. See the [docs](https://codefresh.io/docs/docs/administration/behind-the-firewall/#accessing-an-internal-docker-registry).
        /// </summary>
        public readonly bool? BehindFirewall;
        /// <summary>
        /// _(Required)_ String representing the bintray domain
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// _(Required)_ String representing token
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// _(Optional)_ String. See the [docs](https://codefresh.io/docs/docs/integrations/docker-registries/#using-an-optional-repository-prefix).
        /// </summary>
        public readonly string? RepositoryPrefix;
        /// <summary>
        /// _(Required)_ String representing the username
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private RegistrySpecOther(
            bool? behindFirewall,

            string domain,

            string password,

            string? repositoryPrefix,

            string username)
        {
            BehindFirewall = behindFirewall;
            Domain = domain;
            Password = password;
            RepositoryPrefix = repositoryPrefix;
            Username = username;
        }
    }
}
