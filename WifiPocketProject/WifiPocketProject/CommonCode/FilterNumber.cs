using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiPocketProject.CommonCode
{
    public static class FilterNumber
    {
        public static string FormatPhoneNumber(string inputNumber)
        {
            if (string.IsNullOrWhiteSpace(inputNumber))
                return string.Empty;

            // Remove all non-numeric characters except '+'
            string cleanedNumber = new string(inputNumber.Where(c => char.IsDigit(c) || c == '+').ToArray());

            // Ensure correct format
            if (cleanedNumber.StartsWith("+92") && cleanedNumber.Length == 13)
            {
                return cleanedNumber; // Already correct
            }
            else if (cleanedNumber.StartsWith("92") && cleanedNumber.Length == 12)
            {
                return "+" + cleanedNumber; // Convert 92XXXXXXXXXX → +92XXXXXXXXXX
            }
            else if (cleanedNumber.StartsWith("03") && cleanedNumber.Length == 11)
            {
                return "+92" + cleanedNumber.Substring(1); // Convert 03XXXXXXXXX → +923XXXXXXXXX
            }
            else if (cleanedNumber.StartsWith("3") && cleanedNumber.Length == 10)
            {
                return "+92" + cleanedNumber; // Convert 3XXXXXXXXX → +923XXXXXXXXX
            }

            return string.Empty; // Invalid format
        }


    }

}
