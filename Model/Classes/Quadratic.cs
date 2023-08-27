using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model.Classes
{
    public class Quadratic : Function
    {
        //public override double ValueFunction => CoefficientA * Math.Pow(CoefficientX, 
        //    (double)Functions.Quadratic) + CoefficientB * CoefficientY + CoefficientC;

        public override int[] TypeCoefficientC => new int[5] { 10, 20, 30, 40, 50 };

        public Quadratic() 
        {
            NameFunction = Functions.Quadratic.ToString();
        }
    }
}
