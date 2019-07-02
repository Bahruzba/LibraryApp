using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(40), Required]
        public string Writter { get; set; }
        [Required]
        public decimal MonthlyPrice { get; set; }
        [Required]
        public int Count { get; set; }
        public List<Order> Orders { get; set; }
    }
}