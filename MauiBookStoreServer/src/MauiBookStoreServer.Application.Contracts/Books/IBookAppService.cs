using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MauiBookStoreServer.Application.Contracts.Books
{
  public interface IBookAppService : ICrudAppService<BookDto, Guid, PagedAndSortedResultRequestDto, CreateBookDto, UpdateBookDto>   
  {
        
  }
}
