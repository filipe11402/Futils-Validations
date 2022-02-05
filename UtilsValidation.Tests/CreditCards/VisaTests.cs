using UtilsValidations.Src.CreditCards;
using Xunit;

namespace UtilsValidation.Tests.CreditCards
{
    public class VisaTests
    {
        [Theory]
        [InlineData("4012888888881881")]
        [InlineData("4977949494949497")]
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


        [Theory]
        [InlineData("4012 8888 8888 1881")]
        [InlineData("4977 9494 9494 9497")]
        [InlineData("4111 1111 1111 1111")]
        [InlineData("4002 6900 0000 0008")]
        public void IsValid_VisaCardNumberWithWhiteSpaces_ReturnsTrue(string input)
        {
            //Arrange
            var visaValidation = new Visa();

            //Act
            var result = visaValidation.IsValid(input);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("3852 0000 0232 337")]
        [InlineData("3530 1113 3330 0000")]
        [InlineData("6011 1111 1111 1117")]
        [InlineData("3566 0020 2036 0505")]
        public void IsValid_VisaCardNumberWithWhiteSpaces_ReturnsFalse(string input)
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
