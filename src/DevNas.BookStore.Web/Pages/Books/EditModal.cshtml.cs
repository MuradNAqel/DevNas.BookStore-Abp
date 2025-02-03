using DevNas.BookStore.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace DevNas.BookStore.Web.Pages.Books
{
    public class EditModalModel : BookStorePageModel
    {
        //[HiddenInput]
        //[BindProperty(SupportsGet = true)]
        //public Guid Id { get; set; }

        [BindProperty]
        public EditBookViewModel Book { get; set; }
        public List<SelectListItem> Authors { get; set; }

        private readonly IBookAppService _bookAppService;

        public EditModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public async Task OnGetAsync(Guid Id)
        {
            var bookDto = await _bookAppService.GetAsync(Id);
            Book = ObjectMapper.Map<BookDto, EditBookViewModel>(bookDto);

            var authorLookup = await _bookAppService.GetAuthorLookupAsync();

            Authors = authorLookup.Items.Select(
                author => new SelectListItem(author.Name, author.Id.ToString()))
                .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.UpdateAsync(
                    Book.Id,
                    ObjectMapper.Map<EditBookViewModel, CreateUpdateBookDto>(Book)
                );
            return NoContent();
        }

        public class EditBookViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }

            [SelectItems(nameof(Authors))]
            [DisplayName("Author")]
            public Guid AuthorId { get; set; }

            [Required]
            [StringLength(128)]
            public string Name { get; set; } = string.Empty;

            [Required]
            public BookType Type { get; set; } = BookType.Undefined;

            [Required]
            [DataType(DataType.Date)]
            public DateTime PublishDate { get; set; } = DateTime.Now;

            [Required]
            public float Price { get; set; }
        }

    }
}
