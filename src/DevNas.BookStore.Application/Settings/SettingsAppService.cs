using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.SettingManagement;

namespace DevNas.BookStore.Settings
{
    [RemoteService(true)]
    public class SettingsAppService : ApplicationService, ISettingsAppService
    {
        private readonly ISettingManager _settingManager;

        public SettingsAppService(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public async Task SetAllowToViewAuthors(bool value)
        {
            await _settingManager.SetGlobalAsync(BookStoreSettings.ViewAuthorsTable, value.ToString());
        }


        public async Task<string> GetAllowToViewAuthors()
        {
            return await _settingManager.GetOrNullForCurrentUserAsync(BookStoreSettings.ViewAuthorsTable);
        }
    }
}
