using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DevNas.BookStore.Settings
{
    public interface ISettingsAppService : IApplicationService
    {
        Task<string> GetAllowToViewAuthors();
        Task SetAllowToViewAuthors(bool value);
    }
}
