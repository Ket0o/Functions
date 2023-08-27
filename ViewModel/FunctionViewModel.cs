using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Model.Classes;

namespace ViewModel
{
    public class FunctionViewModel: ObservableObject
    {
        readonly Function function = new();

        public string NameFunction
        {
            get => function.NameFunction;
        }

        public double CoefficientA
        {
            get => function.CoefficientA;
            set
            {
                function.CoefficientA = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        public double CoefficientB
        {
            get => function.CoefficientB;
            set
            {
                function.CoefficientB = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        public double CoefficientX
        {
            get => function.CoefficientX;
            set
            {
                function.CoefficientX = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        public double CoefficientY
        {
            get => function.CoefficientY;
            set
            {
                function.CoefficientY = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        public int CoefficientC
        {
            get => function.CoefficientC;
            set
            {
                function.CoefficientC = value;
                OnPropertyChanged(nameof(ValueFunction));
                OnPropertyChanged();
            }
        }

        public virtual int[] TypeCoefficientC
        {
            get => function.TypeCoefficientC;
        }

        public virtual double ValueFunction
        {
            get => function.ValueFunction;
        }

        public FunctionViewModel()
        {

        }
    }
}
