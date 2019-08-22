using Xamarin.Forms;

using ToDo.ViewModels;
using ToDo.Makers;

namespace ToDo.Views
{
    public class MainPage: TabbedPage
    {
        public MainPage()
        {
            Children.Add(ElementMaker.NewNavigationpage(new ItemsPage(new ItemsViewModel()), VariablesTexts.PAGE_NAME_ITEMS, VariablesGlobal.IMAGE_MENU));
            Children.Add(ElementMaker.NewNavigationpage(new AboutPage(new AboutViewModel()), VariablesTexts.PAGE_NAME_ABOUT, VariablesGlobal.IMAGE_INFO));
        }
    }
}