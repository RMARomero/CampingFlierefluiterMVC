using System.Collections.Generic;
using CampingFlierefluiter.Models;

namespace CampingFlierefluiter.Abstract
{
    interface IUserRepository
    {
        IEnumerable<User> Users { get; }
    }
}
