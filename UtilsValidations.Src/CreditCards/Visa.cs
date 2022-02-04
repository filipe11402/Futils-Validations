using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UtilsValidations.Src.CreditCards
{
    public class Visa : ValidationAttribute
    {
        public Visa()
        {
        }

        public override bool IsValid(object value)
        {
            return Regex.IsMatch(value.ToString(), @"^4[0-9]{12}(?:[0-9]{3})?$");
        }
    }
}
