using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Function
    {
        public string NameFunction { get; set; }

        //TODO: как переопределить в наследниках set
        private double _valueFunction;

        public double CoefficientA { get; set; }

        public double CoefficientB { get; set; }

        public double CoefficientX { get; set; }

        public double CoefficientY { get; set; }

        public int CoefficientC { get; set; }

        private int[] _typeCoefficientC;
        public virtual double ValueFunction
        {
            get { return _valueFunction; }
        }

        public virtual int[] TypeCoefficientC
        {
            get { return _typeCoefficientC; }
        }

        public Function()
        {

        }
    }
}
