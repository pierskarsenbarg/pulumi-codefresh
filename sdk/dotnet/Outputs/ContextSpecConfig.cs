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
    public sealed class ContextSpecConfig
    {
        /// <summary>
        /// Map of strings representing the variables to be defined in the Shared Config.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Data;

        [OutputConstructor]
        private ContextSpecConfig(ImmutableDictionary<string, string> data)
        {
            Data = data;
        }
    }
}
