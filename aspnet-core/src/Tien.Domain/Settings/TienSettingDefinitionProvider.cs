using Volo.Abp.Settings;

namespace Tien.Settings
{
    public class TienSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TienSettings.MySetting1));
        }
    }
}
