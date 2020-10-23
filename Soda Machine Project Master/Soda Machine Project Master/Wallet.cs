using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Soda_Machine_Project_Master
{
    class Wallet 
    {
        public List<Coin> PocketChange
        { get; set; }
        public Wallet()
        {
            for (int i = 0; i < 15; i++)
            {
                PocketChange.Add(new Penny());
                PocketChange.Add(new Nickle());
            }
            for (int i = 0; i < 12; i++)
            {
                PocketChange.Add(new Quarter());
            }
            for (int i = 0; i < 10; i++)
            {
                PocketChange.Add(new Dime());
            }
        }
    }
}

