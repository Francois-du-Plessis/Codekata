using System;
using Xunit;
using FloatingPointLibrary;

namespace FloatingPointLibrary.Unit.Test
{
    public class FloatingPointValueTest
    {
        [Fact]
        public void TryParse_ValidString_ReturnsKataFloat32RepresentationOfString()
        {
            //Arrange
            var validFloatString = "3.1415";

            //Act
            var hasParsed = KataFloat32.TryParse(validFloatString, out var kataFloatResult);

            //Assert
            Assert.Equal(0, kataFloatResult._sign);
            Assert.Equal(0b10000000u, kataFloatResult._exponent);
            Assert.Equal(0b10010010000111001010110u, kataFloatResult._mantissa);
        }

        [Fact]
        public void TryParse_ValidString_ReturnsTrue()
        {
            //Arrange
            var validFloatString = "3.1415";

            //Act
            var hasParsed = KataFloat32.TryParse(validFloatString, out var kataFloatResult);

            //Assert
            Assert.True(hasParsed);
        }

        [Theory]
        [InlineData("")]
        [InlineData("a3.1415")]
        [InlineData("3.14.15")]
        [InlineData("3.1415%")]
        [InlineData("3-1415")]
        [InlineData("ThreePointOneFour")]
        [InlineData((string)null)]
        public void TryParse_InvalidString_ReturnsFalse(string invalidFloat)
        {
            //Arrange

            //Act
            var hasParsed = KataFloat32.TryParse(invalidFloat, out var kataFloatResult);

            //Assert
            Assert.False(hasParsed);
        }
    }
}
