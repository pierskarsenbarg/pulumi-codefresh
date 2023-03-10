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
    /// ## # User resource
    /// 
    /// Use this resource to create a new user.
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
    ///         Limits = new[]
    ///         {
    ///             new Codefresh.Inputs.AccountLimitArgs
    ///             {
    ///                 Collaborators = 25,
    ///                 DataRetentionWeeks = 5,
    ///             },
    ///         },
    ///         Builds = new[]
    ///         {
    ///             new Codefresh.Inputs.AccountBuildArgs
    ///             {
    ///                 Parallel = 2,
    ///             },
    ///         },
    ///     });
    /// 
    ///     var @new = new Codefresh.User("new", new()
    ///     {
    ///         Email = "&lt;EMAIL&gt;",
    ///         UserName = "&lt;USER&gt;",
    ///         Activate = true,
    ///         Roles = new[]
    ///         {
    ///             "Admin",
    ///             "User",
    ///         },
    ///         Logins = new[]
    ///         {
    ///             new Codefresh.Inputs.UserLoginArgs
    ///             {
    ///                 IdpId = data.Codefresh_idps.Idp_azure.Id,
    ///                 Sso = true,
    ///             },
    ///             new Codefresh.Inputs.UserLoginArgs
    ///             {
    ///                 IdpId = data.Codefresh_idps.Local.Id,
    ///             },
    ///         },
    ///         Personal = new Codefresh.Inputs.UserPersonalArgs
    ///         {
    ///             FirstName = "John",
    ///             LastName = "Smith",
    ///         },
    ///         Accounts = new[]
    ///         {
    ///             test.Id,
    ///             "59009117c102763beda7ce71",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import codefresh:index/user:User new xxxxxxxxxxxxxxxxxxx
    /// ```
    /// </summary>
    [CodefreshResourceType("codefresh:index/user:User")]
    public partial class User : global::Pulumi.CustomResource
    {
        /// <summary>
        /// A list of user roles. Possible values - `Admin`, `User`.
        /// </summary>
        [Output("accounts")]
        public Output<ImmutableArray<string>> Accounts { get; private set; } = null!;

        /// <summary>
        /// Boolean. Activate the new use or not. If a new user is not activate, it'll be left pending.
        /// </summary>
        [Output("activate")]
        public Output<bool?> Activate { get; private set; } = null!;

        /// <summary>
        /// A new user email.
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;

        /// <summary>
        /// A collection of `login` blocks as documented below.
        /// </summary>
        [Output("logins")]
        public Output<ImmutableArray<Outputs.UserLogin>> Logins { get; private set; } = null!;

        /// <summary>
        /// A collection of `personal` blocks as documented below.
        /// </summary>
        [Output("personal")]
        public Output<Outputs.UserPersonal?> Personal { get; private set; } = null!;

        [Output("roles")]
        public Output<ImmutableArray<string>> Roles { get; private set; } = null!;

        [Output("shortProfiles")]
        public Output<ImmutableArray<Outputs.UserShortProfile>> ShortProfiles { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The new user name.
        /// </summary>
        [Output("userName")]
        public Output<string> UserName { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs args, CustomResourceOptions? options = null)
            : base("codefresh:index/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("codefresh:index/user:User", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : global::Pulumi.ResourceArgs
    {
        [Input("accounts", required: true)]
        private InputList<string>? _accounts;

        /// <summary>
        /// A list of user roles. Possible values - `Admin`, `User`.
        /// </summary>
        public InputList<string> Accounts
        {
            get => _accounts ?? (_accounts = new InputList<string>());
            set => _accounts = value;
        }

        /// <summary>
        /// Boolean. Activate the new use or not. If a new user is not activate, it'll be left pending.
        /// </summary>
        [Input("activate")]
        public Input<bool>? Activate { get; set; }

        /// <summary>
        /// A new user email.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        [Input("logins")]
        private InputList<Inputs.UserLoginArgs>? _logins;

        /// <summary>
        /// A collection of `login` blocks as documented below.
        /// </summary>
        public InputList<Inputs.UserLoginArgs> Logins
        {
            get => _logins ?? (_logins = new InputList<Inputs.UserLoginArgs>());
            set => _logins = value;
        }

        /// <summary>
        /// A collection of `personal` blocks as documented below.
        /// </summary>
        [Input("personal")]
        public Input<Inputs.UserPersonalArgs>? Personal { get; set; }

        [Input("roles")]
        private InputList<string>? _roles;
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// The new user name.
        /// </summary>
        [Input("userName", required: true)]
        public Input<string> UserName { get; set; } = null!;

        public UserArgs()
        {
        }
        public static new UserArgs Empty => new UserArgs();
    }

    public sealed class UserState : global::Pulumi.ResourceArgs
    {
        [Input("accounts")]
        private InputList<string>? _accounts;

        /// <summary>
        /// A list of user roles. Possible values - `Admin`, `User`.
        /// </summary>
        public InputList<string> Accounts
        {
            get => _accounts ?? (_accounts = new InputList<string>());
            set => _accounts = value;
        }

        /// <summary>
        /// Boolean. Activate the new use or not. If a new user is not activate, it'll be left pending.
        /// </summary>
        [Input("activate")]
        public Input<bool>? Activate { get; set; }

        /// <summary>
        /// A new user email.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        [Input("logins")]
        private InputList<Inputs.UserLoginGetArgs>? _logins;

        /// <summary>
        /// A collection of `login` blocks as documented below.
        /// </summary>
        public InputList<Inputs.UserLoginGetArgs> Logins
        {
            get => _logins ?? (_logins = new InputList<Inputs.UserLoginGetArgs>());
            set => _logins = value;
        }

        /// <summary>
        /// A collection of `personal` blocks as documented below.
        /// </summary>
        [Input("personal")]
        public Input<Inputs.UserPersonalGetArgs>? Personal { get; set; }

        [Input("roles")]
        private InputList<string>? _roles;
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        [Input("shortProfiles")]
        private InputList<Inputs.UserShortProfileGetArgs>? _shortProfiles;
        public InputList<Inputs.UserShortProfileGetArgs> ShortProfiles
        {
            get => _shortProfiles ?? (_shortProfiles = new InputList<Inputs.UserShortProfileGetArgs>());
            set => _shortProfiles = value;
        }

        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The new user name.
        /// </summary>
        [Input("userName")]
        public Input<string>? UserName { get; set; }

        public UserState()
        {
        }
        public static new UserState Empty => new UserState();
    }
}
