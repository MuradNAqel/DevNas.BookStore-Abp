using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace DevNas.BookStore.Web.Components.Custom_Settings
{
    public class CustomSettingGroupViewComponent : AbpViewComponent
    {
        public virtual IViewComponentResult Invoke()
        {
            return View("~/Components/Custom Settings/Default.cshtml");
        }
    }
}
