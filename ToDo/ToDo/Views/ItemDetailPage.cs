using Xamarin.Forms;
using ToDo.ViewModels;

using ToDo.Makers;

namespace ToDo.Views
{
    public class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            PageLayout(viewModel);
        }


        private void PageLayout(ItemDetailViewModel viewModel)
        {
            Title = viewModel.Title;

            StackLayout stackLayout = LayoutMaker.NewStackLayout(new Thickness(0, 0, 0, 0));

            stackLayout.Children.Add(ViewMaker.NewLabelString(VariablesTexts.LABEL_HEADER_TEXT, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(ViewMaker.NewLabelString(viewModel.Item.Text));
            stackLayout.Children.Add(ViewMaker.NewLabelString(VariablesTexts.LABEL_HEADER_DESCRIPTION, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(ViewMaker.NewLabelString(viewModel.Item.Name));

            Content = stackLayout;
        }
    }
}