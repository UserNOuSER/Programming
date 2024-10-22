using Bogus;
namespace ObjectOrientedPractics
{
    /// <summary>
    /// Класс, создающий покупателя со случайными данными.
    /// </summary>
    internal class CustomerFactory
    {
        /// <summary>
        /// Генерирует покупателя со случайными данными и возвращает его.
        /// </summary>
        /// <returns>Customer</returns>
        public static Customer GenerateCustomer() 
        {
            var faker = new Faker();
            Customer customer = new(faker.Name.FullName(),
                                    new Address(faker.Address.ZipCode(format: "######") , faker.Address.Country(), faker.Address.City(),
                                    faker.Address.StreetName(), faker.Address.BuildingNumber(), faker.Address.SecondaryAddress()));
            return customer;
        }
    }
}
