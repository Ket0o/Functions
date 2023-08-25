using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LinearViewModel: FunctionViewModel
    {
        Linear linear = new();

        public double ValueFunction
        {
            get => linear.ValueFunction;
        }

        public int[] TypeCoefficientC
        {
            get => linear.TypeCoefficientC;
        }

        public LinearViewModel() { }
    }
}
