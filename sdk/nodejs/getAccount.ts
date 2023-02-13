// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # account data module
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as codefresh from "@pierskarsenbarg/codefresh";
 * import * as codefresh from "@pulumi/codefresh";
 *
 * const acc = codefresh.getAccount({
 *     name: "acc1",
 * });
 * const user1 = new codefresh.User("user1", {
 *     email: "user1@example.com",
 *     userName: "user1",
 *     accounts: [acc.then(acc => acc.id)],
 *     activate: true,
 *     roles: [
 *         "Admin",
 *         "User",
 *     ],
 *     logins: [
 *         {
 *             idpId: data.codefresh_idps.idp_azure.id,
 *             sso: true,
 *         },
 *         {
 *             idpId: data.codefresh_idps.local.id,
 *         },
 *     ],
 *     personal: {
 *         firstName: "John",
 *         lastName: "Smith",
 *     },
 * });
 * ```
 */
export function getAccount(args?: GetAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("codefresh:index/getAccount:getAccount", {
        "_id": args._id,
        "admins": args.admins,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccount.
 */
export interface GetAccountArgs {
    _id?: string;
    admins?: string[];
    name?: string;
}

/**
 * A collection of values returned by getAccount.
 */
export interface GetAccountResult {
    readonly _id?: string;
    readonly admins?: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name?: string;
}

export function getAccountOutput(args?: GetAccountOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountResult> {
    return pulumi.output(args).apply(a => getAccount(a, opts))
}

/**
 * A collection of arguments for invoking getAccount.
 */
export interface GetAccountOutputArgs {
    _id?: pulumi.Input<string>;
    admins?: pulumi.Input<pulumi.Input<string>[]>;
    name?: pulumi.Input<string>;
}