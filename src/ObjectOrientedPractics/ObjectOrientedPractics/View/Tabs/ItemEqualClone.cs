using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class ItemEqualClone : UserControl
    {
        /// <summary>
        /// Текущий левый товар.
        /// </summary>
        private Item _leftCurrentItem = new();
        /// <summary>
        /// текущий правый товар.
        /// </summary>
        private Item _rightCurrentItem = new();
        /// <summary>
        /// список товаров
        /// </summary> 
        private List<Item> _items = [];
        /// <summary>
        /// Возвращает и задает список товаров
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Items не должно быть null");
                }
                _items = value;
            }
        }
        public ItemEqualClone()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LeftItemListBox.SelectedItem is null) { return; }

            _leftCurrentItem = (Item)LeftItemListBox.SelectedItem;

            LeftItemListBox.DataSource = null;
            LeftItemListBox.DataSource = Items;
        }

        private void EqualCompareWindow_Load(object sender, EventArgs e)
        {
            LeftItemListBox.DataSource = Items;
            RedItemListBox.DataSource = Items;
        }

        private void RedItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RedItemListBox.SelectedItem is null) { return; }

            _rightCurrentItem = (Item)RedItemListBox.SelectedItem;

            RedItemListBox.DataSource = null;
            RedItemListBox.DataSource = Items;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (_rightCurrentItem.Equals(_leftCurrentItem))
            {
                MessageBox.Show("Товары равны",
                    "Результат",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Товары различны",
                    "Результат",
                    MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item ClonedItem = (Item)_leftCurrentItem.Clone();
            Items.Add(ClonedItem);

            RedItemListBox.DataSource = null;
            RedItemListBox.DataSource = Items;

            LeftItemListBox.DataSource = null;
            LeftItemListBox.DataSource = Items;
        }
        /// <summary>
        /// То же самое что и во вкладке с товарами но дважды
        /// </summary>
        public void UpdateInfo()
        {
            RedItemListBox.DataSource = null;
            RedItemListBox.DataSource = Items;

            LeftItemListBox.DataSource = null;
            LeftItemListBox.DataSource = Items;
        }
    }
}
