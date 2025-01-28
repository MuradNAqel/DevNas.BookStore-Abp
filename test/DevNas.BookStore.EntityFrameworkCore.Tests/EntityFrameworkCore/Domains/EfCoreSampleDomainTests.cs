using DevNas.BookStore.Samples;
using Xunit;

namespace DevNas.BookStore.EntityFrameworkCore.Domains;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreEntityFrameworkCoreTestModule>
{

}
