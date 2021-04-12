using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    public class Calc
    {


        public double GetSum(double firstNumb, double secondNumb)
        {
            return firstNumb + secondNumb;
        }

        public double GetDiv(double firstNumb, double secondNumb)
        {
            if (secondNumb == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNumb / secondNumb;
        }

        public double GetSub(double firstNumb, double secondNumb)
        {
            return firstNumb - secondNumb;
        }

        public double GetMult(double firstNumb, double secondNumb)
        {
            return firstNumb * secondNumb;
        }


    }
}
