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
            var result = sut.IsPrime(2);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Given_3_Then_Prime()
        {
            // Arrange
            var sut = new PrimeNumberChecker();

            // Act
            var result = sut.IsPrime(3);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Given_4_Then_Not_Prime()
        {
            // Arrange
            var sut = new PrimeNumberChecker();

            // Act
            var result = sut.IsPrime(4);

            // Assert
            result.Should().BeFalse();
        }
    }
}
