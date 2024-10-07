using Bogus;

namespace ObjectOrientedPractics.Services
{
    internal class CustomerFactory
    {
        public static Customer GetCustomer() 
        {
            var fakerRu = new Faker("ru");
            Customer customer = new Customer(fakerRu.Name.FullName(),
                                             fakerRu.Address.FullAddress());
            return customer;
        }
    }
}
