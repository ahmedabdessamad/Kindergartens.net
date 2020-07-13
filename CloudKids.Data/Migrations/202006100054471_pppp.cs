namespace CloudKids.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pppp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReunionPrives", "DateRdvP", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReunionPrives", "DateRdvP", c => c.String());
        }
    }
}
