using System.Drawing.Text;

namespace ObjectOrientedPractics
{
    public class Cart
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// 
        /// </summary>
        private float _amount;
        /// <summary>
        /// 
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float Amount
        {
            get
            {
                _amount = 0;
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
        /// 
        /// </summary>
        public Cart()
        {
            Items = new();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public Cart(List<Item> items)
        {
            Items = items;
        }
    }
}
