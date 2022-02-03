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
        public void IsValid_MasterCardNumber_ReturnsTrue(object input) 
        {
            //Arrange
            var validationContext = new ValidationContext(input);

            //Act
            var masterCardAnotation = new MasterCard();
            var validationResult = masterCardAnotation.GetValidationResult(input, validationContext);

            //Assert
            Assert.True(Validator.TryValidateObject(input, validationContext, new List<ValidationResult> { validationResult }));
        }

        [Theory]
        [InlineData("378282246310005")]
        public void IsValid_MasterCardNumber_ReturnsFalse(object input)
        {
            //Arrange
            var validationContext = new ValidationContext(input);

            //Act
            var masterCardAnotation = new MasterCard();
            var validationResult = masterCardAnotation.GetValidationResult(input, validationContext);

            //Assert
            Assert.False(Validator.TryValidateObject(input, validationContext, new List<ValidationResult> { validationResult }));
        }
    }
}
