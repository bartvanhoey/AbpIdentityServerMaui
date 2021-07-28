using AutoMapper;
using MauiBookStoreServer.Application.Contracts.Books;


namespace MauiBookStoreServer.Blazor
{
    public class MauiBookStoreServerBlazorAutoMapperProfile : Profile
    {
        public MauiBookStoreServerBlazorAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Blazor project.
            CreateMap<BookDto, UpdateBookDto>();

        }
    }
}
