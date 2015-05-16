using System.Collections.Generic;
using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Context
{
    public class SeasonRepository : ISeasonRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<Season> Seasons
        {
            get { return context.Seasons; }
        }
    }
}