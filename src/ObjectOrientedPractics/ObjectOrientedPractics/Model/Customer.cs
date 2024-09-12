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
        [StringLength(200)]
        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        [Required]
        [StringLength(500)]
        public string Address
        { 
            get { return _address; } 
            set { _address = value; } 
        }

    }
}
