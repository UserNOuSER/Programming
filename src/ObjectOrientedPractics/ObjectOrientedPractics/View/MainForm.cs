using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Данные магазина.
        /// </summary>
        private Store _store = new();
        public MainForm()
        {
            InitializeComponent();
            itemsTab.Items = _store.Items;
            cartsTab1.Items = _store.Items;
            priorityOrdersTab1.Items = _store.Items;
            equalCompareWindow1.Items = _store.Items;

            customersTab.Customers = _store.Customers;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;
            equalTab1.Customers = _store.Customers;
            itemsTab.ItemsChanged += ItemsTab_ItemsChanged;
        }

        private void ItemsTab_ItemsChanged(object? sender, EventArgs e)
        {
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
            priorityOrdersTab1.UpdateInfo();
            equalCompareWindow1.UpdateInfo();
            equalTab1.RefreshData();
        }

        /// <summary>
        /// Обновление параметров при смене окон
        /// </summary>
        private void SelectedTabChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    cartsTab1.RefreshData();
                    break;
                case 3:
                    ordersTab1.RefreshData();
                    break;
                case 4:
                    priorityOrdersTab1.UpdateInfo();
                    break;
                case 5:
                    equalCompareWindow1.UpdateInfo();
                    break;
                case 7:
                    equalTab1.RefreshData();
                    break;

            }
        }
    }
}
