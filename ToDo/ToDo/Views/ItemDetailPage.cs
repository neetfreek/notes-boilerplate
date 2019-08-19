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

            StackLayout stackLayout = ControlsMarker.NewStackLayout(15, 20);

            stackLayout.Children.Add(ControlsMarker.NewLabel("Text:", 18));
            stackLayout.Children.Add(ControlsMarker.NewLabel(viewModel.Item.Text, 14));
            stackLayout.Children.Add(ControlsMarker.NewLabel("Description:", 18));
            stackLayout.Children.Add(ControlsMarker.NewLabel(viewModel.Item.Description, 14));

            Content = stackLayout;
        }
    }
}