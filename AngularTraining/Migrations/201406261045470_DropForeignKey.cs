namespace AngularStart.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DropForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Brands", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Brands", new[] { "CategoryId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Brands", "CategoryId");
            AddForeignKey("dbo.Brands", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
