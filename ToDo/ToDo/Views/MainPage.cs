using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using ToDo.Makers;

namespace ToDo.Views
{
    public class MainPage: TabbedPage
    {
        public MainPage()
        {
            Children.Add(PagesMaker.NewNavigationpage(new ItemsPage(), "Browse", "icon_info.png"));
            Children.Add(PagesMaker.NewNavigationpage(new AboutPage(), "About", "icon_menu"));
        }
    }
}