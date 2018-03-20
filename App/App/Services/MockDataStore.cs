using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using App.Models;

[assembly: Xamarin.Forms.Dependency(typeof(App.Services.MockDataStore))]
namespace App.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "80 Nailuva, Suva", Description="2 Beds, 2 Baths, Fully Furnished, $2500, Owned by Fini" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "26 Matanitobua, Suva", Description="2 Beds, 1 Baths, Partially Furnished, $1000, Owned by Jomz" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "15 Vucci, Nausori", Description="1 Beds, 1 Baths, Fully Furnished, $1500, Owned by Klaus" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "30 Fantasy, Nadi", Description="3 Beds, 2 Baths, Fully Furnished, $3200, Owned by M'Paku" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Lot 4 Raiwai, Suva", Description="1 Beds, 1 Baths, Not Furnished, $800, Owned by Wakanda" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "8 Raiwaqa, Suva", Description="2 Beds, 2 Baths, Partially Furnished, $1200, Owned by Marvel" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}