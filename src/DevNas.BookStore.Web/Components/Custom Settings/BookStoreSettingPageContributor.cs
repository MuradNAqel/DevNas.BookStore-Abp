using System.Threading.Tasks;
using Volo.Abp.SettingManagement.Web.Pages.SettingManagement;

namespace DevNas.BookStore.Web.Components.Custom_Settings
{
    public class BookStoreSettingPageContributor : ISettingPageContributor
    {
        public Task ConfigureAsync(SettingPageCreationContext context)
        {
            context.Groups.Add(
                new SettingPageGroup(
                    "Volo.Abp.CustomSettingGroup",
                    "Allow to view Authors",
                    typeof(CustomSettingGroupViewComponent),
                    order: 1
                )
            );

            return Task.CompletedTask;
        }

        public Task<bool> CheckPermissionsAsync(SettingPageCreationContext context)
        {
            return Task.FromResult(true);
        }

    }
}
