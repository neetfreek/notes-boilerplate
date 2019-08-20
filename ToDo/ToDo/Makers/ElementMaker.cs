/************************************************************************************
* Creates, returns new Page class derived objects like NavigationPage               *
* These objects occupy the entire screen, and represent the top level               *
*   UI elements in applications.                                                    *
* https://docs.microsoft.com/en-us/dotnet/api/Xamarin.Forms.Page?view=xamarin-forms *
*************************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ElementMaker
    {
        public static ViewCell NewViewCell(View view)
        {
            ViewCell viewCell = new ViewCell()
            {
                View = view,
            };            

            return viewCell;
        }

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