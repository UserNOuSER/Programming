namespace ObjectOrientedPractics
{
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private float _cost;

        public int Id
        {
            get { return _id; }
        }
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
        
        public float Cost
        { 
            get { return _cost; } 
            set 
            {   
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("cost should be >= 0");
                }
                if (value > 100000)
                {
                    throw new ArgumentOutOfRangeException("cost should be <= 100000");
                }
                _cost = value; 
            }
        }

        public Item()
        {
            _id = IDGenerator.GetNextId();
            Name = "name";
            Info = "info";
            Cost = 0;
        }

        public Item(string name, string info, float cost)
        {
            _id = IDGenerator.GetNextId();  
            Name = name;  
            Info = info;
            Cost = cost;
        }
        public override string ToString() => _name;
    }
    
}