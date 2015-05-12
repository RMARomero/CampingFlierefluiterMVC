using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        public int CampingSiteID { get; set; }
        public CampingSite Site { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int AmmountOfPeople { get; set; }
        //list of guest
        public List<Facility> Facilities { get; set; }
        public int[] SelectedFacilities { get; set; }
        public bool isInvoiced { get; set; }
        public bool isPaid { get; set; }
        public int InvoiceID { get; set; }
    }
}