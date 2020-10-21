using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Soda_Machine_Project_Master
{
    class Soda_Machine
    {
        public List<Coin> Register
        { get; set; }
        public List<Can> Inventory
        { get; set; }
        public Soda_Machine()
        {
            Inventory = new List<Can>();
            for (int i = 0; i < 2; i++)
            {
                Inventory.Add(new Root_Beer)(;
            }
            for (int i = 0; i < 4; i++)
            {
                Inventory.Add(new Cola);
            }
            for (int i = 0; i < 4; i++)
            {
                Inventory.Add(new Orange_Soda);
            }

            Register = new List<Coin>();
            for (int i = 0; i < 20; i++)
            {
                Register.Add(new Quarter());
                Register.Add(new Nickle());
            }
            for (int i = 0; i < 50; i++)
            {
                Register.Add(new Penny());
            }
            for (int i = 0; i < 10; i++)
            {
                Register.Add(new Dime());
            }
        }  
    }
}
