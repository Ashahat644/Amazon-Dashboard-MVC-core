using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class CustomerAddress
    {
        public int CustomerId { get; set; }
        public int Id { get; set; }
        public int? PostalCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Region { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
