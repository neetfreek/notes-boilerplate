﻿using System;
using ToDo.Models;
using Xamarin.Forms;
using ToDo.Makers;

namespace ToDo.Views
{
    class NewItemPage : ContentPage
    {
        private Entry entryName = new Entry();
        private Editor editorText = new Editor();
        

        public NewItemPage()
        {
            PageLayout();
        }


        // Set up NewItemPage UI layout
        private void PageLayout()
        {
            Title = VariablesTexts.TOOLBAR_NAME_ADD;

            StackLayout stackLayout = LayoutMaker.NewStackLayout(new Thickness(0, 0, 0, 0));
            entryName = InputViewMaker.NewEntry();
            editorText = InputViewMaker.NewEditor();

            stackLayout.Children.Add(ViewMaker.NewLabelString(VariablesTexts.LABEL_ITEM_NAME, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(entryName);
            stackLayout.Children.Add(ViewMaker.NewLabelString(VariablesTexts.LABEL_ITEM_TEXT, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(editorText);

            ToolbarItems.Add(MenuItemMaker.NewToolbarItem(Save_Clicked, VariablesTexts.TOOLBAR_NAME_SAVE));
            Content = stackLayout;
        }

        // EvenHandler for TOOLBAR_NAME_SAVE object clicks, instantiate new Item object, send MESSAGE_ADD_ITEM message, Pop page away to display MainPage view
        private async void Save_Clicked(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Name = entryName.Text,
                Text = editorText.Text,
            };

            MessagingCenter.Send(this, VariablesTexts.MESSAGE_ADD_ITEM, item);

            await Navigation.PopModalAsync();
        }
    }
}