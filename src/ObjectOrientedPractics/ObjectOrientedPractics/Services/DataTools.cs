using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    internal static class DataTools
    {
        
        public static Func<Item, double, bool> CostMoreThan => (Item item, double cost) => item.Cost > cost;
        public static Func<Item, Category, bool> IsCategory => (Item item, Category category) => item.Category == category;
        public static Func<Item, string, bool> ContainsSubstring => (Item item, string text) => item.Name.Contains(text);
        /// <summary>
        /// Функция, выбирающая элементы списка в связи с опр условием
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="info"></param>
        /// <param name="cr"></param>
        /// <returns></returns>
        public static List<Item> GetWithCondition<T>(List<Item> items, T info, Func<Item, T, bool> cr)
        {
            List<Item> newItems = []; 
            for (int i = 0; i < items.Count; i++)
            {
                if (cr(items[i], info))
                {
                    newItems.Add(items[i]);
                }
            }
            return newItems;
        }
        public static Func<Item, Item, bool, bool> SortByCost => (Item itemL, Item itemR, bool ascending) => (itemL.Cost > itemR.Cost) ^ ascending;
        public static Func<Item, Item, bool, bool> SortByName => (Item itemL, Item itemR, bool ascending) => ((itemL.CompareTo(itemR)) == 1) ^ ascending;
        /// <summary>
        /// Функция, сортирующая по опр признаку
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ascending"></param>
        /// <param name="compare"></param>
        /// <returns></returns>
        public static List<Item> SortBy(List<Item> items,bool ascending, Func<Item, Item, bool, bool> compare)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (compare(items[j], items[j - 1], ascending))
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }
    }
}
