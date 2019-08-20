using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToDo.ViewModels;

using ToDo.Makers;

namespace ToDo.Views
{
    public class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            ContentPage pageTitle = new ContentPage()
            {
                Title = viewModel.Title,
            };

            StackLayout stackLayout = LayoutCollectionMaker.NewStackLayout(VariablesGlobal.PADDING_DEFAULT, VariablesGlobal.SPACING_DEFAULT);

            stackLayout.Children.Add(ViewMaker.NewLabel(viewModel.Item.Text, VariablesGlobal.TEXT_SIZE_SMALL));
            stackLayout.Children.Add(ViewMaker.NewLabel(viewModel.Item.Description, VariablesGlobal.TEXT_SIZE_SMALL));
            stackLayout.Children.Add(ViewMaker.NewLabel(VariablesTexts.LABEL_HEADER_TEXT, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(ViewMaker.NewLabel(VariablesTexts.LABEL_HEADER_DESCRIPTION, VariablesGlobal.TEXT_SIZE_LARGE));

            Content = stackLayout;
        }
    }
}