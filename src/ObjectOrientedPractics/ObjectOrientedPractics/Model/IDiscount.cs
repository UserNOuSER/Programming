namespace ObjectOrientedPractics
{
    interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидочной системе
        /// </summary>
        string Info { get; }
        /// <summary>
        /// Возвращает сумму скидки
        /// </summary>
        /// <param name="items"></param>
        /// <returns>Возвращает сумму скидки</returns>
        double Calculate(List<Item> items);
        /// <summary>
        /// Применяет скидку
        /// </summary>
        /// <param name="items"></param>
        /// <returns>Возвращает сумму скидки</returns>
        double Apply(List<Item> items);
        /// <summary>
        /// Обновление скидок
        /// </summary>
        /// <param name="items"></param>
        void Update(List<Item> items);
    
    }
}
