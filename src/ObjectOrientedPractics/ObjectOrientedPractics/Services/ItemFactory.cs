using Bogus;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс, создающий товар со случайными данными.
    /// </summary>
    internal class ItemFactory
    {
        /// <summary>
        /// Генерирует товар со случайными данными и возвращает его.
        /// </summary>
        /// <returns>Item</returns>
        public static Item GetItem() 
        {
            var fakerRu = new Faker("ru");
            Item item = new(fakerRu.Commerce.Product().ToString(),
                            fakerRu.Commerce.ProductDescription().ToString(),
                            float.Parse(fakerRu.Commerce.Price(0, 100000)));

            return item;
        }
    }
}
