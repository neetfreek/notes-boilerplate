/**************************************************************************
* Creates, returns new control objects                                    *
***************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ControlsMarker
    {
        public static Entry NewEditor(string text, double fontSize, double margin)
        {
            Entry entry = new Entry
            {
                Text = text,
                FontSize = fontSize,
                Margin = margin,
            };

            return entry;
        }

        public static Entry NewEntry(string text, double fontSize)
        {
            Entry entry = new Entry
            {
                Text = text,
                FontSize = fontSize,
            };

            return entry;
        }

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