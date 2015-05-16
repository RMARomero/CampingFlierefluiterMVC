using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    public interface IGuestRepository
    {
        IEnumerable<Guest> Guests { get; }
    }
}
