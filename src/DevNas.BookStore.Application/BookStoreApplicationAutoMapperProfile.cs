using AutoMapper;
using DevNas.BookStore.Authors;
using DevNas.BookStore.Books;

namespace DevNas.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<Author, AuthorDto>();
    }
}
