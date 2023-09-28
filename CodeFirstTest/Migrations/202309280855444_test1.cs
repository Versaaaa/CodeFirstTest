namespace CodeFirstTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
            AddColumn("dbo.Posts", "AuthorName", c => c.String());
            AddColumn("dbo.Posts", "Author_Name", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Posts", "Author_Name");
            AddForeignKey("dbo.Posts", "Author_Name", "dbo.Authors", "Name");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Name", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "Author_Name" });
            DropColumn("dbo.Posts", "Author_Name");
            DropColumn("dbo.Posts", "AuthorName");
            DropTable("dbo.Authors");
        }
    }
}
