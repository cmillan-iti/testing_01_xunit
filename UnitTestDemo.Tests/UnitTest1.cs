using UnitTestDemo.Controllers;
using Xunit.Categories;

namespace UnitTestDemo.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {

        }

        [Fact]
        public void Suma_Excepction()
        {
            Assert.Throws<DivideByZeroException>(() => new DemoController(null).Division(1, 0));
        }

        [Fact]
        public void Suma_NumerosValidos_SumaCorrecta()
        {
            // Arrange
            var x = 1;
            var y = 2;
            var controller = new DemoController(null);

            // Act
            var actual = controller.Suma(x, y);

            // Assert
            Assert.Equal(3, actual);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void Suma_MultiplesNumerosValidos_SumaCorrecta(int x, int y, int resultado)
        {
            
             
            // Arrange            
            var controller = new DemoController(null);

            // Act
            var actual = controller.Suma(x, y);

            // Assert
            Assert.Equal(resultado, actual);
        }

        [Category("Grupo 1")]
        [Fact]
        public void Test1()
        {
            
        }

        [Category("Grupo 2")]
        [Fact]
        public void Test2()
        {

        }

        [Category("Grupo 2")]
        [Fact]
        public void Test3()
        {

        }
    }
}