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

    public sealed class ContextSpecSecretyamlGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// String representing a YAML file content
        /// </summary>
        [Input("data", required: true)]
        public Input<string> Data { get; set; } = null!;

        public ContextSpecSecretyamlGetArgs()
        {
        }
        public static new ContextSpecSecretyamlGetArgs Empty => new ContextSpecSecretyamlGetArgs();
    }
}
