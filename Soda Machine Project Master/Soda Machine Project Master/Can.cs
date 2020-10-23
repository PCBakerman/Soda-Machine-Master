using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine_Project_Master
{
    abstract class Can
    {
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                 $"{nameof(value)} must be larger than 0.");
                }
            }
        }
        private double cost;
        public string Name
        { get; set; }
    }
}
