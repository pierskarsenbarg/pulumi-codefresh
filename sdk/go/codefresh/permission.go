// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package codefresh

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # resource Permission
//
// Permission are used to setup access control and allow to define which teams have access to which clusters and pipelines based on tags
// See the [documentation](https://codefresh.io/docs/docs/administration/access-control/).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-codefresh/sdk/go/codefresh"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			developersTeam, err := codefresh.NewTeam(ctx, "developersTeam", &codefresh.TeamArgs{
//				Users: pulumi.StringArray{
//					pulumi.String("5efc3cb6355c6647041b6e49"),
//					pulumi.String("59009221c102763beda7cf04"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = codefresh.NewPermission(ctx, "developersPermission", &codefresh.PermissionArgs{
//				Team:     developersTeam.ID(),
//				Resource: pulumi.String("pipeline"),
//				Action:   pulumi.String("run"),
//				Tags: pulumi.StringArray{
//					pulumi.String("demo"),
//					pulumi.String("test"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type Permission struct {
	pulumi.CustomResourceState

	_id pulumi.StringOutput `pulumi:"_id"`
	// Action to be allowed. Possible values:
	// - __create__
	// - __read__
	// - __update__
	// - __delete__
	// - __run__ (Only valid for `pipeline` resource)
	// - __approve__ (Only valid for `pipeline` resource)
	// - __debug__ (Only valid for `pipeline` resource)
	Action pulumi.StringOutput `pulumi:"action"`
	// The type of resource the permission applies to. Possible values:
	// - __pipeline__
	// - __cluster__
	Resource pulumi.StringOutput `pulumi:"resource"`
	// The effective tags to apply the permission. It supports 2 custom tags:
	// - __untagged__ is a “tag” which refers to all clusters that don’t have any tag.
	// - __*__ (the star character) means all tags.
	Tags pulumi.StringArrayOutput `pulumi:"tags"`
	// The Id of the team the permissions apply to.
	Team pulumi.StringOutput `pulumi:"team"`
}

