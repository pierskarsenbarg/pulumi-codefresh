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

    public sealed class ContextSpecConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("data", required: true)]
        private InputMap<string>? _data;

        /// <summary>
        /// Map of strings representing the variables to be defined in the Shared Config.
        /// </summary>
        public InputMap<string> Data
        {
            get => _data ?? (_data = new InputMap<string>());
            set => _data = value;
        }

        public ContextSpecConfigGetArgs()
        {
        }
        public static new ContextSpecConfigGetArgs Empty => new ContextSpecConfigGetArgs();
    }
}