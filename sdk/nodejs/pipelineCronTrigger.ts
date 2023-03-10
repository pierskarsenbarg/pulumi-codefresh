// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # Pipeline Cron Trigger resource
 *
 * Pipeline Cron Trigger is used to create cron-based triggers for pipeilnes.
 * See the [documentation](https://codefresh.io/docs/docs/configure-ci-cd-pipeline/triggers/cron-triggers/).
 */
export class PipelineCronTrigger extends pulumi.CustomResource {
    /**
     * Get an existing PipelineCronTrigger resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PipelineCronTriggerState, opts?: pulumi.CustomResourceOptions): PipelineCronTrigger {
        return new PipelineCronTrigger(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'codefresh:index/pipelineCronTrigger:PipelineCronTrigger';

    /**
     * Returns true if the given object is an instance of PipelineCronTrigger.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PipelineCronTrigger {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PipelineCronTrigger.__pulumiType;
    }

    /**
     * The cron expression. Visit [this page](https://github.com/codefresh-io/cronus/blob/master/docs/expression.md) to learn about the supported cron expression format and aliases.
     */
    public readonly expression!: pulumi.Output<string>;
    /**
     * The message which will be passed to the pipeline upon each trigger.
     */
    public readonly message!: pulumi.Output<string>;
    /**
     * The pipeline to which this trigger belongs.
     */
    public readonly pipelineId!: pulumi.Output<string>;

    /**
     * Create a PipelineCronTrigger resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PipelineCronTriggerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PipelineCronTriggerArgs | PipelineCronTriggerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as PipelineCronTriggerState | undefined;
            resourceInputs["expression"] = state ? state.expression : undefined;
            resourceInputs["message"] = state ? state.message : undefined;
            resourceInputs["pipelineId"] = state ? state.pipelineId : undefined;
        } else {
            const args = argsOrState as PipelineCronTriggerArgs | undefined;
            if ((!args || args.expression === undefined) && !opts.urn) {
                throw new Error("Missing required property 'expression'");
            }
            if ((!args || args.message === undefined) && !opts.urn) {
                throw new Error("Missing required property 'message'");
            }
            if ((!args || args.pipelineId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pipelineId'");
            }
            resourceInputs["expression"] = args ? args.expression : undefined;
            resourceInputs["message"] = args ? args.message : undefined;
            resourceInputs["pipelineId"] = args ? args.pipelineId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PipelineCronTrigger.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PipelineCronTrigger resources.
 */
export interface PipelineCronTriggerState {
    /**
     * The cron expression. Visit [this page](https://github.com/codefresh-io/cronus/blob/master/docs/expression.md) to learn about the supported cron expression format and aliases.
     */
    expression?: pulumi.Input<string>;
    /**
     * The message which will be passed to the pipeline upon each trigger.
     */
    message?: pulumi.Input<string>;
    /**
     * The pipeline to which this trigger belongs.
     */
    pipelineId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PipelineCronTrigger resource.
 */
export interface PipelineCronTriggerArgs {
    /**
     * The cron expression. Visit [this page](https://github.com/codefresh-io/cronus/blob/master/docs/expression.md) to learn about the supported cron expression format and aliases.
     */
    expression: pulumi.Input<string>;
    /**
     * The message which will be passed to the pipeline upon each trigger.
     */
    message: pulumi.Input<string>;
    /**
     * The pipeline to which this trigger belongs.
     */
    pipelineId: pulumi.Input<string>;
}
