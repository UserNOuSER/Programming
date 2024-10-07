namespace ObjectOrientedPractics
{ 
    internal class ValueValidator
    {
        public static void AssertStringOnLenght(string value, int MaxLenght, string propertyName)
        {
            if (value.Length > MaxLenght)
            {
                throw new ArgumentException(propertyName + " должен быть меньше " + MaxLenght.ToString() + " символов.");
            }
        }
        public static void CheckStringOnNullOrEmpty(string str, string propertyName)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("свойство " + propertyName + " не должно быть null или пустым");
            }
        }
    }
}
