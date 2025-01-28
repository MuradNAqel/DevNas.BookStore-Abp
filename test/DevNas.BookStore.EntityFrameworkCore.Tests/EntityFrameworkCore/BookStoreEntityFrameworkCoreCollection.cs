using Xunit;

namespace DevNas.BookStore.EntityFrameworkCore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreEntityFrameworkCoreCollection : ICollectionFixture<BookStoreEntityFrameworkCoreFixture>
{

}
