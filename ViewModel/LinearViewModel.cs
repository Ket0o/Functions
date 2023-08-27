using Model.Classes;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LinearViewModel: FunctionViewModel
    {
        readonly Linear linear = new();

        public override double ValueFunction
        {
            get => CoefficientA * CoefficientX
            + CoefficientB + CoefficientC;
        }

        public new string NameFunction 
        { 
            get => linear.NameFunction;
        }

        public override int[] TypeCoefficientC
        {
            get => linear.TypeCoefficientC;
        }

        public LinearViewModel() 
        {
 
        }
    }
}
