using System.Collections.Generic;

namespace HegemotBooks.Domain
{
    public class Order
    {
        public Order()
        {
            this.Books = new List<Book>();
        }

        public string Id { get; set; }

        public int Quantity { get; set; }

        public List<Book> Books { get; set; }

        public HegemotBooksUser Issuer { get; set; }
    }
}