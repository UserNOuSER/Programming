namespace ObjectOrientedPractics
{
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Сумма баллов 
        /// </summary>
        private double _points;
        /// <summary>
        /// Возвращает и задает баллы
        /// </summary>
        public double Points
        {
            get { return _points; }
            private set
            {
                if (value >= 0.0)
                {
                    _points = value;
                }
            }
        }
        /// <summary>
        /// Возвращает информацию о скидочной системе
        /// </summary>
        public string Info
        {
            get { return $"Накопительная – {Points} баллов"; }
            
        }
        /// <summary>
        /// Создает пустой экземпляр класса
        /// </summary>
        public PointsDiscount()
        {
            _points = 0.0;
        }
        /// <summary>
        /// Возвращает сумму скидки
        /// </summary>
        /// <param name="items"></param>
        /// <returns>Возвращает сумму скидки</returns>
        public double Calculate(List<Item> items)
        {
            double amounts = 0.0;
            foreach (Item item in items)
            {
                amounts += item.Cost;
            }
            if (amounts * 0.3 >= Points)
            {
                return Points;
            }
            return amounts;
        }
        /// <summary>
        /// Применяет скидку(вычитает баллы из имеющихся)
        /// </summary>
        /// <param name="items"></param>
        /// <returns>Возвращает сумму скидки</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _points -= discount;
            return discount;
        }
        /// <summary>
        /// Обновление баллов(добавление новых)
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double amounts = 0.0;
            foreach (Item item in items)
            {
                amounts += item.Cost;
            }
            _points += Math.Ceiling(amounts * 0.1);
        }
    }
}
