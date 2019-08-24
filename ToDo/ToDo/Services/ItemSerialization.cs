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
        public async static void WriteAllData(ObservableCollection<Item> items)
        public async static Task WriteAllData(ObservableCollection<Item> items)
        {
            string dataFinal = ItemsToString(items);
            await DataStorage.WriteToFileAsync(VariablesGlobal.NAME_FILE_DATA, dataFinal);
        }

        public async static Task<ObservableCollection<Item>> ReadAllData(string fileName)
        public async static Task<List<Item>> ReadAllData(string fileName)
        {
            string itemsString = await DataStorage.ReadFromFileAsync(fileName);
            List<Item> items =  StringsToItems(itemsString);

            return StringsToItems(itemsString);
        }

        public static ObservableCollection<Item> StringsToItems(string itemsString)
        private static List<Item> StringsToItems(string itemsString)
        {
            string itemsAll = itemsString;
            List<string> listItemsString = new List<string>();
            int itemsAllLength = itemsAll.Length;
            ObservableCollection<Item> items = new ObservableCollection<Item>();
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


        private static string ItemsToString(ObservableCollection<Item> items)
        {
            string dataFinal = "";
            string itemsString = "";

            foreach (Item item in items)
            {
                dataFinal += ItemToString(item) + Environment.NewLine;
                itemsString += ItemToString(item) + Environment.NewLine;
            }

            return dataFinal;
            return itemsString;
        }

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

        private static Item StringToItem(string itemString)
        {
            Item item = new Item();
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(itemString));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(item.GetType());

            return serializer.ReadObject(stream) as Item;
        }
    }
}