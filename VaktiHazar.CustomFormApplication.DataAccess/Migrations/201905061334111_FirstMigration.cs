namespace VaktiHazar.CustomFormApplication.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormElements",
                c => new
                    {
                        FormElementId = c.Int(nullable: false, identity: true),
                        FormId = c.Int(nullable: false),
                        IsRequired8 = c.Boolean(nullable: false),
                        FormElementName = c.String(),
                        FormElementDataType = c.String(),
                    })
                .PrimaryKey(t => t.FormElementId)
                .ForeignKey("dbo.Forms", t => t.FormId, cascadeDelete: true)
                .Index(t => t.FormId);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        FormName = c.String(),
                        FormDescription = c.String(),
                        FormCreatedDate = c.DateTime(nullable: false),
                        FormCreatedUser = c.Int(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.FormId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Name = c.String(),
                        Lastname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormElements", "FormId", "dbo.Forms");
            DropForeignKey("dbo.Forms", "User_UserId", "dbo.Users");
            DropIndex("dbo.Forms", new[] { "User_UserId" });
            DropIndex("dbo.FormElements", new[] { "FormId" });
            DropTable("dbo.Users");
            DropTable("dbo.Forms");
            DropTable("dbo.FormElements");
        }
    }
}
