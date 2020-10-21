using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine_Project_Master
{
    class BackPack
    {
        public List<Can> Can = new List<Can>();
        public int Inventory { get { return Can.Count; } }
    } 
}
       
