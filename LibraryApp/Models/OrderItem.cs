﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime EndRentTime { get; set; }
        public DateTime? ReturnTime { get; set; }

    }
}
