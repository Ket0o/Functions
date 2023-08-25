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
        Function function = new();
        
        public string NameFunction
        {
            get => function.NameFunction;
            set
            {
                function.NameFunction = value;
                OnPropertyChanged();
            }
        }

        public double CoefficientA
        {
            get => function.CoefficientA;
            set
            {
                function.CoefficientA = value;
                OnPropertyChanged();
            }
        }

        public double CoefficientB
        {
            get => function.CoefficientB;
            set
            {
                function.CoefficientB = value;
                OnPropertyChanged();
            }
        }

        public double CoefficientX
        {
            get => function.CoefficientX;
            set
            {
                function.CoefficientX = value; 
                OnPropertyChanged();
            }
        }

        public double CoefficientY
        {
            get => function.CoefficientY;
            set
            {
                function.CoefficientY = value;
                OnPropertyChanged();
            }
        }

        public int CoefficientC
        {
            get => function.CoefficientC;
            set
            {
                function.CoefficientC = value;
                OnPropertyChanged();
            }
        }

        public int[] TypeCoefficientC
        {
            get => function.TypeCoefficientC;
        }

        public FunctionViewModel()
        {

        }
    }
}
