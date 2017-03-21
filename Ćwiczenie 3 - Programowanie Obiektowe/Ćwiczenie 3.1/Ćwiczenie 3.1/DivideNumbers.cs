using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_3._1
{
    class DivideNumbers
    {
        public Double DivideNumber(double a, double b)
        {
            if(b==0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return a / b;
            }
            
        }
    }
}
