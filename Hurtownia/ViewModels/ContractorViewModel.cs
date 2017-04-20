using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Kontrachent;
using Kontrachent.View;

namespace Hurtownia.ViewModels
{
    class ContractorViewModel:ViewModelBase
    {
       

        public ContractorViewModel()
        {
            
        }

        

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

        private RelayCommand _showMainWindowCommand;

        public RelayCommand ShowMainWindowCommand
        {
            get
            {
                if (_showMainWindowCommand == null)
                    _showMainWindowCommand = new RelayCommand(ExecuteShowMainWindowCommandAction);
                return _showMainWindowCommand;
            }
        }

        private void ExecuteShowMainWindowCommandAction()
        {
            
        }
    }
}
