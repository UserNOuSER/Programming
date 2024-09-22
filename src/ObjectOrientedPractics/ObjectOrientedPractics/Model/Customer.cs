using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = ValueValidator.AssertStringOnLenght(value, 200, "Fullname"); }
        }
        [Required]
        public string Address
        { 
            get { return _address; } 
            set { _address = ValueValidator.AssertStringOnLenght(value, 500, "Address"); } 
        }
        public Customer(string fullname, string address)
        {
            int Id = IDGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }
    }
}
