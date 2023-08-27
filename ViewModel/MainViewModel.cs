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

        private FunctionViewModel _selectedFun�tion;

        [RelayCommand]
        private void AddFunction()
        {
            AllFunctions.Add(SelectedFun�tion);
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
                }
                else
                {
                    // TODO: �������� ��� ������ � ����� � ���� ����� � ��������� �������� 
                }
                OnPropertyChanged();
            }
        }

        public FunctionViewModel SelectedFun�tion
        {
            get => _selectedFun�tion;
            set
            {
                _selectedFun�tion = value;
                OnPropertyChanged();
            }
        }
    }
}
