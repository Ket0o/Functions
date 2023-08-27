using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    /// <summary>
    /// Хранит данные о кубической функции.
    /// </summary>
    public class Cubic : Function
    {
        /// <summary>
        /// Возвращает и задает список коэффициента C для кубической функции.
        /// </summary>
        public override int[] TypeCoefficientC => new int[5] 
        {
            100, 200, 300, 400, 500 
        };

        /// <summary>
        /// Создает экземпляр класса <see cref="Cubic"/>.
        /// </summary>
        public Cubic() 
        {
            NameFunction = Functions.Cubic.ToString();
        }
    }
}
