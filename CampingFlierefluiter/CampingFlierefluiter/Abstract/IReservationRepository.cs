using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> Reservations { get; }
    }
}
