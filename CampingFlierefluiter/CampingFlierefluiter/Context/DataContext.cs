using System.Collections.Generic;
using System.Data.Entity;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Context
{
    public class DataContext : DbContext
    {
        //public DataContext()
            //: base("name=DataContext")
        //{
        //}

        //private DataContext db = new DataContext();
        public DbSet<CampingSite> CampingSites { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PdfModel> Pdfs { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<User> Users { get; set; }
    }
}