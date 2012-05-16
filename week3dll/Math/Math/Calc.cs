using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hub3r
{
    public class Calc
    {
        public int Add(int y, int x)
        {
            return x + y;
        }
        public int Subtract(int y, int x)
        {
            return y - x;
        }
        public int Multiply(int y, int x)
        {
            return x * y;
        }
        public int Divide(int y, int x)
        {
            if (y == 0)
            {
                throw new Exception("You tried to divide by zero!");
            }
            return x / y;
        }
        
    }
  
}
