namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryDetailColumnInCategoriesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "CategoryDetail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryDetail", c => c.String());
        }
    }
}
