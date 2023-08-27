using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model.Classes;
using Model.Enums;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainViewModel : ObservableObject
    {
        /// <summary>
        /// Список, заполненный элементами: «линейная», «квадратичная», «кубическая», 
        /// «4-ой степени», «5-ой степени».
        /// </summary>
        [ObservableProperty]
        private string[] _functionsName = Enum.GetNames(typeof(Functions));

        /// <summary>
        /// Свойство для блокировки элементов пользовательского интерфейса.
        /// </summary>
        [ObservableProperty]
        private bool _isEnabled = false;

        /// <summary>
        /// Коллекция функций.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<FunctionViewModel> _allFunctions = 
            new ObservableCollection<FunctionViewModel>();

        /// <summary>
        /// Выбранное название функции из списка.
        /// </summary>
        private string _functionName;

        /// <summary>
        /// Выбранная функция.
        /// </summary>
        [ObservableProperty]
        private FunctionViewModel _selectedFunсtion;

        /// <summary>
        /// Логика команды <see cref="AddFunctionCommand"/>.
        /// </summary>
        [RelayCommand]
        private void AddFunction()
        {
            if (!AllFunctions.Contains(SelectedFunсtion))
            {
                AllFunctions.Add(SelectedFunсtion);
            }
            else
            {
                IsEnabled = false;
            }
        }

        /// <summary>
        /// Возвращает и задает выбранное название функции из списка.
        /// </summary>
        public string FunctionName
        {
            get => _functionName;
            set
            {
                _functionName = value;
                if (_functionName != null)
                {
                    IsEnabled = true;
                    if (_functionName == Functions.Linear.ToString())
                    {
                        SelectedFunсtion = new LinearViewModel();
                    }
                    else if (_functionName == Functions.Quadratic.ToString())
                    {
                        SelectedFunсtion = new QuadraticViewModel();
                    }
                    else if (_functionName == Functions.Cubic.ToString())
                    {
                        SelectedFunсtion= new CubicViewModel();
                    }
                    else if (_functionName == Functions.FourthDegree.ToString())
                    {
                        SelectedFunсtion = new FourthDegreeViewModel();
                    }
                    else if (_functionName == Functions.FifthDegree.ToString())
                    {
                        SelectedFunсtion = new FifthDegreeViewModel();
                    }
                }
                else 
                {
                    SelectedFunсtion = null;
                }
                OnPropertyChanged();
            }
        }
    }
}
