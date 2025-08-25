namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryDetailToCategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDetail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryDetail");
        }
    }
}
