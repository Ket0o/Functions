using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model.Classes
{
    /// <summary>
    /// Хранит данные о квадратичной функции.
    /// </summary>
    public class Quadratic : Function
    {
        /// <summary>
        /// Возвращает и задает список коэффициента C 
        /// для квадратичной функции.
        /// </summary>
        public override int[] TypeCoefficientC => new int[5] 
        { 
            10, 20, 30, 40, 50 
        };

        /// <summary>
        /// Создает экземпляр класса <see cref="Quadratic"/>.
        /// </summary>
        public Quadratic() 
        {
            NameFunction = Functions.Quadratic.ToString();
        }
    }
}
