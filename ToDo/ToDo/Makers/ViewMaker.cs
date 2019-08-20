/************************************************************************************
* Creates, returns new View (base class for Layout class) class derived             *
*   objects like Buttons, Labels.                                                   *
* These objects are used to place layouts and controls on the screen.               *
* https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.view?view=xamarin-forms *
*************************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ViewMaker
    {
        public static Label NewLabel(string text = "", double fontSize = VariablesGlobal.TEXT_SIZE_MEDIUM)
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