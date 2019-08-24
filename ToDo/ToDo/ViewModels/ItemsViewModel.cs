using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

using ToDo.Models;
using ToDo.Views;
using ToDo.Services;

namespace ToDo.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        // Call to populate Items collection from local storage NAME_FOLDER_DATA
        public Command LoadItemsCommand { get; set; }
        public ObservableCollection<Item> GetItems()
        {
            return Items;
        }

        // Items collection
        private ObservableCollection<Item> Items;


        public ItemsViewModel()
        {
            Title = VariablesTexts.PAGE_NAME_ITEMS;
            Items = new ObservableCollection<Item>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            // Subscribe message, add message payload (Item object) to items list
            MessagingCenter.Subscribe<NewItemPage, Item>(this, VariablesTexts.MESSAGE_ADD_ITEM, async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await ItemSerialization.WriteAllData(GetItems());

                await DataStore.AddItemAsync(newItem);
            });
        }
        

        // Populate Items collection from local storage NAME_FOLDER_DATA, send MESSAGE_LOADED_ITEMS_EXECUTED on completion
        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                IEnumerable<Item> itemsToAdd = await DataStore.GetItemsFromFileAsync(true);
                foreach (var item in itemsToAdd)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
                MessagingCenter.Send(this, VariablesTexts.MESSAGE_LOADED_ITEMS_EXECUTED);
            }
        }
    }
}