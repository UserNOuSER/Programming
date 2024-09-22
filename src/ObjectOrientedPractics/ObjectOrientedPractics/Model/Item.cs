using System.ComponentModel.DataAnnotations;

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
        [Required]
        public string Name
        {
            get { return _name; } 
            set { _name = ValueValidator.AssertStringOnLenght(value, 200, "Name"); }
        }
        [Required]
        public string Info
        { 
            get { return _info; } 
            set { _info = ValueValidator.AssertStringOnLenght(value, 1000, "Info"); }
        }
        [Required]
        [Range(0,100000)]
        public float Cost
        { 
            get { return _cost; } 
            set { _cost = value; }
        }

        public Item(string name, string info, float cost)
        {
            int Id = IDGenerator.GetNextId();
            Name = name;  
            Info = info;
            Cost = cost;
        }
    }
}