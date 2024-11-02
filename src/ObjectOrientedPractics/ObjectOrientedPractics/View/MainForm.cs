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
            customersTab.Customers = _store.Customers;
            itemsTab.Items = _store.Items;
        }

        private void itemsTab_Load(object sender, EventArgs e)
        {

        }
    }
}
