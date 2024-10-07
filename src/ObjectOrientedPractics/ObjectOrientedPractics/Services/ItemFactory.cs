using Bogus;
using Bogus.DataSets;

namespace ObjectOrientedPractics.Services
{
    internal class ItemFactory
    {
        public static Item GetItem() 
        {
            var fakerRu = new Faker("ru");
            Item item = new Item(fakerRu.Commerce.Product().ToString(),
                                 fakerRu.Commerce.ProductDescription().ToString(),
                                 float.Parse(fakerRu.Commerce.Price(0, 100000)));

            return item;
        }
    }
}
