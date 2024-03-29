﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class CustomerProduct
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
