using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model.Classes
{
    public class FourthDegree : Function
    {
        //public override double ValueFunction => CoefficientA * Math.Pow(CoefficientX,
        //    (double)Functions.FourthDegree) + CoefficientB * Math.Pow(CoefficientY, 
        //        (double)Functions.Cubic) + CoefficientC;

        public override int[] TypeCoefficientC => new int[5] { 1000, 2000, 3000, 4000, 5000 };

        public FourthDegree() 
        {
            NameFunction = Functions.FourthDegree.ToString();
        }
    }
}
