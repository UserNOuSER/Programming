using System.Data;

namespace ObjectOrientedPractics
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = [];

        /// <summary>
        /// Возвращает и задаёт список всех покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        public OrdersTab()
        {
            InitializeComponent();
            OrderStatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrdersListBox.DataSource = null;
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IDTextBox.Text = string.Empty;
                DatetimeTextBox.Text = string.Empty;
                OrderStatusComboBox.Text = string.Empty;
                addressControl1.Address = new Address();
                AmountNumberLabel.Text = string.Empty;
            }
            else
            {
                Order order = _orders[OrdersDataGridView.CurrentRow.Index];
                IDTextBox.Text = order.Id.ToString();
                DatetimeTextBox.Text = order.DateTime.ToString();
                OrderStatusComboBox.SelectedItem = order.OrderStatus;
                addressControl1.Address = order.Address;
                OrdersListBox.DataSource = null;
                OrdersListBox.DataSource = order.Items;
                AmountNumberLabel.Text = order.Amount.ToString();
            }
        }
        public void RefreshData()
        {
            DataTable dataTable = new();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Status", typeof(OrderStatus));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Amount", typeof(double));
            dataTable.Columns.Add("CustomerName", typeof(string));

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    var row = dataTable.NewRow();
                    row["ID"] = order.Id;
                    row["Address"] = customer.Address.ToString();
                    row["Status"] = order.OrderStatus;
                    row["Date"] = order.DateTime;
                    row["Amount"] = order.Amount;
                    row["CustomerName"] = customer.Fullname;
                    dataTable.Rows.Add(row);
                }
            }
            OrdersDataGridView.DataSource = dataTable;
        }
        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) { return; }
            Order order = _orders[OrdersDataGridView.CurrentRow.Index];
            order.OrderStatus = (OrderStatus)OrderStatusComboBox.SelectedItem;
        }
    }
}
