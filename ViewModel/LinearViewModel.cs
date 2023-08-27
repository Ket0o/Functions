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
    /// ViewModel для Linear.
    /// </summary>
    public class LinearViewModel: FunctionViewModel
    {
        /// <summary>
        /// Линейная функция.
        /// </summary>
        public Linear Linear { get; } = new();

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public override double ValueFunction
        {
            get => CoefficientA * CoefficientX
            + CoefficientB + CoefficientC;
        }

        /// <summary>
        /// Возвращает и задает имя функции.
        /// </summary>
        public string NameFunction
        {
            get => Linear.NameFunction;
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C.
        /// </summary>
        public override int[] TypeCoefficientC
        {
            get => Linear.TypeCoefficientC;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="LinearViewModel"/>.
        /// </summary>
        public LinearViewModel() 
        {
 
        }
    }
}
