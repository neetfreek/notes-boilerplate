using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ToDo.Makers;

namespace ToDo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            Children.Add(PagesMaker.NewNavigationpage(new ItemsPage(), "Browse", "icon_info.png"));
            Children.Add(PagesMaker.NewNavigationpage(new AboutPage(), "About", "icon_menu"));
        }
    }
}