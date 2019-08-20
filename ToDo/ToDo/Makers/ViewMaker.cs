﻿/************************************************************************
* Creates, returns new View (base class for Layout class) class derived * 
*   objects like Buttons, Labels.                                       *
* These objects are used to place layouts and controls on the screen.   *
*************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ViewMaker
    {
        public static Label NewLabel(string text, double fontSize)
        {
            Label label = new Label
            {
                Text = text,
                FontSize = fontSize,
            };

            return label;
        }
    }
}