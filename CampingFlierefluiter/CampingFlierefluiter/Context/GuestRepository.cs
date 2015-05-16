using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;
using System.Collections.Generic;

namespace CampingFlierefluiter.Context
{
    public class GuestRepository : IGuestRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<Guest> Guests
        {
            get { return context.Guests; }
        }
    }
}