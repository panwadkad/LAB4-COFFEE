using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_COFFEE
{
    internal class Make_Coffee
    {
        //การประกาศตัวแปร
        int water;
        int coffee;
        int milk;
        int chocolate;

        public  Make_Coffee()
        {
            //การกำหนดค่าสิ่งที่เราจะทำ
            water = 500;
            coffee = 500;
            milk = 500;
            chocolate = 500;

        }

        public bool markBlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                //can make coffee
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        public bool markMocha()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                //can make coffee
                water = water - 300;
                coffee = coffee - 20;
                chocolate = chocolate - 10;
                return true;
            }
            else
            {
                return false;
            }

        }

        
        public bool markLatte()
        {
            if (water >= 300 && coffee >= 20 && milk >= 10)
            {
                //can make coffee
                water = water - 300;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }
            else
            {
                return false;
            }

        }

        
        public bool markChocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                //can make coffee
                water = water - 300;
                chocolate = chocolate - 20;
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
