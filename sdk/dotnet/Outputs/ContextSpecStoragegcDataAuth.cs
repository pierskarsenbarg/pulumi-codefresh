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
    public sealed class ContextSpecStoragegcDataAuth
    {
        public readonly ImmutableDictionary<string, object> JsonConfig;
        public readonly string Type;

        [OutputConstructor]
        private ContextSpecStoragegcDataAuth(
            ImmutableDictionary<string, object> jsonConfig,

            string type)
        {
            JsonConfig = jsonConfig;
            Type = type;
        }
    }
}
