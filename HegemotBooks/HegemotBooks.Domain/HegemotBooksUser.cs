using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace HegemotBooks.Domain
{
    public class HegemotBooksUser : IdentityUser
    {
        public string FullName { get; set; }

        public string MembershipCardId { get; set; }

        public MembershipCard MembershipCard { get; set; }

        public List<Order> Orders { get; set; }
    }
}
