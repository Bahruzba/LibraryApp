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
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public DateTime StartRentTime { get; set; }
        public DateTime EndRentTime { get; set; }
        public DateTime? ReturnTime { get; set; }
    }
}
