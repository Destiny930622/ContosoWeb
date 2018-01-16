namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKRolePeople : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PersonRoles", new[] { "people_Id" });
            DropIndex("dbo.PersonRoles", new[] { "roles_Id" });
            CreateIndex("dbo.PersonRoles", "People_Id");
            CreateIndex("dbo.PersonRoles", "Roles_Id");
            DropColumn("dbo.PersonRoles", "Person_id");
            DropColumn("dbo.PersonRoles", "Role_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonRoles", "Role_id", c => c.Int(nullable: false));
            AddColumn("dbo.PersonRoles", "Person_id", c => c.Int(nullable: false));
            DropIndex("dbo.PersonRoles", new[] { "Roles_Id" });
            DropIndex("dbo.PersonRoles", new[] { "People_Id" });
            CreateIndex("dbo.PersonRoles", "roles_Id");
            CreateIndex("dbo.PersonRoles", "people_Id");
        }
    }
}
