using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System.Drawing.Text;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие при изменении списка товаров
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;
        /// <summary>
        /// Список для хранения товаров.
        /// </summary>
        private List<Item> _items = [];
        /// <summary>
        /// Список для хранения отсортированных + упорядоченныхх товаров
        /// </summary>
        private List<Item> _sortedItems = [];
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
            SortComboBox.DataSource = new List<string>(["Name (Descending)", "Cost (Ascending)", "Cost (Descending)", "Name (Ascending)"]);
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

            GetSortedItems();
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

            GetSortedItems();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Items.Remove(_currentItem);
            GetSortedItems();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GetItem();
            Items.Add(newItem);
            GetSortedItems();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text;
            _sortedItems = DataTools.GetWithCondition(Items, query, DataTools.ContainsSubstring);
            if (_sortedItems.Count > 0)
            {
                ItemsListBox.DataSource = _sortedItems;
            }
            else
            {
                MessageBox.Show("Нет значений с таким содержанием",
                    "Ошибъка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            GetSortedItems();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSortedItems();
        }
        /// <summary>
        /// Сортировщик. Отправляет запросы делегатам на сортировку выбранным способом
        /// </summary>
        private void GetSortedItems()
        {
            if (SearchTextBox.Text == "")
            {
                _sortedItems = Items;
            }
            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    _sortedItems = DataTools.SortBy(_sortedItems, false, DataTools.SortByName);
                    break;
                case 1:
                    _sortedItems = DataTools.SortBy(_sortedItems, true, DataTools.SortByCost);
                    break;
                case 2:
                    _sortedItems = DataTools.SortBy(_sortedItems, false, DataTools.SortByCost);
                    break;
                case 3:
                    _sortedItems = DataTools.SortBy(_sortedItems, true, DataTools.SortByName);
                    break;
            }
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _sortedItems;
        }
    }
}
