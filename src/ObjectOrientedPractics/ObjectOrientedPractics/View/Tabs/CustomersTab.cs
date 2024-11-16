using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Forms;
using System.Linq;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список для хранения покупателей.
        /// </summary>
        private List<Customer> _customers = [];
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer = new();
        /// <summary>
        /// Проверка данных: true - корректные, false - некорректные.
        /// </summary>
        bool _isDataCorrect = true;
        /// <summary>
        /// Создает и задает список для хранения покупателей. Не должно быть null.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customers не должно быть null");
                }
                _customers = value;
            }
        }
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            _customers.Add(_currentCustomer);
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = 0;
            DiscountsListBox.DataSource = _currentCustomer.Discounts;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? customer = CustomersListBox.SelectedItem as Customer;

            if (customer is null) { return; }
            if (!_isDataCorrect)
            { return; }
            _currentCustomer = customer;

            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullnameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressControl1.Address = _currentCustomer.Address;
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.DataSource = null;
            DiscountsListBox.DataSource = _currentCustomer.Discounts;


            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;

        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            _isDataCorrect = true;
            FullnameTextBox.BackColor = Color.White;

            if (AddressControl1.TryInputAddress())
            {
                _currentCustomer.Address = AddressControl1.Address;
            }
            else
            {
                _isDataCorrect = false;
            }
            try
            {
                string fullname = FullnameTextBox.Text;
                _currentCustomer.Fullname = fullname;
            }
            catch (Exception)
            {
                FullnameTextBox.BackColor = Color.Tomato;
                _isDataCorrect = false;
            }
            _currentCustomer.IsPriority = PriorityCheckBox.Checked;

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new();
            _customers.Add(customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.GenerateCustomer();
            _customers.Add(customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = PriorityCheckBox.Checked;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is null) return;
            using (AddDiscountForm addDiscountForm = new AddDiscountForm())
            {
                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    Category selectedCategory = addDiscountForm.SelectedCategory;
                    foreach (IDiscount discount in _currentCustomer.Discounts)
                    {
                        if (discount is PercentDiscount percentDiscount && percentDiscount.Category == selectedCategory)
                        {
                            MessageBox.Show("Скидка для этой категории уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    PercentDiscount newDiscount = new PercentDiscount(selectedCategory);
                    _currentCustomer.Discounts.Add(newDiscount);

                    DiscountsListBox.DataSource = null;
                    DiscountsListBox.DataSource = _currentCustomer.Discounts;
                }

            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is null || DiscountsListBox.SelectedIndex < 1) return; //если не выбрано или если первый(нулевой жлемент(типа накопительная - она всгеда первая
            _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            DiscountsListBox.DataSource = null;
            DiscountsListBox.DataSource = _currentCustomer.Discounts;

        }
    }
}