// NewPermission registers a new resource with the given unique name, arguments, and options.
func NewPermission(ctx *pulumi.Context,
	name string, args *PermissionArgs, opts ...pulumi.ResourceOption) (*Permission, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Action == nil {
		return nil, errors.New("invalid value for required argument 'Action'")
	}
	if args.Resource == nil {
		return nil, errors.New("invalid value for required argument 'Resource'")
	}
	if args.Team == nil {
		return nil, errors.New("invalid value for required argument 'Team'")
	}
	var resource Permission
	err := ctx.RegisterResource("codefresh:index/permission:Permission", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPermission gets an existing Permission resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPermission(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PermissionState, opts ...pulumi.ResourceOption) (*Permission, error) {
	var resource Permission
	err := ctx.ReadResource("codefresh:index/permission:Permission", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Permission resources.
type permissionState struct {
	_id *string `pulumi:"_id"`
	// Action to be allowed. Possible values:
	// - __create__
	// - __read__
	// - __update__
	// - __delete__
	// - __run__ (Only valid for `pipeline` resource)
	// - __approve__ (Only valid for `pipeline` resource)
	// - __debug__ (Only valid for `pipeline` resource)
	Action *string `pulumi:"action"`
	// The type of resource the permission applies to. Possible values:
	// - __pipeline__
	// - __cluster__
	Resource *string `pulumi:"resource"`
	// The effective tags to apply the permission. It supports 2 custom tags:
	// - __untagged__ is a “tag” which refers to all clusters that don’t have any tag.
	// - __*__ (the star character) means all tags.
	Tags []string `pulumi:"tags"`
	// The Id of the team the permissions apply to.
	Team *string `pulumi:"team"`
}

type PermissionState struct {
	_id pulumi.StringPtrInput
	// Action to be allowed. Possible values:
	// - __create__
	// - __read__
	// - __update__
	// - __delete__
	// - __run__ (Only valid for `pipeline` resource)
	// - __approve__ (Only valid for `pipeline` resource)
	// - __debug__ (Only valid for `pipeline` resource)
	Action pulumi.StringPtrInput
	// The type of resource the permission applies to. Possible values:
	// - __pipeline__
	// - __cluster__
	Resource pulumi.StringPtrInput
	// The effective tags to apply the permission. It supports 2 custom tags:
	// - __untagged__ is a “tag” which refers to all clusters that don’t have any tag.
	// - __*__ (the star character) means all tags.
	Tags pulumi.StringArrayInput
	// The Id of the team the permissions apply to.
	Team pulumi.StringPtrInput
}

func (PermissionState) ElementType() reflect.Type {
	return reflect.TypeOf((*permissionState)(nil)).Elem()
}

type permissionArgs struct {
	_id *string `pulumi:"_id"`
	// Action to be allowed. Possible values:
	// - __create__
	// - __read__
	// - __update__
	// - __delete__
	// - __run__ (Only valid for `pipeline` resource)
	// - __approve__ (Only valid for `pipeline` resource)
	// - __debug__ (Only valid for `pipeline` resource)
	Action string `pulumi:"action"`
	// The type of resource the permission applies to. Possible values:
	// - __pipeline__
	// - __cluster__
	Resource string `pulumi:"resource"`
	// The effective tags to apply the permission. It supports 2 custom tags:
	// - __untagged__ is a “tag” which refers to all clusters that don’t have any tag.
	// - __*__ (the star character) means all tags.
	Tags []string `pulumi:"tags"`
	// The Id of the team the permissions apply to.
	Team string `pulumi:"team"`
}

// The set of arguments for constructing a Permission resource.
type PermissionArgs struct {
	_id pulumi.StringPtrInput
	// Action to be allowed. Possible values:
	// - __create__
	// - __read__
	// - __update__
	// - __delete__
	// - __run__ (Only valid for `pipeline` resource)
	// - __approve__ (Only valid for `pipeline` resource)
	// - __debug__ (Only valid for `pipeline` resource)
	Action pulumi.StringInput
	// The type of resource the permission applies to. Possible values:
	// - __pipeline__
	// - __cluster__
	Resource pulumi.StringInput
	// The effective tags to apply the permission. It supports 2 custom tags:
	// - __untagged__ is a “tag” which refers to all clusters that don’t have any tag.
	// - __*__ (the star character) means all tags.
	Tags pulumi.StringArrayInput
	// The Id of the team the permissions apply to.
	Team pulumi.StringInput
}

func (PermissionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*permissionArgs)(nil)).Elem()
}

type PermissionInput interface {
	pulumi.Input

	ToPermissionOutput() PermissionOutput
	ToPermissionOutputWithContext(ctx context.Context) PermissionOutput
}

func (*Permission) ElementType() reflect.Type {
	return reflect.TypeOf((**Permission)(nil)).Elem()
}

func (i *Permission) ToPermissionOutput() PermissionOutput {
	return i.ToPermissionOutputWithContext(context.Background())
}

func (i *Permission) ToPermissionOutputWithContext(ctx context.Context) PermissionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PermissionOutput)
}

// PermissionArrayInput is an input type that accepts PermissionArray and PermissionArrayOutput values.
// You can construct a concrete instance of `PermissionArrayInput` via:
//
//	PermissionArray{ PermissionArgs{...} }
type PermissionArrayInput interface {
	pulumi.Input

	ToPermissionArrayOutput() PermissionArrayOutput
	ToPermissionArrayOutputWithContext(context.Context) PermissionArrayOutput
}

type PermissionArray []PermissionInput

func (PermissionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Permission)(nil)).Elem()
}

func (i PermissionArray) ToPermissionArrayOutput() PermissionArrayOutput {
	return i.ToPermissionArrayOutputWithContext(context.Background())
}

func (i PermissionArray) ToPermissionArrayOutputWithContext(ctx context.Context) PermissionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PermissionArrayOutput)
}

