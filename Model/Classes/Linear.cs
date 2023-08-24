using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Linear: Function
    {
        public override double ValueFunction => CoefficientA * CoefficientX 
            + CoefficientB + CoefficientC;

        public override int[] TypeCoefficientC 
        { 
            get => new int[5] {1, 2, 3, 4, 5};
        }

        public Linear() 
        {
            NameFunction = Functions.Linear.ToString();
        }
    }
}
