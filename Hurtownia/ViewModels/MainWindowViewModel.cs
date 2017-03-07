using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using Magazyn;
using Magazyn.View;

namespace Hurtownia.ViewModels
{
    class MainWindowViewModel
    {
        private RelayCommand _addContractorCommand;

        public RelayCommand AddContractorCommand
        {
            get
            {
                if (_addContractorCommand == null)
                    _addContractorCommand = new RelayCommand(ExecuteAddContractorCommandAction);
                return _addContractorCommand;
            }
        }

        private void ExecuteAddContractorCommandAction()
        {
            new AddContractorView().Show();
        }

        private RelayCommand _showContractorListCommand;

        public RelayCommand ShowContractorListCommand
        {
            get
            {
                if (_showContractorListCommand == null)
                    _showContractorListCommand = new RelayCommand(ExecuteShowContractorListCommandAction);
                return _showContractorListCommand;
            }
        }

        private void ExecuteShowContractorListCommandAction()
        {
            new MainView().Show();
        }

        private RelayCommand _showInfoCommand;

        public RelayCommand ShowInfoCommand
        {
            get
            {
                if (_showInfoCommand == null)
                    _showInfoCommand = new RelayCommand(ExecuteShowInfoCommandAction);
                return _showInfoCommand;
            }
        }

        private void ExecuteShowInfoCommandAction()
        {
            MessageBox.Show("Witaj w Hurtowni");
        }
    }
}
