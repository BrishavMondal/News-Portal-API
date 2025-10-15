namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CommentBy = c.String(maxLength: 128),
                        NewsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CommentBy)
                .Index(t => t.CommentBy)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        NewsBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.NewsBy)
                .Index(t => t.NewsBy);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Uname);
            
            DropTable("dbo.Employees");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Comments", "CommentBy", "dbo.Users");
            DropForeignKey("dbo.Comments", "NewsId", "dbo.News");
            DropForeignKey("dbo.News", "NewsBy", "dbo.Users");
            DropIndex("dbo.News", new[] { "NewsBy" });
            DropIndex("dbo.Comments", new[] { "NewsId" });
            DropIndex("dbo.Comments", new[] { "CommentBy" });
            DropTable("dbo.Users");
            DropTable("dbo.News");
            DropTable("dbo.Comments");
        }
    }
}
