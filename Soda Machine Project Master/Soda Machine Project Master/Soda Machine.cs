using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
                Inventory.Add(new Root_Beer());
            }
            for (int i = 0; i < 4; i++)
            {
                Inventory.Add(new Cola());
            }
            for (int i = 0; i < 4; i++)
            {
                Inventory.Add(new Orange_Soda());
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

        public  SellASoda(string sodaSelection, List<Coin> payment)
        {
            double sodaValue;
            double sodaChange;
            double sodaCost;
            string sodaSelection;

            Register;
            Inventory;

            List<string> sodas = new List<string>() { "Grape, Orange, Lemon" };

            //constructor 

            public SodaMachine()
            {
                List<Coin> coins = new List<Coin>();


            }


            //methods 


            public double PaymentForSoda()
            {

                if (sodaCost == sodaValue)
                {
                    Console.WriteLine("Enjoy your drink!");
                    DispenseSoda();
                }
                else if (sodaCost > sodaValue)
                {
                    sodaChange = sodaValue - sodaCost;
                    DispenseSoda(sodaChange);
                    Console.WriteLine("Here is your change and enjoy your soda.");
                    return sodaChange;
                }
                else if (sodaCost < sodaValue)
                {
                    sodaChange = sodaCost - sodaValue;
                    Console.WriteLine("Please enter the correct change");
                    return sodaChange;
                }
            }

            public void ChangeFromRegister()
            {


            }

            public string DispenseSoda(double value)
            {
                if (value == .6)
                {
                    return sodas[0];
                }
                else if (value == .35)
                {
                    return sodas[1];
                }
                else if (value == .06)
                {
                    return sodas[2];
                }
            }
        }
    }


    //Check if stock of sodaSelection exists
    //Find cost of selection
    //Compare value of payment to cost of selection: greater than? less than? equal?
    //Coins from payment get added to register if sale is successful


}
        

        public void CheckStock(string sodaSelection)//"Cola"
        {
            
            
            
            //loop through Inventory and compare sodaSelection to the name of each can
            //Return true if we find a can whose name matches sodaSelection
            //foreach loop
        }
            //function takes in a list of coins and returns the double value of that list
             //List with two quarters passed in should return .5
    }
}
