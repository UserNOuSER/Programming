namespace ObjectOrientedPractics
{
    internal class Store
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// 
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();

        }

    }
}
