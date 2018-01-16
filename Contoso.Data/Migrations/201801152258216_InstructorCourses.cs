namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstructorCourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Courses_Id = c.Int(),
                        Instructor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Courses_Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id)
                .Index(t => t.Courses_Id)
                .Index(t => t.Instructor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InstructorCourses", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.InstructorCourses", "Courses_Id", "dbo.Courses");
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_Id" });
            DropIndex("dbo.InstructorCourses", new[] { "Courses_Id" });
            DropTable("dbo.InstructorCourses");
        }
    }
}
