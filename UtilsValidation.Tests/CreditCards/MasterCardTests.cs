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
    }
}
