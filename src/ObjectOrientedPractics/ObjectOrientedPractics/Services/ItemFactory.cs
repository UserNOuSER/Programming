using Bogus;
using ObjectOrientedPractics.Model;

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
            var faker = new Faker();
            Item item = new(fakerRu.Commerce.Product().ToString(),
                            fakerRu.Commerce.ProductDescription().ToString(),
                            float.Parse(faker.Commerce.Price(0, 100000)),
                            faker.PickRandom<Category>());

            return item;
        }
    }
}
