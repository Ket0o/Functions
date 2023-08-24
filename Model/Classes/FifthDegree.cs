using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model.Classes
{
    public class FifthDegree : Function
    {
        public override double ValueFunction => CoefficientA * Math.Pow(CoefficientX, 
            (double)Functions.FifthDegree) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.FourthDegree) + CoefficientC;

        public override int[] TypeCoefficientC => new int[5] { 10000, 20000, 30000, 40000, 50000 };

        public FifthDegree() 
        {
            NameFunction = Functions.FifthDegree.ToString();
        }
    }
}
