using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
    }
}
