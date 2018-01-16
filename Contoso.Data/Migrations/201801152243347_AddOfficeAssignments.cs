namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOfficeAssignments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "Id", "dbo.Instructor");
            DropIndex("dbo.OfficeAssignments", new[] { "Id" });
            DropTable("dbo.OfficeAssignments");
        }
    }
}
