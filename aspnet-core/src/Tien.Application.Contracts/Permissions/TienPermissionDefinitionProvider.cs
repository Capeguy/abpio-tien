using Tien.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tien.Permissions
{
    public class TienPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TienPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(TienPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TienResource>(name);
        }
    }
}
