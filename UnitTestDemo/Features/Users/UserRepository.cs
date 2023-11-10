namespace UnitTestDemo.Features.Users
{
    public class UserRepository : IUserRepository
    {
        public IQueryable<User> GetUsers()
        {
            using(var context = new UnitTestDbContext())
            {
                return context.Users;
            }
        }
    }
}
