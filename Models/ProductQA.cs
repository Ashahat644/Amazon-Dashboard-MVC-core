using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class ProductQA
    {
        public int ProductId { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public virtual Product Product { get; set; }
    }
}
