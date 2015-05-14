namespace CampingFlierefluiter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class opHoopVanZegen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CampingSites",
                c => new
                    {
                        CampingSiteID = c.Int(nullable: false, identity: true),
                        SiteName = c.String(),
                        FieldName = c.String(),
                        SurfaceArea = c.Int(nullable: false),
                        isWifi = c.Boolean(nullable: false),
                        isWater = c.Boolean(nullable: false),
                        isSewer = c.Boolean(nullable: false),
                        SitePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SiteType = c.String(),
                    })
                .PrimaryKey(t => t.CampingSiteID);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        FacilityID = c.Int(nullable: false, identity: true),
                        FacilityPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FacilityType = c.String(),
                        Reservation_ReservationID = c.Int(),
                    })
                .PrimaryKey(t => t.FacilityID)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ReservationID)
                .Index(t => t.Reservation_ReservationID);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        ReservationID = c.Int(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Addres = c.String(),
                        City = c.String(),
                        Zipcode = c.String(),
                        ArrivalDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GuestID)
                .ForeignKey("dbo.Reservations", t => t.ReservationID, cascadeDelete: true)
                .Index(t => t.ReservationID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ReservationID = c.Int(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        pdfID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID);
            
            CreateTable(
                "dbo.PdfModels",
                c => new
                    {
                        pdfId = c.Int(nullable: false, identity: true),
                        pdfTitle = c.String(),
                        pdflocation = c.String(),
                    })
                .PrimaryKey(t => t.pdfId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        ArrivalDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        CampingSiteID = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        AmmountOfPeople = c.Int(nullable: false),
                        isInvoiced = c.Boolean(nullable: false),
                        isPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.CampingSites", t => t.CampingSiteID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CampingSiteID)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Zipcode = c.String(nullable: false, maxLength: 7),
                        Phonenumber = c.Long(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        IDCard = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
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
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reservations", "CampingSiteID", "dbo.CampingSites");
            DropForeignKey("dbo.Guests", "ReservationID", "dbo.Reservations");
            DropForeignKey("dbo.Facilities", "Reservation_ReservationID", "dbo.Reservations");
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropIndex("dbo.Reservations", new[] { "CampingSiteID" });
            DropIndex("dbo.Guests", new[] { "ReservationID" });
            DropIndex("dbo.Facilities", new[] { "Reservation_ReservationID" });
            DropTable("dbo.Seasons");
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.PdfModels");
            DropTable("dbo.Invoices");
            DropTable("dbo.Guests");
            DropTable("dbo.Facilities");
            DropTable("dbo.CampingSites");
        }
    }
}
