using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CampingFlierefluiter.Models
{
    public class PdfModel
    {
        [Key]
        public int pdfId { get; set; }

        public string pdfTitle { get; set; }

        public string pdflocation { get; set; }
    }
}