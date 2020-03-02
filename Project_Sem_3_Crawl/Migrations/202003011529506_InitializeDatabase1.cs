namespace Project_Sem_3_Crawl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Sources");
            AddColumn("dbo.Sources", "SourceId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Sources", "Link", c => c.String());
            AddPrimaryKey("dbo.Sources", "SourceId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Sources");
            AlterColumn("dbo.Sources", "Link", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Sources", "SourceId");
            AddPrimaryKey("dbo.Sources", "Link");
        }
    }
}
