﻿using Volo.Abp.Application.Dtos;

namespace DevNas.BookStore.Authors
{
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
