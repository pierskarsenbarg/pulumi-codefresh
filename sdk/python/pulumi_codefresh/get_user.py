# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs

__all__ = [
    'GetUserResult',
    'AwaitableGetUserResult',
    'get_user',
    'get_user_output',
]

@pulumi.output_type
class GetUserResult:
    """
    A collection of values returned by getUser.
    """
    def __init__(__self__, email=None, id=None, logins=None, personals=None, roles=None, short_profiles=None, status=None, user_id=None, user_name=None):
        if email and not isinstance(email, str):
            raise TypeError("Expected argument 'email' to be a str")
        pulumi.set(__self__, "email", email)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if logins and not isinstance(logins, list):
            raise TypeError("Expected argument 'logins' to be a list")
        pulumi.set(__self__, "logins", logins)
        if personals and not isinstance(personals, list):
            raise TypeError("Expected argument 'personals' to be a list")
        pulumi.set(__self__, "personals", personals)
        if roles and not isinstance(roles, list):
            raise TypeError("Expected argument 'roles' to be a list")
        pulumi.set(__self__, "roles", roles)
        if short_profiles and not isinstance(short_profiles, list):
            raise TypeError("Expected argument 'short_profiles' to be a list")
        pulumi.set(__self__, "short_profiles", short_profiles)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if user_id and not isinstance(user_id, str):
            raise TypeError("Expected argument 'user_id' to be a str")
        pulumi.set(__self__, "user_id", user_id)
        if user_name and not isinstance(user_name, str):
            raise TypeError("Expected argument 'user_name' to be a str")
        pulumi.set(__self__, "user_name", user_name)

    @property
    @pulumi.getter
    def email(self) -> str:
        return pulumi.get(self, "email")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def logins(self) -> Sequence['outputs.GetUserLoginResult']:
        return pulumi.get(self, "logins")

    @property
    @pulumi.getter
    def personals(self) -> Sequence['outputs.GetUserPersonalResult']:
        return pulumi.get(self, "personals")

    @property
    @pulumi.getter
    def roles(self) -> Sequence[str]:
        return pulumi.get(self, "roles")

    @property
    @pulumi.getter(name="shortProfiles")
    def short_profiles(self) -> Sequence['outputs.GetUserShortProfileResult']:
        return pulumi.get(self, "short_profiles")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> str:
        return pulumi.get(self, "user_id")

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> str:
        return pulumi.get(self, "user_name")


class AwaitableGetUserResult(GetUserResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetUserResult(
            email=self.email,
            id=self.id,
            logins=self.logins,
            personals=self.personals,
            roles=self.roles,
            short_profiles=self.short_profiles,
            status=self.status,
            user_id=self.user_id,
            user_name=self.user_name)


def get_user(email: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetUserResult:
    """
    ## # User Data Source

    Use this data source to get the User from existing users for use in other resources.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_codefresh as codefresh

    admin = codefresh.get_user(email="admin@codefresh.io")
    admins = codefresh.Team("admins", users=[
        admin.user_id,
        "<ANY USER ID>",
    ])
    ```


    :param str email: The email of user to filter.
    """
    __args__ = dict()
    __args__['email'] = email
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('codefresh:index/getUser:getUser', __args__, opts=opts, typ=GetUserResult).value

    return AwaitableGetUserResult(
        email=__ret__.email,
        id=__ret__.id,
        logins=__ret__.logins,
        personals=__ret__.personals,
        roles=__ret__.roles,
        short_profiles=__ret__.short_profiles,
        status=__ret__.status,
        user_id=__ret__.user_id,
        user_name=__ret__.user_name)


@_utilities.lift_output_func(get_user)
def get_user_output(email: Optional[pulumi.Input[str]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetUserResult]:
    """
    ## # User Data Source

    Use this data source to get the User from existing users for use in other resources.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_codefresh as codefresh

    admin = codefresh.get_user(email="admin@codefresh.io")
    admins = codefresh.Team("admins", users=[
        admin.user_id,
        "<ANY USER ID>",
    ])
    ```


    :param str email: The email of user to filter.
    """
    ...
