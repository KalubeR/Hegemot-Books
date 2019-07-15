using System;

namespace HegemotBooks.Domain
{
    public class MembershipCard
    {
        public string Id { get; set; }

        public HegemotBooksUser Owner { get; set; }

        public DateTime IssuedOn { get; set; }

        public DateTime Expires { get; set; }
    }
}