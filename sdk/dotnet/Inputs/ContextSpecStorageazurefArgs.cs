// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Codefresh.Inputs
{

    public sealed class ContextSpecStorageazurefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Map of strings representing the variables to be defined in the Shared Config.
        /// </summary>
        [Input("data", required: true)]
        public Input<Inputs.ContextSpecStorageazurefDataArgs> Data { get; set; } = null!;

        public ContextSpecStorageazurefArgs()
        {
        }
        public static new ContextSpecStorageazurefArgs Empty => new ContextSpecStorageazurefArgs();
    }
}
