namespace UnitTestDemo.Features.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string GetUpperUserName(int userId)
        {
            var user = userRepository.GetUsers().FirstOrDefault(x => x.Id == userId);

            return user == null ? string.Empty : user.Name.ToUpper();
        }
    }
}
