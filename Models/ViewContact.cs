using Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class ViewContact : BaseClass
    {
        public string Phone { get; set; }
        public DateTime? Date { get; set; }
        public string Message { get; set; }
        public int? AdminId { get; set; }
    }
}
