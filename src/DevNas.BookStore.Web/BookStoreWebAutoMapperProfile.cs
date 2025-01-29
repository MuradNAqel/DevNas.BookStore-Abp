using AutoMapper;
using DevNas.BookStore.Books;

namespace DevNas.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
    }
}
