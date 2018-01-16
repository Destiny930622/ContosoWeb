namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        EnrollmentDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Departments", "StartDate", c => c.DateTime());
            DropColumn("dbo.Departments", "StartTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "StartTime", c => c.DateTime());
            DropForeignKey("dbo.Student", "Id", "dbo.People");
            DropIndex("dbo.Student", new[] { "Id" });
            DropColumn("dbo.Departments", "StartDate");
            DropTable("dbo.Student");
        }
    }
}
