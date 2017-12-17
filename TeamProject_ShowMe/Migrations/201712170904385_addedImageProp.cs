namespace TeamProject_ShowMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedImageProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shows", "ImageShow", c => c.String());
            AddColumn("dbo.Movies", "ImageMovie", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ImageMovie");
            DropColumn("dbo.Shows", "ImageShow");
        }
    }
}
