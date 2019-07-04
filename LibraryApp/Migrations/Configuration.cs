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
                Name = "Riyaziyyat",
                Writter="Agasəf Məmmədli",
                MonthlyPrice = 5,
                Count = 3,
            };
            context.Books.AddOrUpdate(Book1);
            context.SaveChanges();

            Manager Manager1 = new Manager
            {
                Name = "Əhmədov",
                Surname = "Bəhruz",
                Username = "Ehmedovbehruz1995@mail.ru",
                Password = "Bahruz1995"
            };
            context.Managers.AddOrUpdate(Manager1);
            context.SaveChanges();

            OrderItem OrderItem1 = new OrderItem
            {
                Created = DateTime.Now,
                CustomerId = Customer1.Id
            };
            context.OrderItems.AddOrUpdate(OrderItem1);
            context.SaveChanges();

            Order Order1 = new Order 
            {
                BookId = Book1.Id,
                OrderItemId=OrderItem1.Id,
                EndRentTime = DateTime.Now.AddDays(15)
            };
            context.Orders.AddOrUpdate(Order1);
            context.SaveChanges();
        }
    }
}