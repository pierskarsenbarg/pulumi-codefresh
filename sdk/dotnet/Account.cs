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
    /// ## # Account resource
    /// 
    /// By creating different accounts for different teams within the same company a customer can achieve complete segregation of assets between the teams.
    /// See the [documentation](https://codefresh.io/docs/docs/administration/ent-account-mng/).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Codefresh = PiersKarsenbarg.Codefresh;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var test = new Codefresh.Account("test", new()
    ///     {
    ///         Builds = new[]
    ///         {
    ///             new Codefresh.Inputs.AccountBuildArgs
    ///             {
    ///                 Parallel = 27,
    ///             },
    ///         },
    ///         Features = 
    ///         {
    ///             { "OfflineLogging", true },
    ///             { "abac", true },
    ///             { "customKubernetesCluster", true },
    ///             { "launchDarklyManagement", false },
    ///             { "ssoManagement", true },
    ///             { "teamsManagement", true },
    ///         },
    ///         Limits = new[]
    ///         {
    ///             new Codefresh.Inputs.AccountLimitArgs
    ///             {
    ///                 Collaborators = 25,
    ///                 DataRetentionWeeks = 5,
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import codefresh:index/account:Account test xxxxxxxxxxxxxxxxxxx
    /// ```
    /// </summary>
    [CodefreshResourceType("codefresh:index/account:Account")]
    public partial class Account : global::Pulumi.CustomResource
    {
        /// <summary>
        /// A collection of `build` blocks as documented below.
        /// </summary>
        [Output("builds")]
        public Output<ImmutableArray<Outputs.AccountBuild>> Builds { get; private set; } = null!;

        /// <summary>
        /// map of supported features toggles 
        /// ---
        /// </summary>
        [Output("features")]
        public Output<ImmutableDictionary<string, bool>?> Features { get; private set; } = null!;

        /// <summary>
        /// A collection of `limits` blocks as documented below.
        /// </summary>
        [Output("limits")]
        public Output<ImmutableArray<Outputs.AccountLimit>> Limits { get; private set; } = null!;

        /// <summary>
        /// The display name for the account.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a Account resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Account(string name, AccountArgs? args = null, CustomResourceOptions? options = null)
            : base("codefresh:index/account:Account", name, args ?? new AccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Account(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
            : base("codefresh:index/account:Account", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Account resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Account Get(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
        {
            return new Account(name, id, state, options);
        }
    }

    public sealed class AccountArgs : global::Pulumi.ResourceArgs
    {
        [Input("builds")]
        private InputList<Inputs.AccountBuildArgs>? _builds;

        /// <summary>
        /// A collection of `build` blocks as documented below.
        /// </summary>
        public InputList<Inputs.AccountBuildArgs> Builds
        {
            get => _builds ?? (_builds = new InputList<Inputs.AccountBuildArgs>());
            set => _builds = value;
        }

        [Input("features")]
        private InputMap<bool>? _features;

        /// <summary>
        /// map of supported features toggles 
        /// ---
        /// </summary>
        public InputMap<bool> Features
        {
            get => _features ?? (_features = new InputMap<bool>());
            set => _features = value;
        }

        [Input("limits")]
        private InputList<Inputs.AccountLimitArgs>? _limits;

        /// <summary>
        /// A collection of `limits` blocks as documented below.
        /// </summary>
        public InputList<Inputs.AccountLimitArgs> Limits
        {
            get => _limits ?? (_limits = new InputList<Inputs.AccountLimitArgs>());
            set => _limits = value;
        }

        /// <summary>
        /// The display name for the account.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public AccountArgs()
        {
        }
        public static new AccountArgs Empty => new AccountArgs();
    }

    public sealed class AccountState : global::Pulumi.ResourceArgs
    {
        [Input("builds")]
        private InputList<Inputs.AccountBuildGetArgs>? _builds;

        /// <summary>
        /// A collection of `build` blocks as documented below.
        /// </summary>
        public InputList<Inputs.AccountBuildGetArgs> Builds
        {
            get => _builds ?? (_builds = new InputList<Inputs.AccountBuildGetArgs>());
            set => _builds = value;
        }

        [Input("features")]
        private InputMap<bool>? _features;

        /// <summary>
        /// map of supported features toggles 
        /// ---
        /// </summary>
        public InputMap<bool> Features
        {
            get => _features ?? (_features = new InputMap<bool>());
            set => _features = value;
        }

        [Input("limits")]
        private InputList<Inputs.AccountLimitGetArgs>? _limits;

        /// <summary>
        /// A collection of `limits` blocks as documented below.
        /// </summary>
        public InputList<Inputs.AccountLimitGetArgs> Limits
        {
            get => _limits ?? (_limits = new InputList<Inputs.AccountLimitGetArgs>());
            set => _limits = value;
        }

        /// <summary>
        /// The display name for the account.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public AccountState()
        {
        }
        public static new AccountState Empty => new AccountState();
    }
}
