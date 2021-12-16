namespace EbayParser.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Fixdrop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "Stars", c => c.Int(nullable: false));
        }

        public override void Down()
        {

        }
    }
}
