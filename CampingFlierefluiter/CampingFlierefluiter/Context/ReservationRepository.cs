using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;
using System.Collections.Generic;

namespace CampingFlierefluiter.Context
{
    public class ReservationRepository : IReservationRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<Reservation> Reservations
        {
            get { return context.Reservations; }
        }
    }
}