using System;
using Xunit;

namespace FloatingPointLibrary.Unit.Test
{
    public class FloatingPointValueTest
    {
        [Fact]
        public void Parse_ValidString_ReturnsKataFloat32RepresentationOfString()
        {
            //Arrange
            var validFloatString = "3.1415";

            //Act
            var kataFloatResult = KataFloat32.Parse(validFloatString);

            //Assert
            Assert.Equal(kataFloatResult._sign, 0);
            Assert.Equal(kataFloatResult._exponent, 0b10000000u);
            Assert.Equal(kataFloatResult._mantissa, 0b10010010000111001010110u);
        }
    }
}
