using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Features.Users;

namespace UnitTestDemo.Tests.Fixtures
{
    public class UserRepositoryFixture : IUserRepository
    {
        public IQueryable<User> GetUsers()
        {
            return new List<User>() { new User() { Name = "Jonh", Id = 1 } }.AsQueryable();
        }
    }
}
