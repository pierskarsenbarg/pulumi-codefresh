// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package codefresh

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Step-types Resource
//
// The Step-types resource allows to create your own typed step and manage all it's published versions.
// The resource allows to handle the life-cycle of the version by allowing specifying multiple blocks `version` where the user provides a version number and the yaml file representing the plugin.
// More about custom steps in the [official documentation](https://codefresh.io/docs/docs/codefresh-yaml/steps/#creating-a-typed-codefresh-plugin).
//
// ## Known limitations and disclaimers
//
// ### Version and name in yaml Metadata are ignored.
// The version and name of the step declared in the yaml files are superseeded by the attributes specified at resource level:
//   - `name` : at top level
//   - `versionNumer`: specified in the `version` block
//     The above are added/replaced at runtime time.
//
// ### Number of API requests
// This resource makes a lot of additional API calls to validate the steps and retrieve all the version available.
// Caution is recommended on the amount of versions maintained and the number of resources defined in a single project.
type StepTypes struct {
	pulumi.CustomResourceState

	// The name for the step-type
	Name pulumi.StringOutput `pulumi:"name"`
	// A collection of `version` blocks as documented below.
	Versions StepTypesVersionArrayOutput `pulumi:"versions"`
}

// NewStepTypes registers a new resource with the given unique name, arguments, and options.
func NewStepTypes(ctx *pulumi.Context,
	name string, args *StepTypesArgs, opts ...pulumi.ResourceOption) (*StepTypes, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Versions == nil {
		return nil, errors.New("invalid value for required argument 'Versions'")
	}
	var resource StepTypes
	err := ctx.RegisterResource("codefresh:index/stepTypes:StepTypes", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStepTypes gets an existing StepTypes resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStepTypes(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StepTypesState, opts ...pulumi.ResourceOption) (*StepTypes, error) {
	var resource StepTypes
	err := ctx.ReadResource("codefresh:index/stepTypes:StepTypes", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StepTypes resources.
type stepTypesState struct {
	// The name for the step-type
	Name *string `pulumi:"name"`
	// A collection of `version` blocks as documented below.
	Versions []StepTypesVersion `pulumi:"versions"`
}

type StepTypesState struct {
	// The name for the step-type
	Name pulumi.StringPtrInput
	// A collection of `version` blocks as documented below.
	Versions StepTypesVersionArrayInput
}

func (StepTypesState) ElementType() reflect.Type {
	return reflect.TypeOf((*stepTypesState)(nil)).Elem()
}

type stepTypesArgs struct {
	// The name for the step-type
	Name *string `pulumi:"name"`
	// A collection of `version` blocks as documented below.
	Versions []StepTypesVersion `pulumi:"versions"`
}

// The set of arguments for constructing a StepTypes resource.
type StepTypesArgs struct {
	// The name for the step-type
	Name pulumi.StringPtrInput
	// A collection of `version` blocks as documented below.
	Versions StepTypesVersionArrayInput
}

func (StepTypesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*stepTypesArgs)(nil)).Elem()
}

type StepTypesInput interface {
	pulumi.Input

	ToStepTypesOutput() StepTypesOutput
	ToStepTypesOutputWithContext(ctx context.Context) StepTypesOutput
}

func (*StepTypes) ElementType() reflect.Type {
	return reflect.TypeOf((**StepTypes)(nil)).Elem()
}

func (i *StepTypes) ToStepTypesOutput() StepTypesOutput {
	return i.ToStepTypesOutputWithContext(context.Background())
}

func (i *StepTypes) ToStepTypesOutputWithContext(ctx context.Context) StepTypesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StepTypesOutput)
}

// StepTypesArrayInput is an input type that accepts StepTypesArray and StepTypesArrayOutput values.
// You can construct a concrete instance of `StepTypesArrayInput` via:
//
//	StepTypesArray{ StepTypesArgs{...} }
type StepTypesArrayInput interface {
	pulumi.Input

	ToStepTypesArrayOutput() StepTypesArrayOutput
	ToStepTypesArrayOutputWithContext(context.Context) StepTypesArrayOutput
}

