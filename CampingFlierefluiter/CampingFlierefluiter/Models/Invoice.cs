using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CampingFlierefluiter.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        public User User { get; set; }
        public Reservation Reservation { get; set; }

        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        public decimal Price { get; set; }
        public int PdfID { get; set; }
    }
}