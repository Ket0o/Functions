using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Enums;

namespace Model.Classes
{
    /// <summary>
    /// Хранит данные о функции 5-ой степени.
    /// </summary>
    public class FifthDegree : Function
    {
        /// <summary>
        /// Возвращает и задает список коэффициента C 
        /// для функции 5-ой степени.
        /// </summary>
        public override int[] TypeCoefficientC => new int[5] 
        { 
            10000, 20000, 30000, 40000, 50000 
        };

        /// <summary>
        /// Создает экземпляр класса <see cref="FifthDegree"/>.
        /// </summary>
        public FifthDegree() 
        {
            NameFunction = Functions.FifthDegree.ToString();
        }
    }
}
