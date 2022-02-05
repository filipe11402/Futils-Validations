using System;

namespace UtilsValidations.Src.Extensions
{
    public static class StringFormattingExtensions
    {
        public static string GetNoWhiteSpaceString(this string input)
        {
            if (input.Contains(" "))
            {
                var splittedString = input.Split(" ");

                return String.Concat(splittedString);
            }

            return input;
        }
    }
}
