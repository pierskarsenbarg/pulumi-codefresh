// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package codefresh

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-codefresh/sdk/go/codefresh"
//	"github.com/pulumi/pulumi-random/sdk/v4/go/random"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			test, err := codefresh.NewAccount(ctx, "test", nil)
//			if err != nil {
//				return err
//			}
//			_, err = random.NewRandomString(ctx, "random", &random.RandomStringArgs{
//				Length:  pulumi.Int(16),
//				Special: pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			new, err := codefresh.NewApiKey(ctx, "new", &codefresh.ApiKeyArgs{
//				AccountId: test.ID(),
//				UserId:    pulumi.Any(data.Codefresh_account.Test_account_user.User_id),
//				Scopes: pulumi.StringArray{
//					pulumi.String("agent"),
//					pulumi.String("agents"),
//					pulumi.String("audit"),
//					pulumi.String("build"),
//					pulumi.String("cluster"),
//					pulumi.String("clusters"),
//					pulumi.String("environments-v2"),
//					pulumi.String("github-action"),
//					pulumi.String("helm"),
//					pulumi.String("kubernetes"),
//					pulumi.String("pipeline"),
//					pulumi.String("project"),
//					pulumi.String("repos"),
//					pulumi.String("runner-installation"),
//					pulumi.String("step-type"),
//					pulumi.String("step-types"),
//					pulumi.String("view"),
//					pulumi.String("workflow"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = codefresh.NewProvider(ctx, "newAccount", &codefresh.ProviderArgs{
//				ApiUrl: pulumi.String("my API URL"),
//				Token:  new.Token,
//			})
//			if err != nil {
//				return err
//			}
//			_, err = codefresh.NewTeam(ctx, "team1", nil, pulumi.Provider(codefresh.New_account))
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type ApiKey struct {
	pulumi.CustomResourceState

	// The ID of account in which the API key will be created.
	AccountId pulumi.StringOutput `pulumi:"accountId"`
	// The display name for the API key.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of access scopes, that can be targeted. The possible values:
	// - `agent`
	// - `agents`
	// - `audit`
	// - `build`
	// - `cluster`
	// - `clusters`
	// - `environments-v2`
	// - `github-action`
	// - `helm`
	// - `kubernetes`
	// - `pipeline`
	// - `project`
	// - `repos`
	// - `runner-installation`
	// - `step-type`
	// - `step-types`
	// - `view`
	// - `workflow`
	Scopes pulumi.StringArrayOutput `pulumi:"scopes"`
	// The Token, that should used as a new provider's token attribute.
	Token pulumi.StringOutput `pulumi:"token"`
	// The ID of a user within the referenced `accountId` that will own the API key.
	UserId pulumi.StringOutput `pulumi:"userId"`
}

