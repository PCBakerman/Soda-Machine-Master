using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Soda_Machine_Project_Master
{
    abstract class Coin
    {
        //memeber variables
        public double CoinValue
        {
            get
            {
                return coinValue;
            }
            set
            {
                if (value > 0)
                {
                    coinValue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                 $"{nameof(value)} must be larger than 0.");
                }
            }
        }
        private double coinValue;
        public string Name
        { get; set; }
    }
}