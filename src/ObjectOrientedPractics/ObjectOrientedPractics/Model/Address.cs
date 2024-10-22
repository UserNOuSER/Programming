namespace ObjectOrientedPractics
{
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        private string _index;
        /// <summary>
        /// 
        /// </summary>
        private string _country;
        /// <summary>
        /// 
        /// </summary>
        private string _city;
        /// <summary>
        /// 
        /// </summary>
        private string _street;
        /// <summary>
        /// 
        /// </summary>
        private string _building;
        /// <summary>
        /// 
        /// </summary>
        private string _apartement;
        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public string Apartment
        {
            get { return _apartement; }
            set
            {
                ValueValidator.AssertStringOnLenght(value, 10, nameof(Apartment));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Apartment));
                _apartement = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="building"></param>
        /// <param name="apartment"></param>
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
