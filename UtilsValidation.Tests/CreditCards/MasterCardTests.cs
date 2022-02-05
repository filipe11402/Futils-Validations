using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UtilsValidations.Src.CreditCards;
using Xunit;

namespace UtilsValidation.Tests.CreditCards
{
    public class MasterCardTests
    {
        [Theory]
        [InlineData("5425233430109903")]
        [InlineData("2222420000001113")]
        [InlineData("2223000048410010")]
        public void IsValid_MasterCardNumber_ReturnsTrue(object input) 
        {
            //Arrange
            var masterCardValidation = new MasterCard();

            //Act
            var result = masterCardValidation.IsValid(input);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("378282246310005")]
        [InlineData("374245455400126")]
        [InlineData("6250941006528599")]
        [InlineData("6011000991300009")]
        public void IsValid_MasterCardNumber_ReturnsFalse(object input)
        {
            //Arrange
            var masterCardValidation = new MasterCard();

            //Act
            var result = masterCardValidation.IsValid(input);

            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("5425 2334 3010 9903")]
        [InlineData("2222 4200 0000 1113")]
        [InlineData("2223 0000 4841 0010")]
        public void IsValid_MasterCardNumberWithWhiteSpaces_ReturnsTrue(object input)
        {
            //Arrange
            var masterCardValidation = new MasterCard();

            //Act
            var result = masterCardValidation.IsValid(input);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("3782 8224 6310 005")]
        [InlineData("3742 4545 5400 126")]
        [InlineData("6250 9410 0652 8599")]
        [InlineData("6011 0009 9130 0009")]
        public void IsValid_MasterCardNumberWithWhiteSpace_ReturnsFalse(object input)
        {
            //Arrange
            var masterCardValidation = new MasterCard();

            //Act
            var result = masterCardValidation.IsValid(input);

            //Assert
            Assert.False(result);
        }
    }
}
