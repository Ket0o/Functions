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
    /// <summary>
    /// ViewModel для Quadratic.
    /// </summary>
    public class QuadraticViewModel : FunctionViewModel
    {
        /// <summary>
        /// Квадратичная функция.
        /// </summary>
        public Quadratic quadratic { get; } = new();

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public override double ValueFunction
        {
            get => CoefficientA * Math.Pow(CoefficientX,
            (double)Functions.Quadratic) + CoefficientB * CoefficientY + CoefficientC;
        }

        /// <summary>
        /// Возвращает и задает имя функции.
        /// </summary>
        public string NameFunction
        {
            get => quadratic.NameFunction;
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C.
        /// </summary>
        public override int[] TypeCoefficientC
        {
            get => quadratic.TypeCoefficientC;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="QuadraticViewModel"/>.
        /// </summary>
        public QuadraticViewModel()
        {

        }
    }
}
