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

    public sealed class ContextSpecGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `config` block as documented below. Shared Config [spec](https://codefresh-io.github.io/cli/contexts/spec/config/).
        /// </summary>
        [Input("config")]
        public Input<Inputs.ContextSpecConfigGetArgs>? Config { get; set; }

        /// <summary>
        /// A `secret` block as documented below. Shared Secret [spec](https://codefresh-io.github.io/cli/contexts/spec/secret/).
        /// </summary>
        [Input("secret")]
        public Input<Inputs.ContextSpecSecretGetArgs>? Secret { get; set; }

        /// <summary>
        /// A `secretyaml` block as documented below. Secret Yaml Configuration Context[spec](https://codefresh-io.github.io/cli/contexts/spec/secret-yaml/).
        /// </summary>
        [Input("secretyaml")]
        public Input<Inputs.ContextSpecSecretyamlGetArgs>? Secretyaml { get; set; }

        [Input("storageazuref")]
        public Input<Inputs.ContextSpecStorageazurefGetArgs>? Storageazuref { get; set; }

        [Input("storagegc")]
        public Input<Inputs.ContextSpecStoragegcGetArgs>? Storagegc { get; set; }

        [Input("storages3")]
        public Input<Inputs.ContextSpecStorages3GetArgs>? Storages3 { get; set; }

        /// <summary>
        /// A `yaml` block as documented below. Yaml Configuration Context [spec](https://codefresh-io.github.io/cli/contexts/spec/yaml/).
        /// </summary>
        [Input("yaml")]
        public Input<Inputs.ContextSpecYamlGetArgs>? Yaml { get; set; }

        public ContextSpecGetArgs()
        {
        }
        public static new ContextSpecGetArgs Empty => new ContextSpecGetArgs();
    }
}
