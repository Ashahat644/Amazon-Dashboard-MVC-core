using Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class Order : BaseClass
    {
        public DateTime? OrderDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public string OrderAddress { get; set; }
        public int? CreditcardId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Creditcard Creditcard { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
