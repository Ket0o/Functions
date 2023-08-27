using Model.Classes;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для FifthDegree.
    /// </summary>
    public class FifthDegreeViewModel : FunctionViewModel
    {
        /// <summary>
        /// Функция пятой степени.
        /// </summary>
        public FifthDegree FifthDegree { get; } = new();

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.FifthDegree) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.FourthDegree) + CoefficientC;
        }

        /// <summary>
        /// Возвращает и задает имя функции.
        /// </summary>
        public string NameFunction
        {
            get => FifthDegree.NameFunction;
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C.
        /// </summary>
        public override int[] TypeCoefficientC
        {
            get => FifthDegree.TypeCoefficientC;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="FifthDegreeViewModel"/>.
        /// </summary>
        public FifthDegreeViewModel()
        {

        }
    }
}
