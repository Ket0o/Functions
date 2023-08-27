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
    /// ViewModel ��� �������� ����.
    /// </summary>
    public partial class MainViewModel : ObservableObject
    {
        /// <summary>
        /// ������, ����������� ����������: ����������, ��������������, ������������, 
        /// �4-�� �������, �5-�� �������.
        /// </summary>
        [ObservableProperty]
        private string[] _functionsName = Enum.GetNames(typeof(Functions));

        /// <summary>
        /// �������� ��� ���������� ��������� ����������������� ����������.
        /// </summary>
        [ObservableProperty]
        private bool _isEnabled = false;

        /// <summary>
        /// ��������� �������.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<FunctionViewModel> _allFunctions = 
            new ObservableCollection<FunctionViewModel>();

        /// <summary>
        /// ��������� �������� ������� �� ������.
        /// </summary>
        private string _functionName;

        /// <summary>
        /// ��������� �������.
        /// </summary>
        [ObservableProperty]
        private FunctionViewModel _selectedFun�tion;

        /// <summary>
        /// ������ ������� <see cref="AddFunctionCommand"/>.
        /// </summary>
        [RelayCommand]
        private void AddFunction()
        {
            if (!AllFunctions.Contains(SelectedFun�tion))
            {
                AllFunctions.Add(SelectedFun�tion);
            }
            else
            {
                IsEnabled = false;
            }
        }

        /// <summary>
        /// ���������� � ������ ��������� �������� ������� �� ������.
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
                        SelectedFun�tion = new LinearViewModel();
                    }
                    else if (_functionName == Functions.Quadratic.ToString())
                    {
                        SelectedFun�tion = new QuadraticViewModel();
                    }
                    else if (_functionName == Functions.Cubic.ToString())
                    {
                        SelectedFun�tion= new CubicViewModel();
                    }
                    else if (_functionName == Functions.FourthDegree.ToString())
                    {
                        SelectedFun�tion = new FourthDegreeViewModel();
                    }
                    else if (_functionName == Functions.FifthDegree.ToString())
                    {
                        SelectedFun�tion = new FifthDegreeViewModel();
                    }
                }
                else 
                {
                    SelectedFun�tion = null;
                }
                OnPropertyChanged();
            }
        }
    }
}
