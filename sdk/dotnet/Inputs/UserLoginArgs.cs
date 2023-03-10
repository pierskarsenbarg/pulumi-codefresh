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

    public sealed class UserLoginArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of IDP to the user to.
        /// </summary>
        [Input("idpId")]
        public Input<string>? IdpId { get; set; }

        [Input("sso")]
        public Input<bool>? Sso { get; set; }

        public UserLoginArgs()
        {
        }
        public static new UserLoginArgs Empty => new UserLoginArgs();
    }
}
