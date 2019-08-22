/****************************************************************************************
* Creates, returns new Layout derived class objects like Layout<T>s and ScrollViews     *
* These objects have undefined behaviours and can contain multiple View                 *
*   child objects.                                                                      *
* https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.layout?view=xamarin-forms   *
*****************************************************************************************/
using System;
using Xamarin.Forms;

namespace ToDo.Makers
{
    public static class LayoutMaker
    {
        public static Grid NewGrid(int amountRows = 1, int amountColumns = 1)
        {
            Grid grid = new Grid() { };
            grid = AddGridRowsColumns(grid, amountRows, amountColumns);

            return grid;
        }
        private static Grid AddGridRowsColumns(Grid grid, int amountRows, int amountColumns)
        {
            Grid gridAdjusted = grid;
            int rowsToAdd = amountRows;
            int columnsToAdd = amountColumns;

            while (rowsToAdd > 0)
            {
                gridAdjusted.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                rowsToAdd--;
            }
            while (columnsToAdd > 0)
            {
                gridAdjusted.ColumnDefinitions.Add(new ColumnDefinition{ Width = GridLength.Auto });
                columnsToAdd--;
            }

            return gridAdjusted;
        }

        public static ScrollView NewScrollView(View view)
        {
            ScrollView scrollView = new ScrollView() { Content = view };

            return scrollView;
        }

        public static StackLayout NewStackLayout(double padding = VariablesGlobal.PADDING_DEFAULT, double spacing = VariablesGlobal.SPACING_DEFAULT, EventHandler onClick = null)
        {
            StackLayout stackLayout = new StackLayout
            {
                Spacing = spacing,
                Padding = padding,
                GestureRecognizers = { new TapGestureRecognizer(), },                                
            };

            return stackLayout;
        }
    }
}