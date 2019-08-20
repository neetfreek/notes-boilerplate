using Xamarin.Forms;

using ToDo.ViewModels;
using ToDo.Makers;

namespace ToDo.Views
{
    public class MainPage: TabbedPage
    {
        public MainPage()
        {
            Children.Add(ElementMaker.NewNavigationpage(new ItemsPage(new ItemsViewModel()), VariablesTexts.PAGE_NAME_ITEMS, VariablesTexts.ICON_PATH_MENU));
            Children.Add(ElementMaker.NewNavigationpage(new AboutPage(), VariablesTexts.PAGE_NAME_ABOUT, VariablesTexts.ICON_PATH_INFO));
        }
    }
}