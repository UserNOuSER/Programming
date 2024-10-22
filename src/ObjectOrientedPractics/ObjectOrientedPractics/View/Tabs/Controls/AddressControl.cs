namespace ObjectOrientedPractics
{
    public partial class AddressControl : UserControl
    {
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
        public bool TryInputAddress()
        {
            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
            /// <summary>
            /// Проверка данных: true - корректные, false - некорректные.
            /// </summary>
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
        private void OutputAddress()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country.ToString();
            CityTextBox.Text = _address.City.ToString();
            StreetTextBox.Text = _address.Street.ToString();
            BuildingTextBox.Text = _address.Building.ToString();
            ApartmentTextBox.Text = _address.Apartment.ToString();
        }
    }
}
