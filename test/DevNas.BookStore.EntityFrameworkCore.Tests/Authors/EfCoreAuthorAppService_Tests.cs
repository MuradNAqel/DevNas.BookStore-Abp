using DevNas.BookStore.EntityFrameworkCore;
using Xunit;

namespace DevNas.BookStore.Authors
{
    [Collection(BookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
    {

    }
}
