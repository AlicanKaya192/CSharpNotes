namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCustomerSurnameToCustomerTitleInCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTitle", c => c.String());
            DropColumn("dbo.Customers", "CustomerSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerSurname", c => c.String());
            DropColumn("dbo.Customers", "CustomerTitle");
        }
    }
}
