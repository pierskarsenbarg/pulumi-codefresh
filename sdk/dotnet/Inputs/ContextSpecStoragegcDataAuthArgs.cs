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

    public sealed class ContextSpecStoragegcDataAuthArgs : global::Pulumi.ResourceArgs
    {
        [Input("jsonConfig", required: true)]
        private InputMap<object>? _jsonConfig;
        public InputMap<object> JsonConfig
        {
            get => _jsonConfig ?? (_jsonConfig = new InputMap<object>());
            set => _jsonConfig = value;
        }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ContextSpecStoragegcDataAuthArgs()
        {
        }
        public static new ContextSpecStoragegcDataAuthArgs Empty => new ContextSpecStoragegcDataAuthArgs();
    }
}
