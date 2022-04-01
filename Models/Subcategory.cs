using Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class Subcategory : BaseClass
    {
        public Subcategory()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Discription { get; set; }
        public string Picture { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
