using Bogus;

namespace ObjectOrientedPractics.Services
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
            var fakerRu = new Faker("ru");
            Customer customer = new(fakerRu.Name.FullName(),
                                    fakerRu.Address.FullAddress());
            return customer;
        }
    }
}
