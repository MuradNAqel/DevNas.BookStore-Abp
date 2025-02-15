using DevNas.BookStore.Localization;
using DevNas.BookStore.Permissions;
using System.Threading.Tasks;
using Volo.Abp.AuditLogging.Web.Navigation;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.LanguageManagement.Navigation;
using Volo.Abp.OpenIddict.Pro.Web.Menus;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TextTemplateManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;
using Volo.Saas.Host.Navigation;

namespace DevNas.BookStore.Web.Menus;

public class BookStoreMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private static Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<BookStoreResource>();

        //Home
        context.Menu.AddItem(
            new ApplicationMenuItem(
                BookStoreMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fa fa-home",
                order: 1
            )
        );

        context.Menu.AddItem(
            new ApplicationMenuItem(
                "BooksStore",
                l["Menu:BookStore"],
                icon: "fa fa-book"
            ).AddItem(
                new ApplicationMenuItem(
                    "BooksStore.Books",
                    l["Menu:Books"],
                    url: "/Books"
                ).RequirePermissions(BookStorePermissions.Books.Default)
            ).AddItem( // ADDED THE NEW "AUTHORS" MENU ITEM UNDER THE "BOOK STORE" MENU
                new ApplicationMenuItem(
                    "BooksStore.Authors",
                    l["Menu:Authors"],
                    url: "/Authors"
                ).RequirePermissions(BookStorePermissions.Authors.Default)
            )
        );


        ////HostDashboard
        //context.Menu.AddItem(
        //    new ApplicationMenuItem(
        //        BookStoreMenus.HostDashboard,
        //        l["Menu:Dashboard"],
        //        "~/HostDashboard",
        //        icon: "fa fa-line-chart",
        //        order: 2
        //    ).RequirePermissions(BookStorePermissions.Dashboard.Host)
        //);

        ////TenantDashboard
        //context.Menu.AddItem(
        //    new ApplicationMenuItem(
        //        BookStoreMenus.TenantDashboard,
        //        l["Menu:Dashboard"],
        //        "~/Dashboard",
        //        icon: "fa fa-line-chart",
        //        order: 2
        //    ).RequirePermissions(BookStorePermissions.Dashboard.Tenant)
        //);


        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 5;

        //Administration->Saas
        administration.SetSubItemOrder(SaasHostMenuNames.GroupName, 1);

        //Administration->Identity
        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);

        //Administration->OpenIddict
        administration.SetSubItemOrder(OpenIddictProMenus.GroupName, 3);

        //Administration->Language Management
        administration.SetSubItemOrder(LanguageManagementMenuNames.GroupName, 4);

        //Administration->Text Template Management
        administration.SetSubItemOrder(TextTemplateManagementMainMenuNames.GroupName, 5);

        //Administration->Audit Logs
        administration.SetSubItemOrder(AbpAuditLoggingMainMenuNames.GroupName, 6);

        //Administration->Settings
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 7);

        ////Menu Items
        //context.Menu.AddItem(
        //    new ApplicationMenuItem(
        //        "BooksStore",
        //        l["Menu:BookStore"],
        //        icon: "fa fa-book"
        //    ).AddItem(
        //        new ApplicationMenuItem(
        //            "BooksStore.Books",
        //            l["Menu:Books"],
        //            url: "/Books"
        //        ).RequirePermissions(BookStorePermissions.Books.Default) // Check the permission!
        //    )
        //);



        return Task.CompletedTask;
    }
}
