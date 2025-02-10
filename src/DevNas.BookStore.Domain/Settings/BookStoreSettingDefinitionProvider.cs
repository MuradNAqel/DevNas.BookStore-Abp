using DevNas.BookStore.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace DevNas.BookStore.Settings;

public class BookStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        context.Add(
                new SettingDefinition(
                        name: BookStoreSettings.ViewAuthorsTable,
                        defaultValue: "false",
                        displayName: LocalizableString.Create<BookStoreResource>(BookStoreSettings.ViewAuthorsTable),
                        isVisibleToClients: true
                    ));
    }
}
