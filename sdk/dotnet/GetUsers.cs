// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Codefresh
{
    public static class GetUsers
    {
        /// <summary>
        /// ## `# Users Data Source
        /// 
        /// Use this data source to get all existing users from Codefresh.
        /// </summary>
        public static Task<GetUsersResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUsersResult>("codefresh:index/getUsers:getUsers", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetUsersResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A list of user
        /// </summary>
        public readonly ImmutableArray<Outputs.GetUsersUserResult> Users;

        [OutputConstructor]
        private GetUsersResult(
            string id,

            ImmutableArray<Outputs.GetUsersUserResult> users)
        {
            Id = id;
            Users = users;
        }
    }
}
