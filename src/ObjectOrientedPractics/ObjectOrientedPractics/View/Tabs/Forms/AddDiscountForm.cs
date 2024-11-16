using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Поле с выбранной категорией
        /// </summary>
        public Category SelectedCategory { get; private set; }
        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }
        public void AddDiscountForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = 0;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
