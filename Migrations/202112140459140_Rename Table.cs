namespace EbayParser.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameTable : DbMigration
    {
        public override void Up()
        {


            RenameTable("Smartphones", "Product");

        }

        public override void Down()
        {
            RenameTable("Product", "Smartphones");
        }
    }
}
