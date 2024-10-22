namespace ObjectOrientedPractics
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список для хранения товаров.
        /// </summary>
        private List<Item> _items = new();
        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem = new();
        /// <summary>
        /// Проверка данных: true - корректные, false - некорректные.
        /// </summary>
        bool _isDataCorrect = true;
        /// <summary>
        /// Создает и задает список для хранения товаров. Не должно быть null.
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


        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            Items.Add(_currentItem);
            ItemsListBox.DataSource = Items;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
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
            CategoryComboBox.SelectedItem = _currentItem.Category;

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
        }

        private void ItemListBox_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) { return; }

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
            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            Item newItem = new();
            Items.Add(newItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GetItem();
            Items.Add(newItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
        }
    }
}
