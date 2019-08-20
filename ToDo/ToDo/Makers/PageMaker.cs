/************************************************************************
* Creates, returns new Page class derived objects like NavigationPage   *
* These objects occupy the entire screen, and represent the top level   *
*   UI elements in applications.                                        *
*************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class PageMaker
    {
        public static NavigationPage NewNavigationpage(ContentPage pageToNavigateTo, string title, string iconImageSource)
        {
            var pageType = pageToNavigateTo.GetType();

            NavigationPage navigationPage = new NavigationPage(pageToNavigateTo)
            {
                Title = title,
                IconImageSource = iconImageSource,
            };

            return navigationPage;
        }
    }
}