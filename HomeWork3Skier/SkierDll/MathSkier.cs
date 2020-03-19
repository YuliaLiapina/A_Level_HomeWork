using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierDll
{
    public class MathSkier
    {   
        public static int CheckDay(int x, int y, int z) //method for determining the result of one skier
        {
            double X =(double)x;
            double Y = (double)y*0.01;         
            int counterdays=1;
            while(X<z)
            {
             X +=X+X*Y;
             counterdays += 2;
            }          
            return counterdays;
        }
        
   
    }
}
