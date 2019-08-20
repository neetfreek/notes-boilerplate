/************************************************************************
* Creates, returns new MenuItem class derived objects, specifically     *
*   ToolbarItem objects                                                 *
* These objects are used to present menu items and associate them with  *
*   commands.                                                           *
*************************************************************************/
using System;
using Xamarin.Forms;


namespace ToDo.Makers
{
    public static class MenuItemMaker
    {
        public static ToolbarItem NewToolbarItem(string text, EventHandler onClick)
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