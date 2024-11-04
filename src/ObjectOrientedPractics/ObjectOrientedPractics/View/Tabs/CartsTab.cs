namespace ObjectOrientedPractics
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// 
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// 
        /// </summary>
        private Customer _currentCustomer;
        /// <summary>
        /// 
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public CartsTab()
        {
            InitializeComponent();
        }
        private void CartsTab_Load(object sender, EventArgs e)
        {
            RefreshData();
        }


        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomerComboBox.SelectedItem as Customer;
            if (_currentCustomer == null) { return; }
            UpdateCart();

        }


        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem == null) { return; }
            _currentCustomer.Cart.Items.Add(selectedItem);
            UpdateCart();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0) { return; }
            Order newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items);
            _currentCustomer.Orders.Add(newOrder);

            _currentCustomer.Cart.Items.Clear();
            UpdateCart();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem == null) { return; }
            _currentCustomer.Cart.Items.Remove(selectedItem);
            UpdateCart();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            UpdateCart();
        }
        private void UpdateCart()
        {
            AmountNumberLabel.Text = _currentCustomer.Cart.Amount.ToString();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;

        }
        public void RefreshData()
        {
            ItemsListBox.DataSource = null;
            CustomerComboBox.DataSource = null;

            ItemsListBox.DataSource = Items;
            CustomerComboBox.DataSource = Customers;
        }
    }
}
