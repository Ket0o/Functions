using Model.Classes;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FifthDegreeViewModel : FunctionViewModel
    {
        readonly FifthDegree fifthDegree = new();

        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.FifthDegree) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.FourthDegree) + CoefficientC;
        }

        public new string NameFunction
        {
            get => fifthDegree.NameFunction;
        }

        public override int[] TypeCoefficientC
        {
            get => fifthDegree.TypeCoefficientC;
        }

        public FifthDegreeViewModel()
        {

        }
    }
}
