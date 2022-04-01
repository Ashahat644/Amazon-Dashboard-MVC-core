using Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class Customer : BaseClass
    {
        public Customer()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerProducts = new HashSet<CustomerProduct>();
            CustomerProductsRates = new HashSet<CustomerProductsRate>();
            Lists = new HashSet<List>();
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int? CartId { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<CustomerProductsRate> CustomerProductsRates { get; set; }
        public virtual ICollection<List> Lists { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
