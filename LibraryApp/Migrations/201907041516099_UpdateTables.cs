namespace LibraryApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            AddColumn("dbo.Books", "Writter", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "OrderItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Customers", "DateBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "CreateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "Surname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "Username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Orders", "OrderItemId");
            AddForeignKey("dbo.Orders", "OrderItemId", "dbo.OrderItems", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "CustomerId");
            DropColumn("dbo.Orders", "CustomerId");
            DropColumn("dbo.Orders", "StartRentTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "StartRentTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "CustomerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "OrderItemId", "dbo.OrderItems");
            DropForeignKey("dbo.OrderItems", "CustomerId", "dbo.Customers");
            DropIndex("dbo.OrderItems", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "OrderItemId" });
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Managers", "Username", c => c.String());
            AlterColumn("dbo.Managers", "Surname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Customers", "CreateAt");
            DropColumn("dbo.Customers", "DateBirth");
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Orders", "OrderItemId");
            DropColumn("dbo.Books", "Writter");
            DropTable("dbo.OrderItems");
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
