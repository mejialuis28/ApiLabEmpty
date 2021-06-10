namespace BooksApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string AuthorName { get; set; }
        public string Genre {get; set;}
        public int NumberOfPages {get; set;}
    }
}