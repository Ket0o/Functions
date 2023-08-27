using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model.Classes;
using Model.Enums;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string[] _functionsName = Enum.GetNames(typeof(Functions));

        [ObservableProperty]
        private ObservableCollection<FunctionViewModel> _allFunctions = 
            new ObservableCollection<FunctionViewModel>();

        private string _functionName;

        private FunctionViewModel _selectedFunñtion;

        [RelayCommand]
        private void AddFunction()
        {
            AllFunctions.Add(SelectedFunñtion);
        }

        public string FunctionName
        {
            get => _functionName;
            set
            {
                _functionName = value;
                if (_functionName != null)
                {
                    if (_functionName == Functions.Linear.ToString())
                    {
                        SelectedFunñtion = new LinearViewModel();
                    }
                    else if (_functionName == Functions.Quadratic.ToString())
                    {
                        SelectedFunñtion = new QuadraticViewModel();
                    }
                    else if (_functionName == Functions.Cubic.ToString())
                    {
                        SelectedFunñtion= new CubicViewModel();
                    }
                }
                else
                {
                    // TODO: çàëî÷èòü âñå êíîïêè è áîêñû è òîæå ñàìîå ñ âûáðàííîé ôóíêöèåé 
                }
                OnPropertyChanged();
            }
        }

        public FunctionViewModel SelectedFunñtion
        {
            get => _selectedFunñtion;
            set
            {
                _selectedFunñtion = value;
                OnPropertyChanged();
            }
        }
    }
}
