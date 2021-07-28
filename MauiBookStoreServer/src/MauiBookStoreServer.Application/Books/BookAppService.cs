using System;
using MauiBookStoreServer.Application.Contracts.Books;
using MauiBookStoreServer.Domain.Books;
using MauiBookStoreServer.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MauiBookStoreServer.Application.Books
{
public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, CreateBookDto, UpdateBookDto>, IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository): base(repository)
    {
        GetPolicyName = MauiBookStoreServerPermissions.Books.Default;
        GetListPolicyName = MauiBookStoreServerPermissions.Books.Default;
        CreatePolicyName = MauiBookStoreServerPermissions.Books.Create;
        UpdatePolicyName = MauiBookStoreServerPermissions.Books.Update;
        DeletePolicyName = MauiBookStoreServerPermissions.Books.Delete;
    }
}
}
