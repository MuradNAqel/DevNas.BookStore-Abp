using AutoMapper;
using DevNas.BookStore.Authors;
using DevNas.BookStore.Books;
using DevNas.BookStore.Web.Pages.Authors;

namespace DevNas.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        CreateMap<CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>();
        CreateMap<AuthorDto, EditModalModel.EditAuthorViewModel>();
        CreateMap<EditModalModel.EditAuthorViewModel, UpdateAuthorDto>();

        CreateMap<Pages.Books.CreateModalModel.CreateBookViewModel, CreateUpdateBookDto>();
        CreateMap<BookDto, Pages.Books.EditModalModel.EditBookViewModel>();
        CreateMap<Pages.Books.EditModalModel.EditBookViewModel, CreateUpdateBookDto>();
    }
}
