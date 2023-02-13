// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package codefresh

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Data Source: Context
//
// This data source allows to retrieve information on any defined context
func LookupContext(ctx *pulumi.Context, args *LookupContextArgs, opts ...pulumi.InvokeOption) (*LookupContextResult, error) {
	var rv LookupContextResult
	err := ctx.Invoke("codefresh:index/getContext:getContext", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getContext.
type LookupContextArgs struct {
	// Name of the context to be retrived
	Name string `pulumi:"name"`
}

// A collection of values returned by getContext.
type LookupContextResult struct {
	// The yaml string representing the context. Use the `yamldecode` function to access the values belonging the context.
	Data string `pulumi:"data"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
	// String identifying the type of extracted context. E.g. `config`, `secret`, `git.github-app`, etc.
	Type string `pulumi:"type"`
}

func LookupContextOutput(ctx *pulumi.Context, args LookupContextOutputArgs, opts ...pulumi.InvokeOption) LookupContextResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupContextResult, error) {
			args := v.(LookupContextArgs)
			r, err := LookupContext(ctx, &args, opts...)
			var s LookupContextResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupContextResultOutput)
}

// A collection of arguments for invoking getContext.
type LookupContextOutputArgs struct {
	// Name of the context to be retrived
	Name pulumi.StringInput `pulumi:"name"`
}

func (LookupContextOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupContextArgs)(nil)).Elem()
}

// A collection of values returned by getContext.
type LookupContextResultOutput struct{ *pulumi.OutputState }

func (LookupContextResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupContextResult)(nil)).Elem()
}

func (o LookupContextResultOutput) ToLookupContextResultOutput() LookupContextResultOutput {
	return o
}

func (o LookupContextResultOutput) ToLookupContextResultOutputWithContext(ctx context.Context) LookupContextResultOutput {
	return o
}

// The yaml string representing the context. Use the `yamldecode` function to access the values belonging the context.
func (o LookupContextResultOutput) Data() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContextResult) string { return v.Data }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupContextResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContextResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupContextResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContextResult) string { return v.Name }).(pulumi.StringOutput)
}

// String identifying the type of extracted context. E.g. `config`, `secret`, `git.github-app`, etc.
func (o LookupContextResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContextResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupContextResultOutput{})
}
