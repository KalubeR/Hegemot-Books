using System;

namespace HegemotBooks.Domain
{
    public class Book
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string BookCategory { get; set; }

        public decimal Price { get; set; }

        public DateTime IssuedOn { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public int InStock { get; set; }
    }
}