using System;
using System.ComponentModel.DataAnnotations;
using MauiBookStoreServer.Domain.Shared.Books;

namespace MauiBookStoreServer.Application.Contracts.Books
{
    public class UpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public BookType Type { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
