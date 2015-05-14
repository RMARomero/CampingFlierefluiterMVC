using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CampingFlierefluiter.Models
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; }

        public string SeasonName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public decimal PricePerNight { get; set; }
    }
}