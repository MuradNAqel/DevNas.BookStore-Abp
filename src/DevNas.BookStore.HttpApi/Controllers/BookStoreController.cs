using DevNas.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DevNas.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
