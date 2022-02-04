using UtilsValidations.Src.CreditCards;
using Xunit;

namespace UtilsValidation.Tests.CreditCards
{
    public class VisaTests
    {
        [Theory]
        [InlineData("4012888888881881")]
        [InlineData("4012888888881881")]
        [InlineData("4111111111111111")]
        [InlineData("4002690000000008")]
        public void IsValid_VisaCardNumber_ReturnsTrue(string input) 
        {
            //Arrange
            var visaValidation = new Visa();

            //Act
            var result = visaValidation.IsValid(input);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("38520000023237")]
        [InlineData("3530111333300000")]
        [InlineData("6011111111111117")]
        [InlineData("3566002020360505")]
        public void IsValid_VisaCardNumber_ReturnsFalse(string input)
        {
            //Arrange
            var visaValidation = new Visa();

            //Act
            var result = visaValidation.IsValid(input);

            //Assert
            Assert.False(result);
        }
    }
}
