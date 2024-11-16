using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Время создания заказа
        /// </summary>
        private readonly DateTime _dateTime;
        /// <summary>
        /// Адрес доставки
        /// </summary>
        private Address _address;
        /// <summary>
        /// Список товаров в заказе
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Суммарная стоимость
        /// </summary>
        private double _amount;
        /// <summary>
        /// Статус заказа
        /// </summary>
        private OrderStatus _orderStatus;
        /// <summary>
        /// Возвращает уникальный идентификатор
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// Возвращает время создания заказа
        /// </summary>
        public DateTime DateTime
        {
            get { return _dateTime; }
        }
        /// <summary>
        /// Возвращает суммарную стоимость
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0.0;
                if (Items != null & Items.Count != 0)
                {
                    foreach (var item in Items)
                    {
                        _amount += item.Cost;
                    }
                }
                return _amount;
            }
        }
        /// <summary>
        /// Возвращает и задает адрес заказа
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// Возвращает и задает список товаров в заказе
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double DiscountAmount { get; set; }
        public double Total
        {
            get { return Amount - DiscountAmount; }
        }
        /// <summary>
        /// Возвращает и задает статус заказа
        /// </summary>
        public OrderStatus OrderStatus
        {
            get { return _orderStatus; }
            set { _orderStatus = value; }
        }
        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _items = [];
            _id = IDGenerator.GetNextId();
            _dateTime = DateTime.Now;
            _address = new();
            _orderStatus = OrderStatus.New;
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес заказа</param>
        /// <param name="items">Список товаров в заказе</param>
        public Order(Address address, List<Item> items)
        {
            _id = IDGenerator.GetNextId();
            _dateTime = DateTime.Now;
            Address = address;
            Items = items;
            _orderStatus = OrderStatus.New;
        }
    }
}
