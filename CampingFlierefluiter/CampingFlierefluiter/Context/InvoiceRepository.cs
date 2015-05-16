using System.Collections.Generic;
using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Context
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<Invoice> Invoices
        {
            get { return context.Invoices; }
        }
    }
}