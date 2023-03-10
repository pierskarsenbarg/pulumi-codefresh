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
    public static class GetStepTypes
    {
        /// <summary>
        /// ## # Data Source: codefresh.StepTypes
        /// 
        /// This data source allows to retrieve the published versions of a step-types
        /// </summary>
        public static Task<GetStepTypesResult> InvokeAsync(GetStepTypesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStepTypesResult>("codefresh:index/getStepTypes:getStepTypes", args ?? new GetStepTypesArgs(), options.WithDefaults());

        /// <summary>
        /// ## # Data Source: codefresh.StepTypes
        /// 
        /// This data source allows to retrieve the published versions of a step-types
        /// </summary>
        public static Output<GetStepTypesResult> Invoke(GetStepTypesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetStepTypesResult>("codefresh:index/getStepTypes:getStepTypes", args ?? new GetStepTypesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetStepTypesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the step-types to be retrieved
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetStepTypesArgs()
        {
        }
        public static new GetStepTypesArgs Empty => new GetStepTypesArgs();
    }

    public sealed class GetStepTypesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the step-types to be retrieved
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetStepTypesInvokeArgs()
        {
        }
        public static new GetStepTypesInvokeArgs Empty => new GetStepTypesInvokeArgs();
    }


    [OutputType]
    public sealed class GetStepTypesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        /// <summary>
        /// A Set of `version` blocks as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStepTypesVersionResult> Versions;

        [OutputConstructor]
        private GetStepTypesResult(
            string id,

            string name,

            ImmutableArray<Outputs.GetStepTypesVersionResult> versions)
        {
            Id = id;
            Name = name;
            Versions = versions;
        }
    }
}
