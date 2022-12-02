using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    internal interface Item
    {
        
        int GetPrice();
    }

    public class Cola : Item
    {
        public int GetPrice()
        {
            return 11;
        }
    }
    public class Kinly : Item
    {
        public int GetPrice()
        {
            return 10;
        }
    }
}
