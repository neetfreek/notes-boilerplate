/**************************************************************************
* Handles conversion of Item objects to JSON string format and vice-versa *
***************************************************************************/
using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using ToDo.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ToDo.Services
{
    public static class ItemSerialization
    {
        // Write parameter ObservableCollection<Item> to NAME_FOLDER_DATA/NAME_FILE_DATA local storage in JSON string format
        public async static Task WriteAllData(ObservableCollection<Item> items)
        {
            string dataFinal = ItemsToString(items);
            await DataStorage.WriteToFileAsync(VariablesGlobal.NAME_FILE_DATA, dataFinal);
        }

        // Return parameter string local storage JSON string contents converted to List<Item>
        public async static Task<List<Item>> ReadAllData(string fileName)
        {
            string itemsString = await DataStorage.ReadFromFileAsync(fileName);
            List<Item> items =  StringsToItems(itemsString);

            return StringsToItems(itemsString);
        }


        // Return List<Item> converted from string argument
        private static List<Item> StringsToItems(string itemsString)
        {
            string itemsAll = itemsString;
            List<string> listItemsString = new List<string>();
            int itemsAllLength = itemsAll.Length;
            List<Item> items = new List<Item>();

            while (itemsAllLength > 0)
            {
                int positionEndLine = itemsAll.IndexOf("\n");
                listItemsString.Add(itemsAll.Substring(0, positionEndLine));
                items.Add(StringToItem(itemsAll.Substring(0, positionEndLine)));
                itemsAll = itemsAll.Remove(0, (itemsAll.Substring(0, positionEndLine).Length) + 1);
                itemsAllLength = itemsAll.Length;
            }

            return items;
        }

        // Return string converted from ObservableCollection<Item> argument
        private static string ItemsToString(ObservableCollection<Item> items)
        {
            string itemsString = "";

            foreach (Item item in items)
            {
                itemsString += ItemToString(item) + Environment.NewLine;
            }

            return itemsString;
        }

        // Return string converted from Item item argument
        private static string ItemToString(Item item)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Item));
            serializer.WriteObject(stream, item);
            
            byte[] itemJson = stream.ToArray();
            stream.Close();
            string itemString = Encoding.UTF8.GetString(itemJson, 0, itemJson.Length);

            return itemString;
        }

        // Return Item converted from string argument
        private static Item StringToItem(string itemString)
        {
            Item item = new Item();
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(itemString));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(item.GetType());

            return serializer.ReadObject(stream) as Item;
        }
    }
}