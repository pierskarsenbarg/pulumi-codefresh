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
    public sealed class GetUserLoginCredentialResult
    {
        public readonly ImmutableArray<string> Permissions;

        [OutputConstructor]
        private GetUserLoginCredentialResult(ImmutableArray<string> permissions)
        {
            Permissions = permissions;
        }
    }
}