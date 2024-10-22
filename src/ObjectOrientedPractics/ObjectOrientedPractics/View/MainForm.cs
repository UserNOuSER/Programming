namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new();
        public MainForm()
        {
            InitializeComponent();
            customersTab.Customers = _store.Customers;
            itemsTab.Items = _store.Items;
        }
    }
}
