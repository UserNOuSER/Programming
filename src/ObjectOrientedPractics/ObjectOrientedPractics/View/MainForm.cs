namespace ObjectOrientedPractics
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
            customersTab.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
        }

        private void SelectedTabChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                cartsTab1.RefreshData();
            }
        }

    }
}
