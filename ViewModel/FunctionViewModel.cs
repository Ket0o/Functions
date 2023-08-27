using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Model.Classes;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для Function.
    /// </summary>
    public class FunctionViewModel: ObservableObject
    {
        /// <summary>
        /// Функция.
        /// </summary>
        public Function Function { get; } = new();

        /// <summary>
        /// Возвращает и задает коэффициент A.
        /// </summary>
        public double CoefficientA
        {
            get => Function.CoefficientA;
            set
            {
                Function.CoefficientA = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент B.
        /// </summary>
        public double CoefficientB
        {
            get => Function.CoefficientB;
            set
            {
                Function.CoefficientB = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент X.
        /// </summary>
        public double CoefficientX
        {
            get => Function.CoefficientX;
            set
            {
                Function.CoefficientX = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент Y.
        /// </summary>
        public double CoefficientY
        {
            get => Function.CoefficientY;
            set
            {
                Function.CoefficientY = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает коэффициент C.
        /// </summary>
        public int CoefficientC
        {
            get => Function.CoefficientC;
            set
            {
                Function.CoefficientC = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает список коэффициента C.
        /// </summary>
        public virtual int[] TypeCoefficientC
        {
            get => Function.TypeCoefficientC;
        }

        /// <summary>
        /// Возвращает и задает значение функции.
        /// </summary>
        public virtual double ValueFunction
        {
            get => Function.ValueFunction;
        }
    }
}
