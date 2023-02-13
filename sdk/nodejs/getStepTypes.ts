// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * ## # Data Source: codefresh.StepTypes
 *
 * This data source allows to retrieve the published versions of a step-types
 */
export function getStepTypes(args: GetStepTypesArgs, opts?: pulumi.InvokeOptions): Promise<GetStepTypesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("codefresh:index/getStepTypes:getStepTypes", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getStepTypes.
 */
export interface GetStepTypesArgs {
    /**
     * Name of the step-types to be retrieved
     */
    name: string;
}

/**
 * A collection of values returned by getStepTypes.
 */
export interface GetStepTypesResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    /**
     * A Set of `version` blocks as documented below.
     */
    readonly versions: outputs.GetStepTypesVersion[];
}

export function getStepTypesOutput(args: GetStepTypesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetStepTypesResult> {
    return pulumi.output(args).apply(a => getStepTypes(a, opts))
}

/**
 * A collection of arguments for invoking getStepTypes.
 */
export interface GetStepTypesOutputArgs {
    /**
     * Name of the step-types to be retrieved
     */
    name: pulumi.Input<string>;
}