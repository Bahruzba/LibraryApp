using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(30), Required]
        public string Surname { get; set; }
        [Required, MaxLength(10), MinLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime DateBirth { get; set; }
        public DateTime CreateAt { get; set; }

        public List<Order> Orderds { get; set; }
    }
}
