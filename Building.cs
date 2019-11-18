using System;

namespace Planner
{
    class Building
    {
        // Fields
        private string _designer = "Lauren";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // Properties
        public int Stories { get; set; }
        public double Width { get; set; }

        public double Depth { get; set; }

        // Computed Properties 
        public double Volume
        {
            get
            {
                double totalVolume;
                totalVolume = Width * Depth * (3 * Stories);
                return totalVolume;
            }

        }
        // Constructor
        public Building(string address)
        {
            _address = address;
        }
        // Public Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }
        public string Print()
        {
            return $"Designed by {_designer} \n Constructed on {_dateConstructed} \n Owned by {_owner} \n {Volume} cubic meters of space.";
        }
    }
}
