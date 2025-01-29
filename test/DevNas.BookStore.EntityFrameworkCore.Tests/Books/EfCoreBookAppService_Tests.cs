using DevNas.BookStore.EntityFrameworkCore;
using Xunit;

namespace DevNas.BookStore.Books
{
    [Collection(BookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
    {

    }
}
