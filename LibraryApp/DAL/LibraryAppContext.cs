using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryApp.Models;

namespace LibraryApp.DAL
{
    class LibraryAppContext : DbContext
    {
        public LibraryAppContext() : base("LibraryAppContext")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
