using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CampingFlierefluiter.Models
{
    public class Facility
    {
        [Key]
        public int FacilityID { get; set; }

        public decimal FacilityPrice { get; set; }

        public string FacilityType { get; set; }
    }
}