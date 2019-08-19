/**************************************************************************
* Creates, returns new control objects                                    *
***************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ControlsMarker
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

        public static StackLayout NewStackLayout(double padding, double spacing)
        {
            StackLayout stackLayout = new StackLayout
            {
                Spacing = spacing,
                Padding = padding,
            };

            return stackLayout;
        }
    }
}