// NewApiKey registers a new resource with the given unique name, arguments, and options.
func NewApiKey(ctx *pulumi.Context,
	name string, args *ApiKeyArgs, opts ...pulumi.ResourceOption) (*ApiKey, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	if args.UserId == nil {
		return nil, errors.New("invalid value for required argument 'UserId'")
	}
	var resource ApiKey
	err := ctx.RegisterResource("codefresh:index/apiKey:ApiKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApiKey gets an existing ApiKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApiKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApiKeyState, opts ...pulumi.ResourceOption) (*ApiKey, error) {
	var resource ApiKey
	err := ctx.ReadResource("codefresh:index/apiKey:ApiKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApiKey resources.
type apiKeyState struct {
	// The ID of account in which the API key will be created.
	AccountId *string `pulumi:"accountId"`
	// The display name for the API key.
	Name *string `pulumi:"name"`
	// A list of access scopes, that can be targeted. The possible values:
	// - `agent`
	// - `agents`
	// - `audit`
	// - `build`
	// - `cluster`
	// - `clusters`
	// - `environments-v2`
	// - `github-action`
	// - `helm`
	// - `kubernetes`
	// - `pipeline`
	// - `project`
	// - `repos`
	// - `runner-installation`
	// - `step-type`
	// - `step-types`
	// - `view`
	// - `workflow`
	Scopes []string `pulumi:"scopes"`
	// The Token, that should used as a new provider's token attribute.
	Token *string `pulumi:"token"`
	// The ID of a user within the referenced `accountId` that will own the API key.
	UserId *string `pulumi:"userId"`
}

type ApiKeyState struct {
	// The ID of account in which the API key will be created.
	AccountId pulumi.StringPtrInput
	// The display name for the API key.
	Name pulumi.StringPtrInput
	// A list of access scopes, that can be targeted. The possible values:
	// - `agent`
	// - `agents`
	// - `audit`
	// - `build`
	// - `cluster`
	// - `clusters`
	// - `environments-v2`
	// - `github-action`
	// - `helm`
	// - `kubernetes`
	// - `pipeline`
	// - `project`
	// - `repos`
	// - `runner-installation`
	// - `step-type`
	// - `step-types`
	// - `view`
	// - `workflow`
	Scopes pulumi.StringArrayInput
	// The Token, that should used as a new provider's token attribute.
	Token pulumi.StringPtrInput
	// The ID of a user within the referenced `accountId` that will own the API key.
	UserId pulumi.StringPtrInput
}

func (ApiKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiKeyState)(nil)).Elem()
}

type apiKeyArgs struct {
	// The ID of account in which the API key will be created.
	AccountId string `pulumi:"accountId"`
	// The display name for the API key.
	Name *string `pulumi:"name"`
	// A list of access scopes, that can be targeted. The possible values:
	// - `agent`
	// - `agents`
	// - `audit`
	// - `build`
	// - `cluster`
	// - `clusters`
	// - `environments-v2`
	// - `github-action`
	// - `helm`
	// - `kubernetes`
	// - `pipeline`
	// - `project`
	// - `repos`
	// - `runner-installation`
	// - `step-type`
	// - `step-types`
	// - `view`
	// - `workflow`
	Scopes []string `pulumi:"scopes"`
	// The ID of a user within the referenced `accountId` that will own the API key.
	UserId string `pulumi:"userId"`
}

// The set of arguments for constructing a ApiKey resource.
type ApiKeyArgs struct {
	// The ID of account in which the API key will be created.
	AccountId pulumi.StringInput
	// The display name for the API key.
	Name pulumi.StringPtrInput
	// A list of access scopes, that can be targeted. The possible values:
	// - `agent`
	// - `agents`
	// - `audit`
	// - `build`
	// - `cluster`
	// - `clusters`
	// - `environments-v2`
	// - `github-action`
	// - `helm`
	// - `kubernetes`
	// - `pipeline`
	// - `project`
	// - `repos`
	// - `runner-installation`
	// - `step-type`
	// - `step-types`
	// - `view`
	// - `workflow`
	Scopes pulumi.StringArrayInput
	// The ID of a user within the referenced `accountId` that will own the API key.
	UserId pulumi.StringInput
}

func (ApiKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiKeyArgs)(nil)).Elem()
}

type ApiKeyInput interface {
	pulumi.Input

	ToApiKeyOutput() ApiKeyOutput
	ToApiKeyOutputWithContext(ctx context.Context) ApiKeyOutput
}

func (*ApiKey) ElementType() reflect.Type {
	return reflect.TypeOf((**ApiKey)(nil)).Elem()
}

func (i *ApiKey) ToApiKeyOutput() ApiKeyOutput {
	return i.ToApiKeyOutputWithContext(context.Background())
}

func (i *ApiKey) ToApiKeyOutputWithContext(ctx context.Context) ApiKeyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiKeyOutput)
}

// ApiKeyArrayInput is an input type that accepts ApiKeyArray and ApiKeyArrayOutput values.
// You can construct a concrete instance of `ApiKeyArrayInput` via:
//
//	ApiKeyArray{ ApiKeyArgs{...} }
type ApiKeyArrayInput interface {
	pulumi.Input

	ToApiKeyArrayOutput() ApiKeyArrayOutput
	ToApiKeyArrayOutputWithContext(context.Context) ApiKeyArrayOutput
}

type ApiKeyArray []ApiKeyInput

func (ApiKeyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ApiKey)(nil)).Elem()
}

func (i ApiKeyArray) ToApiKeyArrayOutput() ApiKeyArrayOutput {
	return i.ToApiKeyArrayOutputWithContext(context.Background())
}

func (i ApiKeyArray) ToApiKeyArrayOutputWithContext(ctx context.Context) ApiKeyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiKeyArrayOutput)
}

