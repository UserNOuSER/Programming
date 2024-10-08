﻿namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;  
        /// <summary>
        /// Имя покупателя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;
        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        /// 
        public int Id 
        { 
            get { return _id; } 
        }

        /// <summary>
        /// Возвращает и задает имя покупателя. Должно быть непустым и короче 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set 
            {
                ValueValidator.AssertStringOnLenght(value, 200, nameof(Fullname)); 
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя. Должно быть непустым и короче 500 символов.
        /// </summary>
        public string Address
        { 
            get { return _address; } 
            set 
            {
                ValueValidator.AssertStringOnLenght(value, 500, nameof(Address));
                ValueValidator.CheckStringOnNullOrEmpty(value, nameof(Address));
                _address = value;
            } 
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="Fullname">Имя покупателя. По умолчанию - "Fullname".</param>
        /// <param name="Address">Адрес покупателя. По умолчанию - "Address".</param>
        /// <param name="_id">Уникальный идентификатор. Класс не контролирует уникальность присвоенного id.</param>
        public Customer()
        {  
            _id = IDGenerator.GetNextId();
            Fullname = "Fullname";
            Address = "Address";
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="Fullname">Имя покупателя. Должно быть непустым и короче 200 символов.</param>
        /// <param name="Info">Адрес покупателя. Должно быть непустым и короче 500 символов.</param>
        /// <param name="_id">Уникальный идентификатор. Класс не контролирует уникальность присвоенного id.</param>
        public Customer(string fullname, string address)
        {
            _id = IDGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }
        /// <summary>
        /// Возвращает имя покупателя
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => _fullname;
    }
}
