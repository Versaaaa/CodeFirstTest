namespace CodeFirstTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "AuthorName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "AuthorName", c => c.String());
        }
    }
}
