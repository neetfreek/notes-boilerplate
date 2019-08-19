using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            NavigationPage pageItems = new NavigationPage(new ItemsPage());
            pageItems.Title = "Browse";
            pageItems.IconImageSource = "icon_info.png";

            NavigationPage pageAbout = new NavigationPage(new AboutPage());
            pageAbout.Title = "About";
            pageAbout.IconImageSource = "icon_menu.png";

            Children.Add(pageItems);
            Children.Add(pageAbout);
        }
    }
}