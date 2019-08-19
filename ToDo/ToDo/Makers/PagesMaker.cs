/**************************************************************************
* Creates, returns new page objects                                    *
***************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class PagesMaker
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