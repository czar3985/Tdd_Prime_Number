using FluentAssertions;
using Tdd_Prime_Number;
using Xunit;

namespace Tdd_Prime_Number_Tests
{
    public class PrimeNumberTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(491)]
        public void Given_a_prime_number_Then_IsPrime_is_true(int input)
        {
            // Arrange
            var sut = new PrimeNumberChecker();

            // Act
            var result = sut.IsPrime(input);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(334)]
        public void Given_a_non_prime_number_Then_IsPrime_is_false(int input)
        {
            // Arrange
            var sut = new PrimeNumberChecker();

            // Act
            var result = sut.IsPrime(input);

            // Assert
            result.Should().BeFalse();
        }
    }
}
