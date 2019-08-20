/****************************************************************************************
* Creates, returns new Layout collections (Layout<T>) derived class                     *
*   objects like Grids, StackLayouts                                                    *
* These objects have undefined behaviours and can contain multiple View                 *
*   child objects.                                                                      *
* https://docs.microsoft.com/en-us/dotnet/api/Xamarin.Forms.Layout-1?view=xamarin-forms *
*****************************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class LayoutCollectionMaker
    {
        public static StackLayout NewStackLayout(double padding = VariablesGlobal.PADDING_DEFAULT, double spacing = VariablesGlobal.SPACING_DEFAULT)
        {
            StackLayout stackLayout = new StackLayout
            {
                Spacing = spacing,
                Padding = padding,
            };

            return stackLayout;
        }
    }
}