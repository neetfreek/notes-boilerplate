/**************************************************************************
* Contains methods for validating various strings e.g. colour hex codes   *
***************************************************************************/
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace ToDo
{
    public static class Validation
    {
        public static Color ValidateHexCode(string hexCode)
        {
            string hexCodeConsidered = hexCode;
            Color colorConverted = Color.Default;

            if (hexCodeConsidered.Length == 7 && hexCodeConsidered[0] == '#' && Regex.IsMatch(hexCodeConsidered.Substring(1, hexCodeConsidered.Length-1), @"^[a-zA-Z0-9]+$"))
            {
                colorConverted = Color.FromHex(hexCodeConsidered);
            }

            return colorConverted;
        }
    }
}