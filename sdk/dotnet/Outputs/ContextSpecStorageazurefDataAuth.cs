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
    public sealed class ContextSpecStorageazurefDataAuth
    {
        public readonly string AccountKey;
        public readonly string AccountName;
        public readonly string Type;

        [OutputConstructor]
        private ContextSpecStorageazurefDataAuth(
            string accountKey,

            string accountName,

            string type)
        {
            AccountKey = accountKey;
            AccountName = accountName;
            Type = type;
        }
    }
}
