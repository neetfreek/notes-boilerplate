/************************************************************************
* Creates, returns new Layout collections (Layout<T>) derived class     *
*   objects like Grids, StackLayouts                                    *
* These objects have undefined behaviours and can contain multiple View *
*   child objects.                                                      *
*************************************************************************/
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class LayoutCollectionMaker
    {
        public static StackLayout NewStackLayout(double padding, double spacing)
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