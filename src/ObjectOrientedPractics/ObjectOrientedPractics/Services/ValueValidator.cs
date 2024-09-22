namespace ObjectOrientedPractics
{ 
    internal class ValueValidator
    {
        public static string AssertStringOnLenght(string value, int MaxLenght, string propertyName)
        {
            if (value.Length < MaxLenght)
            {
                throw new ArgumentException(propertyName + "должен быть меньше" + MaxLenght.ToString()+ "символов.");
            }
            return value;
        }
    }
}
