/********************************************************************************************
* Creates, returns new ItemsView<TVisual> class derived objects, namely ListViews           *                                             
* These objects are used display collections of data as a vertical list.                    *
* https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.itemsview-1?view=xamarin-forms  *
*********************************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class ItemsViewMaker
    {
        public static ListView NewListView(DataTemplate dataTemplate)
        {
            ListView listView = new ListView() { ItemTemplate = dataTemplate };

            return listView;
        }
    }
}