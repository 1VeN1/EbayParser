namespace EbayParser.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DropColumnAgain : DbMigration
    {
        public override void Up()
        {
            DropColumn("Sellers", "Stars");
        }

        public override void Down()
        {
            AddColumn("dbo.Sellers", "Stars", c => c.Int(nullable: false));
        }
    }
}
