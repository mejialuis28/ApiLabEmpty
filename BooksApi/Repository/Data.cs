using System.Collections.Generic;
using BooksApi.Models;

namespace BooksApi.Repository
{
    public static class Data
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book { Id = 1, Name = "The Stand", AuthorName = "Stephen King", ReleaseYear = 1978, NumberOfPages = 1584, Genre = "Apocalyptic Fiction"},
            new Book { Id = 2, Name = "The Ice Dragon", AuthorName = "George R. R. Martin", ReleaseYear = 1980, NumberOfPages = 112, Genre = "Fantasy"}
        };
    }
}