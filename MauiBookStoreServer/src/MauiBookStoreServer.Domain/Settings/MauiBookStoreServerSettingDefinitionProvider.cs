using Volo.Abp.Settings;

namespace MauiBookStoreServer.Settings
{
    public class MauiBookStoreServerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MauiBookStoreServerSettings.MySetting1));
        }
    }
}
