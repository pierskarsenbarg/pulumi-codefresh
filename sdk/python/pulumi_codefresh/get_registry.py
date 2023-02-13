# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetRegistryResult',
    'AwaitableGetRegistryResult',
    'get_registry',
    'get_registry_output',
]

@pulumi.output_type
class GetRegistryResult:
    """
    A collection of values returned by getRegistry.
    """
    def __init__(__self__, default=None, domain=None, fallback_registry=None, id=None, kind=None, name=None, primary=None, registry_provider=None, repository_prefix=None):
        if default and not isinstance(default, bool):
            raise TypeError("Expected argument 'default' to be a bool")
        pulumi.set(__self__, "default", default)
        if domain and not isinstance(domain, str):
            raise TypeError("Expected argument 'domain' to be a str")
        pulumi.set(__self__, "domain", domain)
        if fallback_registry and not isinstance(fallback_registry, str):
            raise TypeError("Expected argument 'fallback_registry' to be a str")
        pulumi.set(__self__, "fallback_registry", fallback_registry)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if kind and not isinstance(kind, str):
            raise TypeError("Expected argument 'kind' to be a str")
        pulumi.set(__self__, "kind", kind)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if primary and not isinstance(primary, bool):
            raise TypeError("Expected argument 'primary' to be a bool")
        pulumi.set(__self__, "primary", primary)
        if registry_provider and not isinstance(registry_provider, str):
            raise TypeError("Expected argument 'registry_provider' to be a str")
        pulumi.set(__self__, "registry_provider", registry_provider)
        if repository_prefix and not isinstance(repository_prefix, str):
            raise TypeError("Expected argument 'repository_prefix' to be a str")
        pulumi.set(__self__, "repository_prefix", repository_prefix)

    @property
    @pulumi.getter
    def default(self) -> bool:
        """
        Bool.
        """
        return pulumi.get(self, "default")

    @property
    @pulumi.getter
    def domain(self) -> str:
        """
        String.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="fallbackRegistry")
    def fallback_registry(self) -> str:
        """
        String representing the id of the fallback registry.
        * `repository prefix` - String representing the optional prefix for registry.
        """
        return pulumi.get(self, "fallback_registry")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def kind(self) -> str:
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def primary(self) -> bool:
        """
        Bool.
        """
        return pulumi.get(self, "primary")

    @property
    @pulumi.getter(name="registryProvider")
    def registry_provider(self) -> str:
        """
        String identifying the type of registry. E.g. `dockerhub, ecr, acr` and others
        """
        return pulumi.get(self, "registry_provider")

    @property
    @pulumi.getter(name="repositoryPrefix")
    def repository_prefix(self) -> str:
        return pulumi.get(self, "repository_prefix")


class AwaitableGetRegistryResult(GetRegistryResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRegistryResult(
            default=self.default,
            domain=self.domain,
            fallback_registry=self.fallback_registry,
            id=self.id,
            kind=self.kind,
            name=self.name,
            primary=self.primary,
            registry_provider=self.registry_provider,
            repository_prefix=self.repository_prefix)


def get_registry(name: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRegistryResult:
    """
    ## # Data Source: Registry

    This data source allows retrieving information on any existing registry

    ## Example Usage

    ```python
    import pulumi
    import pulumi_codefresh as codefresh

    dockerhub = codefresh.get_registry(name="dockerhub")
    # example with using data reference to existing registry, not managed by terraform
    # "dockerhub" registry will be used as fallback for "dockerhub1"
    dockerhub1 = codefresh.Registry("dockerhub1",
        primary=not dockerhub.primary,
        spec=codefresh.RegistrySpecArgs(
            dockerhub=codefresh.RegistrySpecDockerhubArgs(
                username="test",
                password="test",
            ),
        ),
        fallback_registry=dockerhub.id)
    ```


    :param str name: Name of the registry to be retrieved
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('codefresh:index/getRegistry:getRegistry', __args__, opts=opts, typ=GetRegistryResult).value

    return AwaitableGetRegistryResult(
        default=__ret__.default,
        domain=__ret__.domain,
        fallback_registry=__ret__.fallback_registry,
        id=__ret__.id,
        kind=__ret__.kind,
        name=__ret__.name,
        primary=__ret__.primary,
        registry_provider=__ret__.registry_provider,
        repository_prefix=__ret__.repository_prefix)


@_utilities.lift_output_func(get_registry)
def get_registry_output(name: Optional[pulumi.Input[str]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRegistryResult]:
    """
    ## # Data Source: Registry

    This data source allows retrieving information on any existing registry

    ## Example Usage

    ```python
    import pulumi
    import pulumi_codefresh as codefresh

    dockerhub = codefresh.get_registry(name="dockerhub")
    # example with using data reference to existing registry, not managed by terraform
    # "dockerhub" registry will be used as fallback for "dockerhub1"
    dockerhub1 = codefresh.Registry("dockerhub1",
        primary=not dockerhub.primary,
        spec=codefresh.RegistrySpecArgs(
            dockerhub=codefresh.RegistrySpecDockerhubArgs(
                username="test",
                password="test",
            ),
        ),
        fallback_registry=dockerhub.id)
    ```


    :param str name: Name of the registry to be retrieved
    """
    ...