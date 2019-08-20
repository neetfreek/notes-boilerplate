/****************************************************************************************
* Creates, returns new MenuItem class derived objects, specifically                     *
*   ToolbarItem objects                                                                 *
* These objects are used to present menu items and associate them with                  *
*   commands.                                                                           *
* https://docs.microsoft.com/en-us/dotnet/api/Xamarin.Forms.MenuItem?view=xamarin-forms *
*****************************************************************************************/
using System;
using Xamarin.Forms;


namespace ToDo.Makers
{
    public static class MenuItemMaker
    {
        public static ToolbarItem NewToolbarItem(EventHandler onClick, string text = "", string iconImageSource = "")
        {
            ToolbarItem toolbarItem = new ToolbarItem
            {
                Text = text,
            };
            toolbarItem.Clicked += onClick;
            toolbarItem.IconImageSource = iconImageSource;

            return toolbarItem;
        }
    }
}