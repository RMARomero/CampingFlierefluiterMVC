using System.Collections.Generic;
using CampingFlierefluiter.Abstract;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Context
{
    public class UserRepository : IUserRepository
    {
        private DataContext context = new DataContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}