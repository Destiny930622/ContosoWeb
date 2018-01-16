namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKInstructorDep : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "InstructorId", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "RowVersion", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "InstructorId");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor");
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            DropColumn("dbo.Departments", "RowVersion");
            DropColumn("dbo.Departments", "InstructorId");
        }
    }
}
