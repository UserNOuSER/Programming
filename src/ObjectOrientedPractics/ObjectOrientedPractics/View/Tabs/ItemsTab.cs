using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список для хранения товаров.
        /// </summary>
        private List<Item> _items = [];
        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;
        /// <summary>
        /// Проверка данных: true - корректные, false - некорректные.
        /// </summary>
        bool _isDataCorrect = true;

        public ItemsTab()
        {
            InitializeComponent();
        }
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items.Add(ItemFactory.GetItem()); 
            _items.Add(ItemFactory.GetItem());
            _items.Add(ItemFactory.GetItem());
            _items.Add(ItemFactory.GetItem());
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = 0;
        }
        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is null) { return; }
            if (!_isDataCorrect)
            {
                ItemsListBox.SelectedItem = _currentItem;
                return;
            }
            _currentItem = (Item)ItemsListBox.SelectedItem;

            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            InfoTextBox.Text = _currentItem.Info;

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }
        private void ItemListBox_Click(object sender, EventArgs e)
        {
            _isDataCorrect = true;
            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            InfoTextBox.BackColor = Color.White;

            try
            {
                float cost = float.Parse(CostTextBox.Text);
                _currentItem.Cost = cost;
            }
            catch (Exception)
            {
                CostTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                string name = NameTextBox.Text;
                _currentItem.Name = name;
            }
            catch (Exception)
            {
                NameTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            try
            {
                string info = InfoTextBox.Text;
                _currentItem.Info = info;
            }
            catch (Exception)
            {
                InfoTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            Item newItem = new();
            _items.Add(newItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GetItem();
            _items.Add(newItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;

        }
    }
}
