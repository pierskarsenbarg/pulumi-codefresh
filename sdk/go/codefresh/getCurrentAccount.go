// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package codefresh

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # currentAccount data module
//
// Return current account (owner of the token) and its users
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-codefresh/sdk/go/codefresh"
//	"github.com/pulumi/pulumi-codefresh/sdk/go/codefresh"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			acc, err := codefresh.GetCurrentAccount(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("currentAc", acc)
//			return nil
//		})
//	}
//
// ```
//
// The output example:
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			return nil
//		})
//	}
//
// ```
func GetCurrentAccount(ctx *pulumi.Context, args *GetCurrentAccountArgs, opts ...pulumi.InvokeOption) (*GetCurrentAccountResult, error) {
	var rv GetCurrentAccountResult
	err := ctx.Invoke("codefresh:index/getCurrentAccount:getCurrentAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCurrentAccount.
type GetCurrentAccountArgs struct {
	_id   *string                 `pulumi:"_id"`
	Name  *string                 `pulumi:"name"`
	Users []GetCurrentAccountUser `pulumi:"users"`
}

// A collection of values returned by getCurrentAccount.
type GetCurrentAccountResult struct {
	_id *string `pulumi:"_id"`
	// The provider-assigned unique ID for this managed resource.
	Id    string                  `pulumi:"id"`
	Name  *string                 `pulumi:"name"`
	Users []GetCurrentAccountUser `pulumi:"users"`
}

func GetCurrentAccountOutput(ctx *pulumi.Context, args GetCurrentAccountOutputArgs, opts ...pulumi.InvokeOption) GetCurrentAccountResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetCurrentAccountResult, error) {
			args := v.(GetCurrentAccountArgs)
			r, err := GetCurrentAccount(ctx, &args, opts...)
			var s GetCurrentAccountResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetCurrentAccountResultOutput)
}

// A collection of arguments for invoking getCurrentAccount.
type GetCurrentAccountOutputArgs struct {
	_id   pulumi.StringPtrInput           `pulumi:"_id"`
	Name  pulumi.StringPtrInput           `pulumi:"name"`
	Users GetCurrentAccountUserArrayInput `pulumi:"users"`
}

func (GetCurrentAccountOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetCurrentAccountArgs)(nil)).Elem()
}

// A collection of values returned by getCurrentAccount.
type GetCurrentAccountResultOutput struct{ *pulumi.OutputState }

func (GetCurrentAccountResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetCurrentAccountResult)(nil)).Elem()
}

func (o GetCurrentAccountResultOutput) ToGetCurrentAccountResultOutput() GetCurrentAccountResultOutput {
	return o
}

func (o GetCurrentAccountResultOutput) ToGetCurrentAccountResultOutputWithContext(ctx context.Context) GetCurrentAccountResultOutput {
	return o
}

func (o GetCurrentAccountResultOutput) _id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetCurrentAccountResult) *string { return v._id }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetCurrentAccountResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetCurrentAccountResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetCurrentAccountResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetCurrentAccountResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o GetCurrentAccountResultOutput) Users() GetCurrentAccountUserArrayOutput {
	return o.ApplyT(func(v GetCurrentAccountResult) []GetCurrentAccountUser { return v.Users }).(GetCurrentAccountUserArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetCurrentAccountResultOutput{})
}
