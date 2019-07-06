namespace LibraryApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatabaseCustomerItem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderItems", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.OrderItems", new[] { "Customer_Id" });
            DropColumn("dbo.OrderItems", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Customer_Id", c => c.Int());
            CreateIndex("dbo.OrderItems", "Customer_Id");
            AddForeignKey("dbo.OrderItems", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
