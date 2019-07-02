using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Manager
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [MaxLength(20), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Username { get; set; }
        [MaxLength(20), Required]
        public string Password { get; set; }
    }
}
