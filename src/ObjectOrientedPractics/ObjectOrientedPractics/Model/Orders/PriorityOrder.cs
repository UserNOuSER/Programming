namespace ObjectOrientedPractics.Model.Orders
{
    class PriorityOrder : Order
    {
        /// <summary>
        /// Список возможных временнных промеж утокв
        /// </summary>
        private static List<string> _timerangesList = new List<string> { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" };
        /// <summary>
        /// Предпочтительная дата
        /// </summary>
        private DateTime _wantedDate;
        /// <summary>
        /// Предпочтительное время
        /// </summary>
        private string _wantedTime;
        /// <summary>
        /// Свойство для временных промежутков
        /// </summary>
        public static List<string> TimeRangesList { get { return new List<string>(_timerangesList); } }
        /// <summary>
        /// Возвращает и задает предпочтителную дату
        /// </summary>
        public DateTime WantedDate
        {
            get { return _wantedDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException($"{nameof(WantedDate)} должно быть завтра или далее");
                }
                _wantedDate = value;
            }
        }
        /// <summary>
        /// Возвращает и задает предпочтительное время
        /// </summary>
        public string WantedTime
        {
            get { return _wantedTime; }
            set
            {
                if (!_timerangesList.Contains(value))
                {
                    throw new ArgumentException($"{nameof(WantedTime)} не содержится в списке возможных.");
                }
                _wantedTime = value;
            }
        }
        /// <summary>
        /// Базовые конструктор класса
        /// Желаемый день - ровно через сутки
        /// Желаемое время - "9:00 – 11:00"
        /// </summary>
        public PriorityOrder() : base()
        {
            WantedDate = DateTime.Now.AddDays(1);
            WantedTime = _timerangesList[0];
        }
        /// <summary>
        /// Конструтор класса
        /// </summary>
        /// <param name="wantedDate">Желаемый день</param>
        /// <param name="wantedTime">Желаемое время</param>
        /// <param name="address">Адрес</param>
        /// <param name="items">Товары в заказе</param>
        public PriorityOrder(DateTime wantedDate, string wantedTime, Address address, List<Item> items) : base(address, items)
        {
            WantedDate = wantedDate;
            WantedTime = wantedTime;
        }
    }
}
