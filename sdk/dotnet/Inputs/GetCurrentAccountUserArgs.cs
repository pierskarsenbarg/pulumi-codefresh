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

    public sealed class GetCurrentAccountUserInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetCurrentAccountUserInputArgs()
        {
        }
        public static new GetCurrentAccountUserInputArgs Empty => new GetCurrentAccountUserInputArgs();
    }
}