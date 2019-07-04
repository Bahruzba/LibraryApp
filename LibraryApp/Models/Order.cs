using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        public DateTime EndRentTime { get; set; }
        public DateTime? ReturnTime { get; set; }

    }
}
