using Microsoft.AspNetCore.Builder;
using DevNas.BookStore;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("DevNas.BookStore.Web.csproj"); 
await builder.RunAbpModuleAsync<BookStoreWebTestModule>(applicationName: "DevNas.BookStore.Web");

public partial class Program
{
}
