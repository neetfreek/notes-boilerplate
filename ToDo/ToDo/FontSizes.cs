/****************************************************************
* Converts font size CONST string values to Device NamedSizes   *
*****************************************************************/
using System;
using Xamarin.Forms;

namespace ToDo
{
    public static class FontSizes
    {
        public static double DeviceNamedFontSize(string fontSize, Element targetElement)
        {
            double namedSize = 0;
            switch (fontSize)
            {
                case VariablesGlobal.TEXT_SIZE_SMALL:
                    namedSize = Device.GetNamedSize(NamedSize.Small, targetElement);
                    break;
                case VariablesGlobal.TEXT_SIZE_MEDIUM:
                    namedSize = Device.GetNamedSize(NamedSize.Medium, targetElement);
                    break;
                case VariablesGlobal.TEXT_SIZE_LARGE:
                    namedSize = Device.GetNamedSize(NamedSize.Large, targetElement);
                    break;
            }

            return namedSize;
        }
    }
}