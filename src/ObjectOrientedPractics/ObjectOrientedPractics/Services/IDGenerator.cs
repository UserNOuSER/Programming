namespace ObjectOrientedPractics
{
    /// <summary>
    /// Класс, создающий уникальные идентификаторы.
    /// </summary>
    internal class IDGenerator
    {
        /// <summary>
        /// Объект блокировки
        /// </summary>
        private static readonly object _lockingObject = new();
        /// <summary>
        /// Внутренний счетчик для класса
        /// </summary>
        private static int _currentId = 0;

        /// <summary>
        /// Генерирует и возвращает уникальный идентификатор.
        /// </summary>
        /// <returns>Униккальный идентификатор типа int.</returns>
        public static int GetNextId()
        {
            lock (_lockingObject)
            {
                _currentId++;
                return _currentId;
            }
        }
    }
}
