using MauiBookStoreServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MauiBookStoreServer.Permissions
{
    public class MauiBookStoreServerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            // var myGroup = context.AddGroup(MauiBookStoreServerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MauiBookStoreServerPermissions.MyPermission1, L("Permission:MyPermission1"));

            var bookStoreGroup = context.AddGroup(MauiBookStoreServerPermissions.BookStoreGroup, L("Permission:BookStore"));

            var booksPermission = bookStoreGroup.AddPermission(MauiBookStoreServerPermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(MauiBookStoreServerPermissions.Books.Create, L("Permission:Books:Create"));
            booksPermission.AddChild(MauiBookStoreServerPermissions.Books.Update, L("Permission:Books:Update"));
            booksPermission.AddChild(MauiBookStoreServerPermissions.Books.Delete, L("Permission:Books:Delete"));
            
     
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MauiBookStoreServerResource>(name);
        }
    }
}
