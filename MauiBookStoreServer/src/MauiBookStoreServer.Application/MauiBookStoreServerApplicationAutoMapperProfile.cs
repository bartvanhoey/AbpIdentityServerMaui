using AutoMapper;
using MauiBookStoreServer.Application.Contracts.Books;
using MauiBookStoreServer.Domain.Books;

namespace MauiBookStoreServer
{
    public class MauiBookStoreServerApplicationAutoMapperProfile : Profile
    {
        public MauiBookStoreServerApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateBookDto, Book>();
            CreateMap<UpdateBookDto, Book>();
        }
    }
}
