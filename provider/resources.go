// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package codefresh

import (
	"fmt"
	"path/filepath"

	"github.com/codefresh-io/terraform-provider-codefresh/codefresh"
	"github.com/pierskarsenbarg/pulumi-codefresh/provider/pkg/version"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "codefresh"
	// modules:
	mainMod = "index" // the codefresh module
)

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(codefresh.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:    p,
		Name: "codefresh",
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "CodeFresh",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "Piers Karsenbarg",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "",
		Description:       "A Pulumi package for creating and managing codefresh cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "codefresh", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://www.pulumi.com",
		Repository: "https://github.com/pierskarsenbarg/pulumi-codefresh",
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this
		// should match the TF provider module's require directive, not any replace directives.
		GitHubOrg: "codefresh-io",
		Config:    map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
		},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			// Map each resource in the Terraform provider to a Pulumi type. Two examples
			// are below - the single line form is the common case. The multi-line form is
			// needed only if you wish to override types or other default options.
			//
			// "aws_iam_role": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IamRole")}
			//
			// "aws_acm_certificate": {
			// 	Tok: tfbridge.MakeResource(mainPkg, mainMod, "Certificate"),
			// 	Fields: map[string]*tfbridge.SchemaInfo{
			// 		"tags": {Type: tfbridge.MakeType(mainPkg, "Tags")},
			// 	},
			// },
			"codefresh_account": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Account")},
			"codefresh_account_admins": {
				Tok:  tfbridge.MakeResource(mainPkg, mainMod, "AccountAdmins"),
				Docs: &tfbridge.DocInfo{Source: "account-admins.md"},
			},
			"codefresh_api_key": {
				Tok:  tfbridge.MakeResource(mainPkg, mainMod, "ApiKey"),
				Docs: &tfbridge.DocInfo{Source: "api-key.md"},
			},
			"codefresh_context": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Context")},
			"codefresh_idp_accounts": {
				Tok:  tfbridge.MakeResource(mainPkg, mainMod, "IdpAccounts"),
				Docs: &tfbridge.DocInfo{Source: "idp-accounts.md"},
			},
			"codefresh_permission": {
				Tok:  tfbridge.MakeResource(mainPkg, mainMod, "Permission"),
				Docs: &tfbridge.DocInfo{Source: "permissions.md"},
			},
			"codefresh_pipeline":              {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Pipeline")},
			"codefresh_pipeline_cron_trigger": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "PipelineCronTrigger")},
			"codefresh_project":               {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Project")},
			"codefresh_registry":              {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Registry")},
			"codefresh_step_types": {
				Tok:  tfbridge.MakeResource(mainPkg, mainMod, "StepTypes"),
				Docs: &tfbridge.DocInfo{Source: "step-types.md"},
			},
			"codefresh_team": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Team")},
			"codefresh_user": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "User")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			// Map each resource in the Terraform provider to a Pulumi function. An example
			// is below.
			// "aws_ami": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAmi")},
			"codefresh_account": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getAccount"),
				Docs: &tfbridge.DocInfo{Source: "../data/account.md"},
			},
			"codefresh_context": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getContext"),
				Docs: &tfbridge.DocInfo{Source: "../data/context.md"},
			},
			"codefresh_current_account": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getCurrentAccount"),
				Docs: &tfbridge.DocInfo{Source: "../data/current_accont.md"},
			},
			"codefresh_idps": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getIdps"),
				Docs: &tfbridge.DocInfo{Source: "../data/idps.md"},
			},
			"codefresh_registry": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getRegistry"),
				Docs: &tfbridge.DocInfo{Source: "../data/registry.md"},
			},
			"codefresh_step_types": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getStepTypes"),
				Docs: &tfbridge.DocInfo{Source: "../data/step-types.md"},
			},
			"codefresh_team": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getTeam"),
				Docs: &tfbridge.DocInfo{Source: "../data/team.md"},
			},
			"codefresh_user": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getUser"),
				Docs: &tfbridge.DocInfo{Source: "../data/user.md"},
			},
			"codefresh_users": {
				Tok:  tfbridge.MakeDataSource(mainPkg, mainMod, "getUsers"),
				Docs: &tfbridge.DocInfo{Source: "../data/users.md"},
			},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@pierskarsenbarg/codefresh",
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pierskarsenbarg/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			RootNamespace: "PiersKarsenbarg",
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	prov.SetAutonaming(255, "-")

	return prov
}
