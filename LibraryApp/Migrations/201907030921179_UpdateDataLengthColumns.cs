namespace LibraryApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataLengthColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Books", "Writter", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "Surname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Managers", "Surname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Books", "Writter", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
