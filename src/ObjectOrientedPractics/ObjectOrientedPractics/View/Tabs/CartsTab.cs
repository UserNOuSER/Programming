using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Текущий покупатель
        /// </summary>
        private Customer _currentCustomer;
        /// <summary>
        /// Возвращает и задает список покупателей
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        /// <summary>
        /// Возвращает и задает список товаров
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
            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;
            CheckAll();
            UpdateCart();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Item? selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem == null) { return; }
            _currentCustomer.Cart.Items.Add(selectedItem);
            UpdateCart();
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Item? selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem == null) { return; }
            _currentCustomer.Cart.Items.Remove(selectedItem);
            UpdateCart();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            UpdateCart();
        }
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0) { return; }


            double discountAmount = 0;
            List<IDiscount> selectedDiscounts = new List<IDiscount>();

            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                var discount = _currentCustomer.Discounts[index];
                discountAmount += discount.Apply(_currentCustomer.Cart.Items);
                selectedDiscounts.Add(discount);
            }

            if (!_currentCustomer.IsPriority)
            {
                Order newOrder = new(_currentCustomer.Address, _currentCustomer.Cart.Items, discountAmount);
                _currentCustomer.Orders.Add(newOrder);
            }
            else
            {
                PriorityOrder newOrder = new(DateTime.Now.AddDays(1), PriorityOrder.TimeRangesList[0], _currentCustomer.Address, _currentCustomer.Cart.Items, discountAmount);
                _currentCustomer.Orders.Add(newOrder);
            }

            foreach (var discount in selectedDiscounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }

            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;

            _currentCustomer.Cart.Items = new();
            CheckAll();
            UpdateCart();
        }
        private void DiscountsCheckedListBox_Click(object sender, MouseEventArgs e)
        { // взято с форума https://www.tek-tips.com/threads/mouseclick-event-not-firing.1585202/
          // честно говоря сутки бегать по сайтам и форумам чтобы починить конкретно вот checkedlistbox это прям <<<<<
            if (e.Button == MouseButtons.Left)
            {
                UpdateDiscount();
            }
        }
        /// <summary>
        /// Обновляет данные суммарной стоимости и корзины(а так же блока скидок)
        /// </summary>
        private void UpdateCart()
        {
            AmountNumberLabel.Text = _currentCustomer.Cart.Amount.ToString();

            UpdateDiscount();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
        }
        /// <summary>
        /// Обновляет данные предметов и покупателей
        /// </summary>
        public void RefreshData()
        {
            ItemsListBox.DataSource = null;
            CustomerComboBox.DataSource = null;

            ItemsListBox.DataSource = Items;
            CustomerComboBox.DataSource = Customers;

        }
        /// <summary>
        /// Обновление блока со скидками - суммы скидки и итоговой стоимости
        /// </summary>
        private void UpdateDiscount()
        {
            double discountAmount = 0;
            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                discountAmount += _currentCustomer.Discounts[index].Calculate(_currentCustomer.Cart.Items);
            }
            DiscountAmountLabel.Text = discountAmount.ToString();

            double total = _currentCustomer.Cart.Amount - discountAmount;
            TotalLabel.Text = total.ToString();

        }
       
        /// <summary>
        /// Отмечает все пункты в DiscountsCheckedListBox
        /// Почему это не сделали базовым методом...
        /// </summary>
        private void CheckAll()
        {
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }
        }

    }
}
