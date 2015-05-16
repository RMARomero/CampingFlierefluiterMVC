using CampingFlierefluiter.Models;
using System.Collections.Generic;

namespace CampingFlierefluiter.Abstract
{
    public interface IFacilityRepository
    {
        IEnumerable<Facility> Facilities { get; }
    }
}
