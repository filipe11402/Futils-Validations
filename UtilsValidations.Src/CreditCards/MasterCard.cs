using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UtilsValidations.Src.CreditCards
{
    public class MasterCard : ValidationAttribute
    {
        public MasterCard()
        {
        }

        public override bool IsValid(object value)
        {
            return Regex.IsMatch(value.ToString(), @"^5[1-5][0-9]{14}|^(222[1-9]|22[3-9]\\d|2[3-6]\\d{2}|27[0-1]\\d|2720)[0-9]{12}$");
        }
    }
}
