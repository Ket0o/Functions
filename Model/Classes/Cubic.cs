using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Cubic : Function
    {
        //public override double ValueFunction => CoefficientA * Math.Pow(CoefficientX, 
        //    (double)Functions.Cubic) + CoefficientB * Math.Pow(CoefficientY, 
        //        (double)Functions.Quadratic) + CoefficientC;

        public override int[] TypeCoefficientC => new int[5] { 100, 200, 300, 400, 500 };

        public Cubic() 
        {
            NameFunction = Functions.Cubic.ToString();
        }
    }
}
