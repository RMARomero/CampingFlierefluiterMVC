using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    public interface ISeasonRepository
    {
        IEnumerable<Season> Seasons { get; }
    }
}
