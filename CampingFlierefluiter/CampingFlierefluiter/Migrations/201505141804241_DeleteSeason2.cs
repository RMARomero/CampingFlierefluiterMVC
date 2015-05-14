namespace CampingFlierefluiter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSeason2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Seasons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonID = c.Int(nullable: false, identity: true),
                        SeasonName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PricePerNight = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SeasonID);
            
        }
    }
}
