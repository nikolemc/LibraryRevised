namespace LibraryRevised.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        YearPublished = c.Int(nullable: false),
                        Genre = c.String(),
                        IsCheckedOut = c.Boolean(nullable: false),
                        LastCheckedOutDate = c.DateTime(),
                        DueBackDate = c.DateTime(),
                        ResponseMessage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Libraries");
        }
    }
}