// ApiKeyMapInput is an input type that accepts ApiKeyMap and ApiKeyMapOutput values.
// You can construct a concrete instance of `ApiKeyMapInput` via:
//
//	ApiKeyMap{ "key": ApiKeyArgs{...} }
type ApiKeyMapInput interface {
	pulumi.Input

	ToApiKeyMapOutput() ApiKeyMapOutput
	ToApiKeyMapOutputWithContext(context.Context) ApiKeyMapOutput
}

type ApiKeyMap map[string]ApiKeyInput

func (ApiKeyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ApiKey)(nil)).Elem()
}

func (i ApiKeyMap) ToApiKeyMapOutput() ApiKeyMapOutput {
	return i.ToApiKeyMapOutputWithContext(context.Background())
}

func (i ApiKeyMap) ToApiKeyMapOutputWithContext(ctx context.Context) ApiKeyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiKeyMapOutput)
}

type ApiKeyOutput struct{ *pulumi.OutputState }

func (ApiKeyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ApiKey)(nil)).Elem()
}

func (o ApiKeyOutput) ToApiKeyOutput() ApiKeyOutput {
	return o
}

func (o ApiKeyOutput) ToApiKeyOutputWithContext(ctx context.Context) ApiKeyOutput {
	return o
}

// The ID of account in which the API key will be created.
func (o ApiKeyOutput) AccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiKey) pulumi.StringOutput { return v.AccountId }).(pulumi.StringOutput)
}

// The display name for the API key.
func (o ApiKeyOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiKey) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// A list of access scopes, that can be targeted. The possible values:
// - `agent`
// - `agents`
// - `audit`
// - `build`
// - `cluster`
// - `clusters`
// - `environments-v2`
// - `github-action`
// - `helm`
// - `kubernetes`
// - `pipeline`
// - `project`
// - `repos`
// - `runner-installation`
// - `step-type`
// - `step-types`
// - `view`
// - `workflow`
func (o ApiKeyOutput) Scopes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ApiKey) pulumi.StringArrayOutput { return v.Scopes }).(pulumi.StringArrayOutput)
}

// The Token, that should used as a new provider's token attribute.
func (o ApiKeyOutput) Token() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiKey) pulumi.StringOutput { return v.Token }).(pulumi.StringOutput)
}

// The ID of a user within the referenced `accountId` that will own the API key.
func (o ApiKeyOutput) UserId() pulumi.StringOutput {
	return o.ApplyT(func(v *ApiKey) pulumi.StringOutput { return v.UserId }).(pulumi.StringOutput)
}

type ApiKeyArrayOutput struct{ *pulumi.OutputState }

func (ApiKeyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ApiKey)(nil)).Elem()
}

func (o ApiKeyArrayOutput) ToApiKeyArrayOutput() ApiKeyArrayOutput {
	return o
}

func (o ApiKeyArrayOutput) ToApiKeyArrayOutputWithContext(ctx context.Context) ApiKeyArrayOutput {
	return o
}

func (o ApiKeyArrayOutput) Index(i pulumi.IntInput) ApiKeyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ApiKey {
		return vs[0].([]*ApiKey)[vs[1].(int)]
	}).(ApiKeyOutput)
}

type ApiKeyMapOutput struct{ *pulumi.OutputState }

func (ApiKeyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ApiKey)(nil)).Elem()
}

func (o ApiKeyMapOutput) ToApiKeyMapOutput() ApiKeyMapOutput {
	return o
}

func (o ApiKeyMapOutput) ToApiKeyMapOutputWithContext(ctx context.Context) ApiKeyMapOutput {
	return o
}

func (o ApiKeyMapOutput) MapIndex(k pulumi.StringInput) ApiKeyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ApiKey {
		return vs[0].(map[string]*ApiKey)[vs[1].(string)]
	}).(ApiKeyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ApiKeyInput)(nil)).Elem(), &ApiKey{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApiKeyArrayInput)(nil)).Elem(), ApiKeyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApiKeyMapInput)(nil)).Elem(), ApiKeyMap{})
	pulumi.RegisterOutputType(ApiKeyOutput{})
	pulumi.RegisterOutputType(ApiKeyArrayOutput{})
	pulumi.RegisterOutputType(ApiKeyMapOutput{})
}