// PermissionMapInput is an input type that accepts PermissionMap and PermissionMapOutput values.
// You can construct a concrete instance of `PermissionMapInput` via:
//
//	PermissionMap{ "key": PermissionArgs{...} }
type PermissionMapInput interface {
	pulumi.Input

	ToPermissionMapOutput() PermissionMapOutput
	ToPermissionMapOutputWithContext(context.Context) PermissionMapOutput
}

type PermissionMap map[string]PermissionInput

func (PermissionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Permission)(nil)).Elem()
}

func (i PermissionMap) ToPermissionMapOutput() PermissionMapOutput {
	return i.ToPermissionMapOutputWithContext(context.Background())
}

func (i PermissionMap) ToPermissionMapOutputWithContext(ctx context.Context) PermissionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PermissionMapOutput)
}

type PermissionOutput struct{ *pulumi.OutputState }

func (PermissionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Permission)(nil)).Elem()
}

func (o PermissionOutput) ToPermissionOutput() PermissionOutput {
	return o
}

func (o PermissionOutput) ToPermissionOutputWithContext(ctx context.Context) PermissionOutput {
	return o
}

func (o PermissionOutput) _id() pulumi.StringOutput {
	return o.ApplyT(func(v *Permission) pulumi.StringOutput { return v._id }).(pulumi.StringOutput)
}

// Action to be allowed. Possible values:
// - __create__
// - __read__
// - __update__
// - __delete__
// - __run__ (Only valid for `pipeline` resource)
// - __approve__ (Only valid for `pipeline` resource)
// - __debug__ (Only valid for `pipeline` resource)
func (o PermissionOutput) Action() pulumi.StringOutput {
	return o.ApplyT(func(v *Permission) pulumi.StringOutput { return v.Action }).(pulumi.StringOutput)
}

// The type of resource the permission applies to. Possible values:
// - __pipeline__
// - __cluster__
func (o PermissionOutput) Resource() pulumi.StringOutput {
	return o.ApplyT(func(v *Permission) pulumi.StringOutput { return v.Resource }).(pulumi.StringOutput)
}

// The effective tags to apply the permission. It supports 2 custom tags:
// - __untagged__ is a “tag” which refers to all clusters that don’t have any tag.
// - __*__ (the star character) means all tags.
func (o PermissionOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Permission) pulumi.StringArrayOutput { return v.Tags }).(pulumi.StringArrayOutput)
}

// The Id of the team the permissions apply to.
func (o PermissionOutput) Team() pulumi.StringOutput {
	return o.ApplyT(func(v *Permission) pulumi.StringOutput { return v.Team }).(pulumi.StringOutput)
}

type PermissionArrayOutput struct{ *pulumi.OutputState }

func (PermissionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Permission)(nil)).Elem()
}

func (o PermissionArrayOutput) ToPermissionArrayOutput() PermissionArrayOutput {
	return o
}

func (o PermissionArrayOutput) ToPermissionArrayOutputWithContext(ctx context.Context) PermissionArrayOutput {
	return o
}

func (o PermissionArrayOutput) Index(i pulumi.IntInput) PermissionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Permission {
		return vs[0].([]*Permission)[vs[1].(int)]
	}).(PermissionOutput)
}

type PermissionMapOutput struct{ *pulumi.OutputState }

func (PermissionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Permission)(nil)).Elem()
}

func (o PermissionMapOutput) ToPermissionMapOutput() PermissionMapOutput {
	return o
}

func (o PermissionMapOutput) ToPermissionMapOutputWithContext(ctx context.Context) PermissionMapOutput {
	return o
}

func (o PermissionMapOutput) MapIndex(k pulumi.StringInput) PermissionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Permission {
		return vs[0].(map[string]*Permission)[vs[1].(string)]
	}).(PermissionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PermissionInput)(nil)).Elem(), &Permission{})
	pulumi.RegisterInputType(reflect.TypeOf((*PermissionArrayInput)(nil)).Elem(), PermissionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PermissionMapInput)(nil)).Elem(), PermissionMap{})
	pulumi.RegisterOutputType(PermissionOutput{})
	pulumi.RegisterOutputType(PermissionArrayOutput{})
	pulumi.RegisterOutputType(PermissionMapOutput{})
}
