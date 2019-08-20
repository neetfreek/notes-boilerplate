/********************************************************************************************
* Creates, returns new InputView class derived objects like Editor,                         *
*   Entry, SearchBar                                                                        *
* These objects are used to take keyboard input.                                            *
* https://docs.microsoft.com/en-us/dotnet/api/Xamarin.Forms.InputView?view=xamarin-forms    *
*********************************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class InputViewMaker
    {
        public static Editor NewEditor(string text, double fontSize, double margin)
        {
            Editor editor = new Editor
            {
                Text = text,
                FontSize = fontSize,
                Margin = margin,
            };

            return editor;
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
    }
}