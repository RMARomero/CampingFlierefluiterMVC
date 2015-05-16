using System.Collections.Generic;
using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Context
{
    public class PdfRepository : IPdfRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<PdfModel> Pdfs
        {
            get { return context.Pdfs; }
        }
    }
}