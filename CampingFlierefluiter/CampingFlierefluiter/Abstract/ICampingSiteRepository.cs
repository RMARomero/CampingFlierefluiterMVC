using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    public interface ICampingSiteRepository
    {
        IEnumerable<CampingSite> CampingSites { get; } 
    }
}
