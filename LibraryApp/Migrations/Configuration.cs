namespace LibraryApp.Migrations
{
    using LibraryApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryApp.DAL.LibraryAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryApp.DAL.LibraryAppContext context)
        {
            Customer Customer1 = new Customer
            {
                Name = "Hikmət",
                Surname = "Şəmistanlı",
                PhoneNumber = "0503886876",
                DateBirth = new DateTime(1995, 12, 24),
                CreateAt = DateTime.Now
            };
            context.Customers.AddOrUpdate(Customer1);
            context.SaveChanges();


            Book Book1 = new Book
            {
                Name = "Dedektiv",
                Writter = "Çingiz Musatafayev",
                MonthlyPrice = 35,
                Count = 3,
            };
            context.Books.AddOrUpdate(Book1);
            context.SaveChanges();

            Manager Manager1 = new Manager
            {
                Name = "Yolçu",
                Surname = "Nəsib",
                Username = "yolchu@code.edu.az",
                Password = "Bahruza100bal"
            };
            context.Managers.AddOrUpdate(Manager1);
            context.SaveChanges();

            Order Order1 = new Order
            {
                Created = DateTime.Now,
                CustomerId = Customer1.Id
            };
            context.Orders.AddOrUpdate(Order1);
            context.SaveChanges();

            OrderItem OrderItem1 = new OrderItem
            {
                BookId = Book1.Id,
                OrderId = Order1.Id,
                EndRentTime = DateTime.Now.AddDays(15)
            };
            context.Orders.AddOrUpdate(Order1);
            context.SaveChanges();
        }
    }
}