namespace LibraryApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Pages { get; set; }
        public DateTime? PublicationDate { get; set; }


        //public Book(string title, string author, int? pages, DateTime? pubDate)
        //{
        //    if (string.IsNullOrWhiteSpace(title))
        //    {
        //        throw new ArgumentException(message: "Title cannot be null or empty.", paramName: nameof(title));
        //    }

        //    if (string.IsNullOrWhiteSpace(author))
        //    {
        //        throw new ArgumentException(message: "Author cannot be null or empty.", paramName: nameof(author));
        //    }

        //    var rand = new Random();

        //    Id = rand.Next(1000000, 9000000);
        //    Title = title;
        //    Author = author;

        //    if (pages != null)
        //    {
        //        Pages = Pages;
        //    }

        //    if (pubDate != null)
        //    {
        //        PublicationDate = pubDate;
        //    }
        //}
    }
}
