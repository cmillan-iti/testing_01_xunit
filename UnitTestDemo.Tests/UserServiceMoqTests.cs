using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Features.Users;

namespace UnitTestDemo.Tests
{
    public class UserServiceMoqTests
    {
        private IUserService userService;
        private Mock<IUserRepository> userRepository;

        [Fact]
        public void GetUpperUserName_UserValidWithMoq_UpperName()
        {
            // Arrange
            userRepository = new Mock<IUserRepository>();
            var users = new List<User>() { new User() { Name = "Jonh", Id = 1 } }.AsQueryable();
            userRepository.Setup(x => x.GetUsers()).Returns(users);

            // Act
            userService = new UserService(userRepository.Object);

            var userName = userService.GetUpperUserName(1);

            // Assert
            Assert.Equal("JONH", userName);

        }

        [Fact]
        public void GetUpperUserName_UserNotExist_StringEmpty()
        {
            // Arrange
            userRepository = new Mock<IUserRepository>();
            var users = new List<User>().AsQueryable();
            userRepository.Setup(x => x.GetUsers()).Returns(users);

            // Act
            userService = new UserService(userRepository.Object);

            var userName = userService.GetUpperUserName(1);

            // Assert
            Assert.Equal(string.Empty, userName);

        }
    }
}
