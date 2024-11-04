namespace ObjectOrientedPractics
{
    public class Order
    {
        private readonly int _id;
        private readonly DateTime _dateTime;
        private Address _address;
        private List<Item> _items;
        private double _amount = 0.0;
        private OrderStatus _orderStatus;
        public int Id 
        { 
            get { return _id; } 
        }
        public DateTime DateTime 
        { 
            get { return _dateTime; } 
        }
        public Address Address 
        {
            get { return _address; }
            set { _address = value; }
        }
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public double Amount
        {
            get 
            {
                if (!((Items == null) || (Items.Count == 0)))
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        _amount += Items[i].Cost;
                    }
                }
                return _amount;
            }
        }
        public OrderStatus OrderStatus
        {
            get { return _orderStatus; }
            set { _orderStatus = value; }
        }
        public Order()
        {
            _items = new List<Item>();
            _id = IDGenerator.GetNextId();
            _dateTime = DateTime.Now;
            _address = new();
            _orderStatus = OrderStatus.New;
        }
        public Order(Address address, List<Item> items)
        {
            _id = IDGenerator.GetNextId();
            _dateTime = DateTime.Now; ;
            Address = address;
            Items = items;
            _orderStatus = OrderStatus.New;
        }
    }
}
