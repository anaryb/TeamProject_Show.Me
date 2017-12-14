namespace TeamProject_ShowMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addepisode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Episodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Season = c.Int(nullable: false),
                        Show_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shows", t => t.Show_Id)
                .Index(t => t.Show_Id);
            
            AddColumn("dbo.Movies", "Rating", c => c.Double(nullable: false));
            AddColumn("dbo.Movies", "Description", c => c.String());
            AddColumn("dbo.Shows", "Rating", c => c.Double(nullable: false));
            AddColumn("dbo.Shows", "Description", c => c.String());
            DropColumn("dbo.Movies", "Raiting");
            DropColumn("dbo.Movies", "Duration");
            DropColumn("dbo.Shows", "Raiting");
            DropColumn("dbo.Shows", "Season");
            DropColumn("dbo.Shows", "Episode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "Episode", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "Season", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "Raiting", c => c.Double(nullable: false));
            AddColumn("dbo.Movies", "Duration", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Raiting", c => c.Double(nullable: false));
            DropForeignKey("dbo.Episodes", "Show_Id", "dbo.Shows");
            DropIndex("dbo.Episodes", new[] { "Show_Id" });
            DropColumn("dbo.Shows", "Description");
            DropColumn("dbo.Shows", "Rating");
            DropColumn("dbo.Movies", "Description");
            DropColumn("dbo.Movies", "Rating");
            DropTable("dbo.Episodes");
        }
    }
}
