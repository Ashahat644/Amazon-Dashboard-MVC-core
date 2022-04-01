using Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class OrderData : BaseClass
    {
        public DateTime? OrderDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public string OrderAddress { get; set; }
        public int? CreditcardId { get; set; }
        public int? CustomerId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
    }
}
