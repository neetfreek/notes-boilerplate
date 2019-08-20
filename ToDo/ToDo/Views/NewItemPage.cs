﻿using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Models;
using Xamarin.Forms;
using ToDo.Makers;

namespace ToDo.Views
{
    class NewItemPage : ContentPage
    {
        private Entry entryText = new Entry();
        private Editor editorDescription = new Editor();
        
        public NewItemPage()
        {
            Title = VariablesTexts.TOOLBAR_NAME_ADD;

            StackLayout stackLayout = LayoutMaker.NewStackLayout();
            entryText = InputViewMaker.NewEntry();
            editorDescription = InputViewMaker.NewEditor();

            stackLayout.Children.Add(ViewMaker.NewLabel(VariablesTexts.LABEL_HEADER_TEXT, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(entryText);
            stackLayout.Children.Add(ViewMaker.NewLabel(VariablesTexts.LABEL_HEADER_DESCRIPTION, VariablesGlobal.TEXT_SIZE_LARGE));
            stackLayout.Children.Add(editorDescription);

            ToolbarItems.Add(MenuItemMaker.NewToolbarItem(Save_Clicked, VariablesTexts.TOOLBAR_NAME_SAVE));
            Content = stackLayout;
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Text = entryText.Text,
                Description = editorDescription.Text,
            };

            MessagingCenter.Send(this, VariablesTexts.MESSAGE_ADDITEM, item);
            await Navigation.PopModalAsync();
        }
    }
}