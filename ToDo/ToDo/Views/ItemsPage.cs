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
            this.viewModel = viewModel;
            Title = viewModel.Title;
            ToolbarItems.Add(MenuItemMaker.NewToolbarItem(AddItem_Clicked, VariablesTexts.TOOLBAR_NAME_ADD, VariablesGlobal.IMAGE_ADD));

            // Update ItemsPage UI once ExecuteLoadItemsCommand Task complete
            MessagingCenter.Subscribe<ItemsViewModel>(this, VariablesTexts.MESSAGE_LOADED_ITEMS_EXECUTED, (sender) =>
            {
                PageLayout();
            });            
        }


        // Set up ItemsPage UI
        private void PageLayout()
        {
            StackLayout stackLayoutView = LayoutMaker.NewStackLayout(new Thickness(0, 0, 0, 0));

            foreach (Item item in viewModel.GetItems())
            {
                Button button = new Button()
                {
                    Text = VariablesTexts.BUTTON_NAME_VIEW,
                    Command = new Command(() => {
                        Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
                    }),
                };
                StackLayout stackLayout = LayoutMaker.NewStackLayout(new Thickness(0, 0, 0, 0));
                stackLayout.Children.Add(ViewMaker.NewLabelString(VariablesTexts.LABEL_HEADER_TEXT));
                stackLayout.Children.Add(ViewMaker.NewLabelString(item.Description));
                stackLayout.Children.Add(ViewMaker.NewLabelString(VariablesTexts.LABEL_HEADER_DESCRIPTION));
                stackLayout.Children.Add(ViewMaker.NewLabelString(item.Text));
                stackLayout.Children.Add(button);

                stackLayoutView.Children.Add(stackLayout);
            }
            Content = LayoutMaker.NewScrollView(stackLayoutView);
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.GetItems().Count == 0)
                viewModel.LoadItemsCommand.Execute(null);

            PageLayout();
        }
    }
}