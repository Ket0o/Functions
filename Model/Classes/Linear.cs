using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    /// <summary>
    /// Хранит данные о линейной функции.
    /// </summary>
    public class Linear: Function
    {
        /// <summary>
        /// Возвращает и задает список коэффициента C для линейной функции.
        /// </summary>
        public override int[] TypeCoefficientC 
        { 
            get => new int[5] 
            {
                1, 2, 3, 4, 5
            };
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Linear"/>.
        /// </summary>
        public Linear() 
        {
            NameFunction = Functions.Linear.ToString();
        }
    }
}
