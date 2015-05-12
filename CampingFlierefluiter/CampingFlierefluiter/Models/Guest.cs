using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CampingFlierefluiter.Models
{
    public class Guest
    {
        [Required]
        public int GuestID { get; set; }

        public int ReservationID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}