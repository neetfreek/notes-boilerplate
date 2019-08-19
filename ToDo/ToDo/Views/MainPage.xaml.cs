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

            NavigationPage pageAbout = new NavigationPage(new AboutPage());
            pageAbout.Title = "About";

            Children.Add(pageItems);
            Children.Add(pageAbout);
        }
    }
}