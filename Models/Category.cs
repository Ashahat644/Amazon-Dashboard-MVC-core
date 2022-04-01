using Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class Category : BaseClass
    {
        public Category()
        {
            Subcategories = new HashSet<Subcategory>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}
