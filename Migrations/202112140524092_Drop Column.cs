namespace EbayParser.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DropColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("Sellers", "Stars");
        }

        public override void Down()
        {
        }
    }
}
