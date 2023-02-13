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
    /// <summary>
    /// ## # IDP Admins resource
    /// 
    /// The resource adds the list of provided account IDs to the IDP.\
    /// Because of the current Codefresh API limitation it's impossible to remove account from IDP, only adding is supporting.
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import codefresh:index/idpAccounts:IdpAccounts test xxxxxxxxxxxxxxxxxxx
    /// ```
    /// </summary>
    [CodefreshResourceType("codefresh:index/idpAccounts:IdpAccounts")]
    public partial class IdpAccounts : global::Pulumi.CustomResource
    {
        [Output("accountIds")]
        public Output<ImmutableArray<string>> AccountIds { get; private set; } = null!;

        [Output("idpId")]
        public Output<string> IdpId { get; private set; } = null!;


        /// <summary>
        /// Create a IdpAccounts resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IdpAccounts(string name, IdpAccountsArgs args, CustomResourceOptions? options = null)
            : base("codefresh:index/idpAccounts:IdpAccounts", name, args ?? new IdpAccountsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IdpAccounts(string name, Input<string> id, IdpAccountsState? state = null, CustomResourceOptions? options = null)
            : base("codefresh:index/idpAccounts:IdpAccounts", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IdpAccounts resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IdpAccounts Get(string name, Input<string> id, IdpAccountsState? state = null, CustomResourceOptions? options = null)
        {
            return new IdpAccounts(name, id, state, options);
        }
    }

    public sealed class IdpAccountsArgs : global::Pulumi.ResourceArgs
    {
        [Input("accountIds", required: true)]
        private InputList<string>? _accountIds;
        public InputList<string> AccountIds
        {
            get => _accountIds ?? (_accountIds = new InputList<string>());
            set => _accountIds = value;
        }

        [Input("idpId", required: true)]
        public Input<string> IdpId { get; set; } = null!;

        public IdpAccountsArgs()
        {
        }
        public static new IdpAccountsArgs Empty => new IdpAccountsArgs();
    }

    public sealed class IdpAccountsState : global::Pulumi.ResourceArgs
    {
        [Input("accountIds")]
        private InputList<string>? _accountIds;
        public InputList<string> AccountIds
        {
            get => _accountIds ?? (_accountIds = new InputList<string>());
            set => _accountIds = value;
        }

        [Input("idpId")]
        public Input<string>? IdpId { get; set; }

        public IdpAccountsState()
        {
        }
        public static new IdpAccountsState Empty => new IdpAccountsState();
    }
}
