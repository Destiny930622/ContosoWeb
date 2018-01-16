namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJunTBPersonRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Person_id = c.Int(nullable: false),
                        Role_id = c.Int(nullable: false),
                        people_Id = c.Int(),
                        roles_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.people_Id)
                .ForeignKey("dbo.Roles", t => t.roles_Id)
                .Index(t => t.people_Id)
                .Index(t => t.roles_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonRoles", "roles_Id", "dbo.Roles");
            DropForeignKey("dbo.PersonRoles", "people_Id", "dbo.People");
            DropIndex("dbo.PersonRoles", new[] { "roles_Id" });
            DropIndex("dbo.PersonRoles", new[] { "people_Id" });
            DropTable("dbo.PersonRoles");
        }
    }
}
