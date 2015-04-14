namespace HaterDate2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Profile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Profile_Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Age = c.Short(nullable: false),
                        AgeMinPref = c.Short(nullable: false),
                        AgeMaxPref = c.Short(nullable: false),
                        Gender = c.String(nullable: false),
                        GenderPref = c.String(nullable: false),
                        Bio = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Zipcode = c.Short(nullable: false),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hates", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Hates", new[] { "Profile_Id" });
            DropTable("dbo.Profiles");
            DropTable("dbo.Hates");
        }
    }
}
