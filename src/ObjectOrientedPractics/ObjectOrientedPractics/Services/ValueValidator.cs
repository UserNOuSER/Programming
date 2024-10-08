namespace ObjectOrientedPractics
{ 
    /// <summary>
    /// Проверяет вводимые величины на правильность.
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Проверка строки на длину.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="MaxLenght">Максимальная длина строки.</param>
        /// <param name="propertyName">Название свойства, вызвавшего метод.</param>
        /// <exception cref="ArgumentException">Исключение вызывается если длина строки превышает MaxLenght. </exception>
        public static void AssertStringOnLenght(string value, int MaxLenght, string propertyName)
        {
            if (value.Length > MaxLenght)
            {
                throw new ArgumentException(propertyName + " должен быть меньше " + MaxLenght.ToString() + " символов.");
            }
        }
        /// <summary>
        /// Проверка строки на ненулевое или непустое значение.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Название свойства, вызвавшего метод.</param>
        /// <exception cref="ArgumentNullException">Исключение вызывается если строка пустая или равна null.</exception>
        public static void CheckStringOnNullOrEmpty(string value, string propertyName)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("свойство " + propertyName + " не должно быть null или пустым");
            }
        }
    }
}
