namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ ��������.
        /// </summary>
        private Store _store = new();
        public MainForm()
        {
            InitializeComponent();
            customersTab.Customers = _store.Customers;
            itemsTab.Items = _store.Items;
        }
    }
}
