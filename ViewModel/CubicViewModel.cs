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
    /// ViewModel для Cubic.
    /// </summary>
    public class CubicViewModel : FunctionViewModel
    {
        /// <summary>
        /// Кубическая функция.
        /// </summary>
        public Cubic Qubic { get; } = new();

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.Cubic) + CoefficientB * Math.Pow(CoefficientY, 
                (double)Functions.Quadratic) + CoefficientC;
        }

        /// <summary>
        /// Возвращает и задает имя функции.
        /// </summary>
        public string NameFunction
        {
            get => Qubic.NameFunction;
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C.
        /// </summary>
        public override int[] TypeCoefficientC
        {
            get => Qubic.TypeCoefficientC;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CubicViewModel"/>.
        /// </summary>
        public CubicViewModel()
        {

        }
    }
}
