namespace ObjectOrientedPractics
{
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Процент скидки
        /// </summary>
        private int _percent;
        /// <summary>
        /// Категория скидки
        /// </summary>
        private readonly Category _category;
        /// <summary>
        /// Сумма покупок в этой категории
        /// </summary>
        private double _total;
        /// <summary>
        /// Возвращает процент скидок
        /// </summary>
        public int Percent
        {
            get { return _percent; }
        }
        /// <summary>
        /// Возвращает категорию скидок
        /// </summary>
        public Category Category
        {
            get { return _category; }
        }
        /// <summary>
        /// Возвращает суммарные траты 
        /// </summary>
        public double Total
        { 
            get { return _total; }
        }
        /// <summary>
        /// Возвращает информацию о скидке
        /// </summary>
        public string Info
        {
            get { return $"Процентная {Category} – {Percent}%"; }
        }
        /// <summary>
        /// Создает пустой экземпляр класса
        /// </summary>
        public PercentDiscount()
        {
            _percent = 1;
            _category = new Category();
            _total = 0;
        }
        /// <summary>
        /// Создает экземпляр класса с выбранной категорией
        /// </summary>
        /// <param name="category"></param>
        public PercentDiscount(Category category)
        {
            _percent = 1;
            _category = category;
            _total = 0;
        }
        /// <summary>
        /// Возвращает сумму скидки
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double amounts = 0.0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amounts += item.Cost *  Percent;
                }
            }
            return amounts;
        }
        /// <summary>
        /// Возвращает сумму товара с примененной скидкой
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            double amounts = 0.0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amounts += item.Cost * (100 - Percent) / 100;
                }
                else
                {
                    amounts += item.Cost;
                }
            }
            return amounts;
        }
        /// <summary>
        /// Обновление процента скидки
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            if (Percent == 10) { return; }
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    _total += item.Cost;
                }
            }
            if (Total >= 10000)
            {
                _percent = 10;
            }
            else
            {
                _percent = (int)Math.Ceiling(Total / 1000);
            }
        }
    }
}
