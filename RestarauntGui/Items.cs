using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntGui
{
    static class Items
    {
        public static DataClasses1DataContext db;

        public static int CurrentMenu {get; set;}
        
        public static List<ITEM> getItemsObj()
        {
            return db.ITEMs.ToList();
        }
        /*
        public static String[] getItemsAsStringList()
        {
            string[] arr = new string[100];
            var items = db.ITEMs.ToList();
            int count = 0;
            foreach(var item in items)
            {
                arr[count] = { item.ITEM_ID, item.I_NAME };
                list.Add(arr);
                count++
            }
        }*/

        public static List<int> getItemId()
        {
            return db.ITEMs.Select(item => item.ITEM_ID).ToList();
        }

        public static List<String> getItemName()
        {
            return db.ITEMs.Select(item => item.I_NAME).ToList();
        }

        public static List<Decimal> getItemPrices()
        {
            return db.ITEMs.Select(item => item.I_COST).ToList();
        }

        public static List<String> getItemDescription()
        {
            return db.ITEMs.Select(item => item.I_DESCRIPTION).ToList();
        }

        public static List<int> getItemsFromMenu(int currentMenu)
        {
            return db.MENU_HAS_ITEMs
                .Where(menu => menu.MENU_ID == currentMenu)
                .Select(menu => menu.ITEM_ID)
                .ToList();
        }

        public static decimal getItemPrice(int id)
        {
            return db.ITEMs
                .Where(item => item.ITEM_ID == id)
                .Select(item => item.I_COST).First();

        }
        
        public static decimal orderTotal(Dictionary<int, int> order)
        {
            decimal total = 0;
            foreach (var item in order)
            {
                decimal itemCost = db.ITEMs.Where(items => items.ITEM_ID == item.Key).Select(items => items.I_PRICE).First();
                itemCost = itemCost * item.Value;
                total += itemCost; 
            }
            return total;
        }


    }
}
