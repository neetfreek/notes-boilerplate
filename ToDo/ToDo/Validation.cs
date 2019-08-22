/**************************************************************************
* Contains methods for validating various strings e.g. colour hex codes   *
***************************************************************************/
using System.Text.RegularExpressions;

namespace ToDo
{
    public static class Validation
    {
        public static bool HexCodeValid(string hexCode)
        {
            string hexCodeConsidered = hexCode;

            if (hexCodeConsidered.Length == 7 && hexCodeConsidered[0] == '#' && Regex.IsMatch(hexCodeConsidered.Substring(1, -1), @"^[a-zA-Z0-9]+$"))
            {
                return true;
            }

            return false;
        }
    }
}