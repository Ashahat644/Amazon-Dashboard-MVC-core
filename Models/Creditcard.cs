using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class Creditcard
    {
        public Creditcard()
        {
            Orders = new HashSet<Order>();
        }

        public int CreditcardId { get; set; }
        public DateTime CardExpiredate { get; set; }
        public int CardNumber { get; set; }
        public int CardPin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
