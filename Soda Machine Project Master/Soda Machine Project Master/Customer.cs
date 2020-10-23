using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine_Project_Master
{
    class Customer
    {
        public Customer()
        {
            Wallet = new Wallet();
            BackPack = new BackPack();
        }
       Wallet Wallet
        { get;set; }

       BackPack BackPack
       { get; set; }
    }
}
