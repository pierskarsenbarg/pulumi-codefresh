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
    /// ## # Project Resource
    /// 
    /// The top-level concept in Codefresh. You can create projects to group pipelines that are related. In most cases a single project will be a single application (that itself contains many micro-services). You are free to use projects as you see fit. For example, you could create a project for a specific Kubernetes cluster or a specific team/department.
    /// More about pipeline concepts see in the [official documentation](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/pipelines/#pipeline-concepts).
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
    ///     var test = new Codefresh.Project("test", new()
    ///     {
    ///         Tags = new[]
    ///         {
    ///             "production",
    ///             "docker",
    ///         },
    ///         Variables = 
    ///         {
    ///             { "go_version", "1.13" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import codefresh:index/project:Project test xxxxxxxxxxxxxxxxxxx
    /// ```
    /// </summary>
    [CodefreshResourceType("codefresh:index/project:Project")]
    public partial class Project : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The display name for the project.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of tags to mark a project for easy management and access control.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// project variables.
        /// </summary>
        [Output("variables")]
        public Output<ImmutableDictionary<string, string>?> Variables { get; private set; } = null!;


        /// <summary>
        /// Create a Project resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Project(string name, ProjectArgs? args = null, CustomResourceOptions? options = null)
            : base("codefresh:index/project:Project", name, args ?? new ProjectArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Project(string name, Input<string> id, ProjectState? state = null, CustomResourceOptions? options = null)
            : base("codefresh:index/project:Project", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Project resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Project Get(string name, Input<string> id, ProjectState? state = null, CustomResourceOptions? options = null)
        {
            return new Project(name, id, state, options);
        }
    }

    public sealed class ProjectArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display name for the project.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to mark a project for easy management and access control.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// project variables.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public ProjectArgs()
        {
        }
        public static new ProjectArgs Empty => new ProjectArgs();
    }

    public sealed class ProjectState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display name for the project.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to mark a project for easy management and access control.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// project variables.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public ProjectState()
        {
        }
        public static new ProjectState Empty => new ProjectState();
    }
}
