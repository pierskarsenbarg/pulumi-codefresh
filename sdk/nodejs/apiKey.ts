// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as codefresh from "@pierskarsenbarg/codefresh";
 * import * as random from "@pulumi/random";
 *
 * const test = new codefresh.Account("test", {});
 * const random = new random.RandomString("random", {
 *     length: 16,
 *     special: false,
 * });
 * const _new = new codefresh.ApiKey("new", {
 *     accountId: test.id,
 *     userId: data.codefresh_account.test_account_user.user_id,
 *     scopes: [
 *         "agent",
 *         "agents",
 *         "audit",
 *         "build",
 *         "cluster",
 *         "clusters",
 *         "environments-v2",
 *         "github-action",
 *         "helm",
 *         "kubernetes",
 *         "pipeline",
 *         "project",
 *         "repos",
 *         "runner-installation",
 *         "step-type",
 *         "step-types",
 *         "view",
 *         "workflow",
 *     ],
 * });
 * const newAccount = new codefresh.Provider("newAccount", {
 *     apiUrl: "my API URL",
 *     token: _new.token,
 * });
 * const team1 = new codefresh.Team("team1", {}, {
 *     provider: codefresh.new_account,
 * });
 * ```
 */
export class ApiKey extends pulumi.CustomResource {
    /**
     * Get an existing ApiKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApiKeyState, opts?: pulumi.CustomResourceOptions): ApiKey {
        return new ApiKey(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'codefresh:index/apiKey:ApiKey';

    /**
     * Returns true if the given object is an instance of ApiKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApiKey {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApiKey.__pulumiType;
    }

    /**
     * The ID of account in which the API key will be created.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * The display name for the API key.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A list of access scopes, that can be targeted. The possible values:
     * - `agent`
     * - `agents`
     * - `audit`
     * - `build`
     * - `cluster`
     * - `clusters`
     * - `environments-v2`
     * - `github-action`
     * - `helm`
     * - `kubernetes`
     * - `pipeline`
     * - `project`
     * - `repos`
     * - `runner-installation`
     * - `step-type`
     * - `step-types`
     * - `view`
     * - `workflow`
     */
    public readonly scopes!: pulumi.Output<string[] | undefined>;
    /**
     * The Token, that should used as a new provider's token attribute.
     */
    public /*out*/ readonly token!: pulumi.Output<string>;
    /**
     * The ID of a user within the referenced `accountId` that will own the API key.
     */
    public readonly userId!: pulumi.Output<string>;

    /**
     * Create a ApiKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiKeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApiKeyArgs | ApiKeyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApiKeyState | undefined;
            resourceInputs["accountId"] = state ? state.accountId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["scopes"] = state ? state.scopes : undefined;
            resourceInputs["token"] = state ? state.token : undefined;
            resourceInputs["userId"] = state ? state.userId : undefined;
        } else {
            const args = argsOrState as ApiKeyArgs | undefined;
            if ((!args || args.accountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accountId'");
            }
            if ((!args || args.userId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userId'");
            }
            resourceInputs["accountId"] = args ? args.accountId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["scopes"] = args ? args.scopes : undefined;
            resourceInputs["userId"] = args ? args.userId : undefined;
            resourceInputs["token"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApiKey.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApiKey resources.
 */
export interface ApiKeyState {
    /**
     * The ID of account in which the API key will be created.
     */
    accountId?: pulumi.Input<string>;
    /**
     * The display name for the API key.
     */
    name?: pulumi.Input<string>;
    /**
     * A list of access scopes, that can be targeted. The possible values:
     * - `agent`
     * - `agents`
     * - `audit`
     * - `build`
     * - `cluster`
     * - `clusters`
     * - `environments-v2`
     * - `github-action`
     * - `helm`
     * - `kubernetes`
     * - `pipeline`
     * - `project`
     * - `repos`
     * - `runner-installation`
     * - `step-type`
     * - `step-types`
     * - `view`
     * - `workflow`
     */
    scopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Token, that should used as a new provider's token attribute.
     */
    token?: pulumi.Input<string>;
    /**
     * The ID of a user within the referenced `accountId` that will own the API key.
     */
    userId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ApiKey resource.
 */
export interface ApiKeyArgs {
    /**
     * The ID of account in which the API key will be created.
     */
    accountId: pulumi.Input<string>;
    /**
     * The display name for the API key.
     */
    name?: pulumi.Input<string>;
    /**
     * A list of access scopes, that can be targeted. The possible values:
     * - `agent`
     * - `agents`
     * - `audit`
     * - `build`
     * - `cluster`
     * - `clusters`
     * - `environments-v2`
     * - `github-action`
     * - `helm`
     * - `kubernetes`
     * - `pipeline`
     * - `project`
     * - `repos`
     * - `runner-installation`
     * - `step-type`
     * - `step-types`
     * - `view`
     * - `workflow`
     */
    scopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of a user within the referenced `accountId` that will own the API key.
     */
    userId: pulumi.Input<string>;
}