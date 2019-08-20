using System;
using Xamarin.Forms;

using ToDo.Models;
using ToDo.ViewModels;

using ToDo.Makers;

namespace ToDo.Views
{
    public class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage(ItemsViewModel viewModel)
        {
            Title = VariablesTexts.PAGE_NAME_ITEMS;

            this.viewModel = viewModel;

            ToolbarItems.Add(MenuItemMaker.NewToolbarItem(AddItem_Clicked, VariablesTexts.TOOLBAR_NAME_ADD, VariablesTexts.ICON_PATH_ADD));

            PopulatePage();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);

            PopulatePage();
        }

        private void PopulatePage()
        {
            StackLayout stackLayoutView = LayoutMaker.NewStackLayout();

            foreach (Item item in viewModel.Items)
            {
                Button button = new Button()
                {
                    Text = VariablesTexts.BUTTON_NAME_VIEW,
                    Command = new Command(() => {
                        Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
                    }),
                };
                StackLayout stackLayout = LayoutMaker.NewStackLayout();
                stackLayout.Children.Add(ViewMaker.NewLabel(VariablesTexts.LABEL_HEADER_TEXT));
                stackLayout.Children.Add(ViewMaker.NewLabel(item.Description));
                stackLayout.Children.Add(ViewMaker.NewLabel(VariablesTexts.LABEL_HEADER_DESCRIPTION));
                stackLayout.Children.Add(ViewMaker.NewLabel(item.Text));
                stackLayout.Children.Add(button);

                stackLayoutView.Children.Add(stackLayout);
            }
            Content = LayoutMaker.NewScrollView(stackLayoutView);
        }
    }
}