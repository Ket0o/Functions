using Model.Classes;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace ViewModel
{
    public class QuadraticViewModel : FunctionViewModel
    {
        readonly Quadratic quadratic = new();

        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.Quadratic) + CoefficientB * CoefficientY + CoefficientC;
        }

        public new string NameFunction
        {
            get => quadratic.NameFunction;
        }

        public override int[] TypeCoefficientC
        {
            get => quadratic.TypeCoefficientC;
        }

        public QuadraticViewModel()
        {

        }
    }
}
