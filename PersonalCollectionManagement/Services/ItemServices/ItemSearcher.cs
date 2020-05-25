using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services
{
    public static class ItemSearcher
    {
        private static Item SetItem(Item item)
        {
            ApplicationContext db = Database.db;
            item.Values = new List<string>();
            item.Values.AddRange(
                   db.Values.
                   Where(x => x.IdItem == item.Id).
                   Select(x => x.Information).ToList());

            item.Tags = new List<string>();
            item.Tags.AddRange(
                db.Tags.
                Where(x => x.IdItem == item.Id).
                 Select(x => x.Value).ToList());

            item.Collection = CollectionSearcher.GetCollection(item.CollectionId);

            return item;
        }

        private static List<Item> SetItems(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i] = SetItem(items[i]);
            }

            return items;
        }

        public static Item GetItem(int idItem)
        {
            Item item = Database.db.Items.FirstOrDefault(x => x.Id == idItem);

            item = SetItem(item);

            return item;
        }

        public static List<Item> GetAllItems()
        {
            return SetItems(Database.db.Items.ToList());
        }

        public static List<Item> GetItemsByTags(List<Tag> tags)
        {
            List<Item> searchedItems = new List<Item>();

            for (int i = 0; i < tags.Count; i++)
            {
                searchedItems.Add(GetItem(tags[i].IdItem));
            }

            return searchedItems.Distinct().ToList();
        }

        public static List<Item> GetCollectionItems(int idCollection)
        {
            return SetItems(Database.db.Items.Where(item => item.CollectionId == idCollection).ToList());
        }

        public static List<Item> GetLastAddedItems(int count)
        {
            return SetItems(Database.db.Items.OrderByDescending(x => x.Id).Take(count).ToList());
        }

       
    }
}
