using FluentAssertions;
using Tdd_Prime_Number;
using Xunit;

namespace Tdd_Prime_Number_Tests
{
    public class PrimeNumberTests
    {
        [Fact]
        public void Given_2_Then_Prime()
        {
            // Arrange
            var sut = new PrimeNumberChecker();

            // Act
            var result = sut.IsPrime();

            // Assert
            result.Should().BeTrue();
        }
    }
}
