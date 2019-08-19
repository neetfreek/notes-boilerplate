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

            StackLayout stackLayout = ControlsMarker.NewStackLayout(GlobalVariables.PADDING_DEFAULT, GlobalVariables.SPACING_DEFAULT);

            stackLayout.Children.Add(ControlsMarker.NewLabel("Text:", GlobalVariables.TEXT_SIZE_MEDIUM));
            stackLayout.Children.Add(ControlsMarker.NewLabel(viewModel.Item.Text, GlobalVariables.TEXT_SIZE_SMALL));
            stackLayout.Children.Add(ControlsMarker.NewLabel("Description:", GlobalVariables.TEXT_SIZE_MEDIUM));
            stackLayout.Children.Add(ControlsMarker.NewLabel(viewModel.Item.Description, GlobalVariables.TEXT_SIZE_SMALL));

            Content = stackLayout;
        }
    }
}