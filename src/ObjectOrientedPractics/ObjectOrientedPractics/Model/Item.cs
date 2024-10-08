namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;
        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private float _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает название товара. Должно быть непустым и короче 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; } 
            set 
            { 
                ValueValidator.AssertStringOnLenght(value, 200, nameof(Name));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Name)); 
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает описание товара. Должно быть непустым и короче 1000 символов.
        /// </summary>
        public string Info
        { 
            get { return _info; } 
            set 
            {
                ValueValidator.AssertStringOnLenght(value, 1000, nameof(Info));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Info));
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и задает цену товара. Должна быть больше нуля и менее 100000.
        /// </summary>
        public float Cost
        { 
            get { return _cost; } 
            set 
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value, 100000);
                _cost = value; 
            }
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="Name">Название товара. По умолчанию - "name".</param>
        /// <param name="Info">Описание товара. По умолчанию - "info".</param>
        /// <param name="Cost">Цена товара. По умолчанию - 0.</param>
        /// <param name="_id">Уникальный идентификатор. Класс не контролирует уникальность присвоенного id.</param>
        public Item()
        {
            _id = IDGenerator.GetNextId();
            Name = "name";
            Info = "info";
            Cost = 0;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="Name">Название товара. Должно быть непустым и короче 200 символов.</param>
        /// <param name="Info">Описание товара. Должно быть непустым и короче 1000 символов.</param>
        /// <param name="Cost">Цена товара. Должна быть больше нуля и менее 100000.</param>
        /// <param name="_id">Уникальный идентификатор. Класс не контролирует уникальность присвоенного id.</param>
        public Item(string name, string info, float cost)
        {
            _id = IDGenerator.GetNextId();  
            Name = name;  
            Info = info;
            Cost = cost;
        }
        /// <summary>
        /// Возвращает имя товара
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => _name;
    }
    
}