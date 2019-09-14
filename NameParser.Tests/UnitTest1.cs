using Xunit;
namespace NameParser.Tests
{
    public class NameParsingTests
    {
        [Fact]
        public void FirstAndLastNameShouldBeParsedAccurately()
        {
            //Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }

        [Fact]
        public void ThreePartNamesShouldBeParsedAccurately()
        {
            var name = "Martin zachariah Cross";
            var parser = new Parser();

            var result = parser.ParseName(name);

            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }
    }
}
