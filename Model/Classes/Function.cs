using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    /// <summary>
    /// Хранит данные о функциях.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Значение функции.
        /// </summary>
        private double _valueFunction;

        /// <summary>
        /// Список коэффициента C для каждого типа функции.
        /// </summary>
        private int[] _typeCoefficientC;

        /// <summary>
        /// Имя функции.
        /// </summary>
        public string NameFunction { get; set; }

        /// <summary>
        /// Коэффициент A.
        /// </summary>
        public double CoefficientA { get; set; }

        /// <summary>
        /// Коэффициент B.
        /// </summary>
        public double CoefficientB { get; set; }

        /// <summary>
        /// Коэффициент X.
        /// </summary>
        public double CoefficientX { get; set; }

        /// <summary>
        /// Коэффициент Y.
        /// </summary>
        public double CoefficientY { get; set; }

        /// <summary>
        /// Коэффициент C.
        /// </summary>
        public int CoefficientC { get; set; }

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public double ValueFunction
        {
            get { return _valueFunction; }
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C для каждого типа функции.
        /// </summary>
        public virtual int[] TypeCoefficientC
        {
            get { return _typeCoefficientC; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Function"/>.
        /// </summary>
        public Function()
        {

        }
    }
}
