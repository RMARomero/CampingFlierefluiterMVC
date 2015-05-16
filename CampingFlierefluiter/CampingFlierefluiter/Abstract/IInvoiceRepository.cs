using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    interface IInvoiceRepository
    {
        IEnumerable<Invoice> Invoices { get; }
    }
}
