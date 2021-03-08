namespace FinalChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBottle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WaterBottles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Oz = c.Int(nullable: false),
                        Color = c.String(),
                        Brand = c.String(),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WaterBottles");
        }
    }
}