type StepTypesArray []StepTypesInput

func (StepTypesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*StepTypes)(nil)).Elem()
}

func (i StepTypesArray) ToStepTypesArrayOutput() StepTypesArrayOutput {
	return i.ToStepTypesArrayOutputWithContext(context.Background())
}

func (i StepTypesArray) ToStepTypesArrayOutputWithContext(ctx context.Context) StepTypesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StepTypesArrayOutput)
}

// StepTypesMapInput is an input type that accepts StepTypesMap and StepTypesMapOutput values.
// You can construct a concrete instance of `StepTypesMapInput` via:
//
//	StepTypesMap{ "key": StepTypesArgs{...} }
type StepTypesMapInput interface {
	pulumi.Input

	ToStepTypesMapOutput() StepTypesMapOutput
	ToStepTypesMapOutputWithContext(context.Context) StepTypesMapOutput
}

type StepTypesMap map[string]StepTypesInput

func (StepTypesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*StepTypes)(nil)).Elem()
}

func (i StepTypesMap) ToStepTypesMapOutput() StepTypesMapOutput {
	return i.ToStepTypesMapOutputWithContext(context.Background())
}

func (i StepTypesMap) ToStepTypesMapOutputWithContext(ctx context.Context) StepTypesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StepTypesMapOutput)
}

type StepTypesOutput struct{ *pulumi.OutputState }

func (StepTypesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StepTypes)(nil)).Elem()
}

func (o StepTypesOutput) ToStepTypesOutput() StepTypesOutput {
	return o
}

func (o StepTypesOutput) ToStepTypesOutputWithContext(ctx context.Context) StepTypesOutput {
	return o
}

// The name for the step-type
func (o StepTypesOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *StepTypes) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// A collection of `version` blocks as documented below.
func (o StepTypesOutput) Versions() StepTypesVersionArrayOutput {
	return o.ApplyT(func(v *StepTypes) StepTypesVersionArrayOutput { return v.Versions }).(StepTypesVersionArrayOutput)
}

type StepTypesArrayOutput struct{ *pulumi.OutputState }

func (StepTypesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*StepTypes)(nil)).Elem()
}

func (o StepTypesArrayOutput) ToStepTypesArrayOutput() StepTypesArrayOutput {
	return o
}

func (o StepTypesArrayOutput) ToStepTypesArrayOutputWithContext(ctx context.Context) StepTypesArrayOutput {
	return o
}

func (o StepTypesArrayOutput) Index(i pulumi.IntInput) StepTypesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *StepTypes {
		return vs[0].([]*StepTypes)[vs[1].(int)]
	}).(StepTypesOutput)
}

type StepTypesMapOutput struct{ *pulumi.OutputState }

func (StepTypesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*StepTypes)(nil)).Elem()
}

func (o StepTypesMapOutput) ToStepTypesMapOutput() StepTypesMapOutput {
	return o
}

func (o StepTypesMapOutput) ToStepTypesMapOutputWithContext(ctx context.Context) StepTypesMapOutput {
	return o
}

func (o StepTypesMapOutput) MapIndex(k pulumi.StringInput) StepTypesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *StepTypes {
		return vs[0].(map[string]*StepTypes)[vs[1].(string)]
	}).(StepTypesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*StepTypesInput)(nil)).Elem(), &StepTypes{})
	pulumi.RegisterInputType(reflect.TypeOf((*StepTypesArrayInput)(nil)).Elem(), StepTypesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*StepTypesMapInput)(nil)).Elem(), StepTypesMap{})
	pulumi.RegisterOutputType(StepTypesOutput{})
	pulumi.RegisterOutputType(StepTypesArrayOutput{})
	pulumi.RegisterOutputType(StepTypesMapOutput{})
}
