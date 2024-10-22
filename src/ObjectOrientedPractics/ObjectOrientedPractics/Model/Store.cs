namespace ObjectOrientedPractics
{
    internal class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Создает и задает список для хранения товаров. Не должно быть null.
        /// </summary>
        public List<Item> Items
        {
            get
            { return _items; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Items не должно быть null");
                }
                _items = value;
            }
        }
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
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();

        }
    }
}
