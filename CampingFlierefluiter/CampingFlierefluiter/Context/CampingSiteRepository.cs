using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;
using System.Collections.Generic;

namespace CampingFlierefluiter.Context
{
    public class CampingSiteRepository : ICampingSiteRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<CampingSite> CampingSites 
        {
            get { return context.CampingSites; }
        }
    }
}