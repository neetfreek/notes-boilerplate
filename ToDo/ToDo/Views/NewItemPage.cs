using System;
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
            StackLayout stackLayout = ControlsMaker.NewStackLayout(VariablesGlobal.PADDING_DEFAULT, VariablesGlobal.SPACING_DEFAULT);
            entryText = ControlsMaker.NewEntry("", VariablesGlobal.TEXT_SIZE_SMALL);
            editorDescription = ControlsMaker.NewEditor("", VariablesGlobal.TEXT_SIZE_SMALL, 0);

            stackLayout.Children.Add(ControlsMaker.NewLabel(VariablesTexts.LABEL_HEADER_TEXT, VariablesGlobal.TEXT_SIZE_MEDIUM));
            stackLayout.Children.Add(entryText);
            stackLayout.Children.Add(ControlsMaker.NewLabel(VariablesTexts.LABEL_HEADER_DESCRIPTION, VariablesGlobal.TEXT_SIZE_MEDIUM));
            stackLayout.Children.Add(editorDescription);

            ToolbarItems.Add(ControlsMaker.NewToolbarItem(VariablesTexts.TOOLBAR_NAME_SAVE, Save_Clicked));
            Content = stackLayout;
        }

        async void Save_Clicked(object sender, EventArgs e)
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