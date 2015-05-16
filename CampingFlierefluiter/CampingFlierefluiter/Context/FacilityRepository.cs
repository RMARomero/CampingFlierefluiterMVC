using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;
using System.Collections.Generic;

namespace CampingFlierefluiter.Context
{
    public class FacilityRepository : IFacilityRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<Facility> Facilities
        {
            get { return context.Facilities; }
        }
    }
}