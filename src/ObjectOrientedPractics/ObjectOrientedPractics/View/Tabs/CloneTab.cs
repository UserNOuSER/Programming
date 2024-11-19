using Bogus;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    public partial class CloneTab : UserControl
    {
        static Faker faker = new();
        /// <summary>
        /// Случайно сгенерированный (левый) адрес
        /// </summary>
        private Address _leftAddress = new(faker.Address.ZipCode(format: "######"), faker.Address.Country(), faker.Address.City(),
        faker.Address.StreetName(), faker.Address.BuildingNumber(), faker.Address.SecondaryAddress());
        /// <summary>
        /// Случайно сгенерированная левая телега
        /// </summary>
        private Cart _leftCart = new Cart([ItemFactory.GetItem(), ItemFactory.GetItem(), ItemFactory.GetItem(), ItemFactory.GetItem(), ItemFactory.GetItem()]);
        /// <summary>
        /// Возвращает и задает левую корзину
        /// </summary>
        public Cart LeftCart { get { return _leftCart; } set { _leftCart = value; } }
        /// <summary>
        /// Возвращает и задает левый адрес.
        /// </summary>
        public Address LeftAddress { get { return _leftAddress; } set { _leftAddress = value; } }
        public CloneTab()
        {
            InitializeComponent();
            LeftListBox.DataSource = LeftCart.Items;
            addressControl1.Address = _leftAddress;
        }
        private void CloneButton_Click(object sender, EventArgs e)
        {
            Address rightAddress = (Address)LeftAddress.Clone();
            Cart rightCart = (Cart)LeftCart.Clone();
            RightListBox.DataSource = rightCart.Items;
            addressControl2.Address = rightAddress;
        }
    }
}
