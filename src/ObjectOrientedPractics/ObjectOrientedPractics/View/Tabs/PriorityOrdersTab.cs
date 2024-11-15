using System.Collections.Generic;

namespace ObjectOrientedPractics
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Заказ 
        /// </summary>
        private PriorityOrder _order = new();
        /// <summary>
        /// Все возможные товары
        /// </summary>
        private List<Item> _items = [];
        /// <summary>
        /// Свойство для товаров
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public PriorityOrdersTab()
        {
            InitializeComponent();
            SetData();
        }
        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            TimeComboBox.DataSource = PriorityOrder.TimeRangesList;
        }
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }
        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.WantedTime = (string)TimeComboBox.SelectedItem;
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            int randIndex = rnd.Next(_items.Count);
            _order.Items.Add(_items[randIndex]);
            UpdateInfo();
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Item? selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem == null) { return; }
            _order.Items.Remove(selectedItem);
            UpdateInfo();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _order = new();
            SetData();
        }
        /// <summary>
        ///  Обновлние листбокса и строки с суммарной стоимостью 
        /// </summary>
        public void UpdateInfo()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _order.Items;
            AmountNumberLabel.Text = _order.Amount.ToString();
        }
        /// <summary>
        /// Установка всех данных(отделно чтобы не переиспользовать один код)
        /// </summary>
        private void SetData()
        {
            IDTextBox.Text = _order.Id.ToString();
            CreatedTextBox.Text = _order.DateTime.ToString();
            StatusComboBox.SelectedItem = _order.OrderStatus;
            TimeComboBox.SelectedItem = _order.WantedTime;
            addressControl1.Address = _order.Address;
            ItemsListBox.DataSource = _order.Items;
            AmountNumberLabel.Text = _order.Amount.ToString();
        }
    }
}
