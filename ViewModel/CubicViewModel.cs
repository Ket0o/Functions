using Model.Classes;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CubicViewModel : FunctionViewModel
    {
        readonly Cubic qubic = new();

        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.Cubic) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.Quadratic) + CoefficientC;
        }

        public new string NameFunction
        {
            get => qubic.NameFunction;
        }

        public override int[] TypeCoefficientC
        {
            get => qubic.TypeCoefficientC;
        }

        public CubicViewModel()
        {

        }
    }
}
