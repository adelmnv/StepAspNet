namespace StepAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 15),
                        Description = c.String(nullable: false, maxLength: 100),
                        Duration = c.Int(nullable: false),
                        TeamNum = c.String(nullable: false),
                        PlayerAge = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Company = c.String(nullable: false, maxLength: 15),
                        Raiting = c.Double(nullable: false),
                        FearLevel = c.Int(nullable: false),
                        DifficultyLevel = c.Int(nullable: false),
                        LogoImg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quests");
        }
    }
}
