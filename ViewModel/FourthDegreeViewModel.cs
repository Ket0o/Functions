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
    /// ViewModel для FourthDegree.
    /// </summary>
    public class FourthDegreeViewModel : FunctionViewModel
    {
        /// <summary>
        /// Функция четвертой степени.
        /// </summary>
        public FourthDegree FourthDegree { get; } = new();

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.FourthDegree) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.Cubic) + CoefficientC;
        }

        /// <summary>
        /// Возвращает и задает имя функции.
        /// </summary>
        public string NameFunction
        {
            get => FourthDegree.NameFunction;
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C.
        /// </summary>
        public override int[] TypeCoefficientC
        {
            get => FourthDegree.TypeCoefficientC;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="FourthDegreeViewModel"/>.
        /// </summary>
        public FourthDegreeViewModel()
        {

        }
    }
}
