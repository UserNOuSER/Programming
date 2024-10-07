namespace ObjectOrientedPractics
{
    internal class Customer
    {
        private readonly int _id;  
        private string _fullname;
        private string _address;
        public int Id 
        { 
            get { return _id; } 
        }
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
        public Customer()
        {  
            _id = IDGenerator.GetNextId();
            Fullname = "Fullname";
            Address = "Address";
        }

        public Customer(string fullname, string address)
        {
            _id = IDGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }
        public override string ToString() => _fullname;
    }
}
