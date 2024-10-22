using Bogus;

namespace ObjectOrientedPractics
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
        {;
            var faker = new Faker();
            Item item = new(faker.Commerce.Product().ToString(),
                            faker.Commerce.ProductDescription().ToString(),
                            float.Parse(faker.Commerce.Price(0, 100000)),
                            faker.PickRandom<Category>());

            return item;
        }
    }
}
