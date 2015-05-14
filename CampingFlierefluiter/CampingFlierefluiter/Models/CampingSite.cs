using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CampingFlierefluiter.Models
{
    public class CampingSite
    {
        [Key]
        public int CampingSiteID { get; set; }

        public string SiteName { get; set; }

        public string FieldName { get; set; }

        public int SurfaceArea { get; set; }

        public bool isWifi { get; set; }

        public bool isWater { get; set; }

        public bool isSewer { get; set; }

        public decimal SitePrice { get; set; }

        public string SiteType { get; set; }
    }
}