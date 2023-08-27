using Model.Classes;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FourthDegreeViewModel : FunctionViewModel
    {
        readonly FourthDegree fourthDegree = new();

        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.FourthDegree) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.Cubic) + CoefficientC;
        }

        public new string NameFunction
        {
            get => fourthDegree.NameFunction;
        }

        public override int[] TypeCoefficientC
        {
            get => fourthDegree.TypeCoefficientC;
        }

        public FourthDegreeViewModel()
        {

        }
    }
}
