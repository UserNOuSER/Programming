﻿using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {   
        /// <summary>
        /// Список для хранения покупателей.
        /// </summary>
        private List<Customer> _customers = [];
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;
        /// <summary>
        /// Проверка данных: true - корректные, false - некорректные.
        /// </summary>
        bool _isDataCorrect = true;
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            _customers.Add(CustomerFactory.GenerateCustomer());
            _customers.Add(CustomerFactory.GenerateCustomer());
            _customers.Add(CustomerFactory.GenerateCustomer());
            _customers.Add(CustomerFactory.GenerateCustomer());
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = 0;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is null) { return; }
            if (!_isDataCorrect)
            {
                CustomersListBox.SelectedItem = _currentCustomer;
                return;
            }
            _currentCustomer = (Customer)CustomersListBox.SelectedItem;

            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullnameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressTextBox.Text = _currentCustomer.Address;

            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;

        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            _isDataCorrect = true;
            FullnameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;

            try
            {
                string address = AddressTextBox.Text;
                _currentCustomer.Address = address;
            }
            catch (Exception)
            {
                AddressTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                string fullname = FullnameTextBox.Text;
                _currentCustomer.Fullname = fullname;
            }
            catch (Exception)
            {
                FullnameTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new();
            _customers.Add(customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.GenerateCustomer();
            _customers.Add(customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }
    }
}
