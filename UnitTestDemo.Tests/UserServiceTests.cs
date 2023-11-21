using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Features.Users;
using UnitTestDemo.Tests.Fixtures;

namespace UnitTestDemo.Tests
{
    public class UserServiceTests
    {
        private IUserService userService;

        [Fact]
        public void GetUpperUserName_UserValid_UpperName()
        {
            // Arrange
            IUserRepository userRepository = new UserRepositoryFixture();
            userService = new UserService(userRepository);

            // Act
            var result = userService.GetUpperUserName(1);

            // Assert
            Assert.Equal("JONH", result);
        }
    }
}
