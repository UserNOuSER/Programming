using System.Drawing.Text;

namespace ObjectOrientedPractics
{
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Суммарная стоимость
        /// </summary>
        private double _amount;
        /// <summary>
        /// Возвращает и задает список товаров в корзине
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// Возвращает суммарную стоимость
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0.0;
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
        /// <summary>
        /// Создает пустой экземпляр класса
        /// </summary>
        public Cart()
        {
            Items = [];
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>
        /// </summary>
        /// <param name="items">Список товаров в корзине</param>
        public Cart(List<Item> items)
        {
            Items = items;
        }
    }
}
