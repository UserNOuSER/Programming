namespace ObjectOrientedPractics
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new();
        internal Address Address
        {
            get
            {
                TryInputAddress();
                return _address;
            }

            set
            {
                _address = value;
                OutputAddress();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Попытка ввести данные в систему. 
        /// </summary>
        /// <returns>true - если все данные корректны, false - если есть некорректные данные </returns>
        public bool TryInputAddress()
        {
            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
            bool _isDataCorrect = true;
            try
            {
                _address.Index = PostIndexTextBox.Text;
            }
            catch
            {
                PostIndexTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }

            try
            {
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            return _isDataCorrect;
        }
        /// <summary>
        /// Вывод данных в TextBox'ы
        /// </summary>
        private void OutputAddress()
        {
            PostIndexTextBox.Text = _address.Index;
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }
    }
}
