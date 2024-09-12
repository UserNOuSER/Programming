using System.ComponentModel.DataAnnotations;

namespace ObjectOrientedPractics
{
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public int Id
        {
            get { return _id; }
        }
        [Required]
        [StringLength(200)]
        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }
        [Required]
        [StringLength(1000)]
        public string Info
        { 
            get { return _info; } 
            set { _info = value; }
        }
        [Required]
        [Range(0,100000)]
        public double Cost
        { 
            get { return _cost; } 
            set { _cost = value; }
        }
    }
}