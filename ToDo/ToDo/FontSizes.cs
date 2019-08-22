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
                case VariablesGlobal.TEXT_SIZE_TITLE:
                    namedSize = Device.GetNamedSize(NamedSize.Title, targetElement);
                    break;
                case VariablesGlobal.TEXT_SIZE_SUBTITLE:
                    namedSize = Device.GetNamedSize(NamedSize.Subtitle, targetElement);
                    break;
                case VariablesGlobal.TEXT_SIZE_HEADER:
                    namedSize = Device.GetNamedSize(NamedSize.Header, targetElement);
                    break;
                case VariablesGlobal.TEXT_SIZE_BODY:
                    namedSize = Device.GetNamedSize(NamedSize.Body, targetElement);
                    break;
                case VariablesGlobal.TEXT_SIZE_CAPTION:
                    namedSize = Device.GetNamedSize(NamedSize.Caption, targetElement);
                    break;
                default:
                    namedSize = Device.GetNamedSize(NamedSize.Default, targetElement);
                    break;
            }

            return namedSize;
        }
    }
}