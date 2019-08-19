/**************************************************************************
* Creates, returns new control objects                                    *
***************************************************************************/
using System;
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ControlsMaker
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

        public static ToolbarItem NewToolbarItem(string text, EventHandler onClick)        
        //public static ToolbarItem NewToolbarItem(string text, System.Windows.Input.ICommand onClick)

        {
            ToolbarItem toolbarItem = new ToolbarItem
            {
                Text = text,
            };
            toolbarItem.Clicked += onClick;

            return toolbarItem;
        }
    }
}