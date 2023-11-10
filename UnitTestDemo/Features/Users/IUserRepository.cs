namespace UnitTestDemo.Features.Users
{
    public interface IUserRepository
    {
        IQueryable<User> GetUsers();
    }

    
}
