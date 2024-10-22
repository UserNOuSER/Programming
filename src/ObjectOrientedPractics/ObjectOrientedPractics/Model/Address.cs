namespace ObjectOrientedPractics
{
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private string _index;
        /// <summary>
        /// Страна покупателя.
        /// </summary>
        private string _country;
        /// <summary>
        /// Город покупателя.
        /// </summary>
        private string _city;
        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string _street;
        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string _building;
        /// <summary>
        /// Номер квартиры покупателя.
        /// </summary>
        private string _apartment;
        /// <summary>
        /// Возвращает и задает почтовый индекс. Должно быть длиной 6 символов и состоять только из цифр.
        /// </summary>
        public string Index
        {
            get { return _index; }
            set
            {
                if (value.Length != 6)
                {
                    throw new ArgumentException(nameof(Index) + " должен состоять из 6 символов.");
                }
                if (!int.TryParse(value, out _))
                {
                    throw new ArgumentException(nameof(Index) + " должен состоять только из цифр.");
                }
                _index = value;
            }
        }
        /// <summary>
        /// Возвращает и задает страну покупателя. Должно быть непустым и короче 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLenght(value, 50, nameof(Country));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Country));
                _country = value;
            }
        }
        /// <summary>
        /// Возвращает и задает город покупателя. Должно быть непустым и короче 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLenght(value, 50, nameof(City));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(City));
                _city = value;
            }
        }
        /// <summary>
        /// Возвращает и задает улицу покупателя. Должно быть непустым и короче 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set 
            { 
                ValueValidator.AssertStringOnLenght(value, 100, nameof(Street));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Street));  
                _street = value;
            }
        }
        /// <summary>
        /// Возвращает и задает номер дома покупателя. Должно быть непустым и короче 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set 
            { 
                ValueValidator.AssertStringOnLenght(value, 10, nameof(Building));
                ValueValidator.CheckStringOnNullOrEmpty(value,  nameof(Building));
                _building = value;
            }
        }
        /// <summary>
        /// Возвращает и задает номер квартиры покупателя. Должно быть непустым и короче 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLenght(value, 10, nameof(Apartment));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Apartment));
                _apartment = value;
            }
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = "000000";
            Country = "Russia";
            City = "Tomsk";
            Street = "Lytkina";
            Building = "18";
            Apartment = "508";
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="Index">Почтовый индекс. Должно быть длиной 6 символов и состоять только из цифр.</param>
        /// <param name="Country">Cтрана покупателя. Должно быть непустым и короче 50 символов.</param>
        /// <param name="City">Город покупателя. Должно быть непустым и короче 50 символов.</param>
        /// <param name="Street">Улица покупателя. Должно быть непустым и короче 100 символов.</param>
        /// <param name="Building">Номер дома покупателя. Должно быть непустым и короче 10 символов.</param>
        /// <param name="Apartment">Номер квартиры покупателя. Должно быть непустым и короче 10 символов.</param>
        public Address(string index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
