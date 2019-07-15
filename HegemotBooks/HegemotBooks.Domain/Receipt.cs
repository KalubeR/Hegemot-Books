using System;

namespace HegemotBooks.Domain
{
    public class Receipt
    {
        public string Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public decimal TotalPrice { get; set; }
    }
}