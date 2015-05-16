using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    public interface IPdfRepository
    {
        IEnumerable<PdfModel> Pdfs { get; }
    }
}
