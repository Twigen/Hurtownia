using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using Kontrachent;
using Kontrachent.View;
using Magazyn;
using Magazyn.DictionariesWindow;
using Magazyn.MainWindow;

namespace Hurtownia.ViewModels
{
    class MainWindowViewModel
    {

        public RelayCommand<Window> CloseWindowCommand { get; private set; }

        public MainWindowViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<Window>(this.CloseWindow);
        }

        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                new ContractorWindow().Show();
                window.Close();
                
            }
        }

        private RelayCommand _showContractorCommand;

        public RelayCommand ShowContractorCommand
        {
            get
            {
                if (_showContractorCommand == null)
                    _showContractorCommand = new RelayCommand(ExecuteShowContractorCommandAction);
                return _showContractorCommand;
            }
        }

        private void ExecuteShowContractorCommandAction()
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

        private RelayCommand _magInfoCommand;

        public RelayCommand MagInfoCommand
        {
            get
            {
                if (_magInfoCommand == null)
                    _magInfoCommand = new RelayCommand(ExecuteMagInfoCommandAction);
                return _magInfoCommand;
            }
        }

        private void ExecuteMagInfoCommandAction()
        {
            MessageBox.Show("Nie oprogramowano");
        }

        private RelayCommand _openStorehouseListCommand;

        public RelayCommand OpenStorehouseListCommand
        {
            get
            {
                if (_openStorehouseListCommand == null)
                    _openStorehouseListCommand = new RelayCommand(ExecuteOpenStorehouseListCommandAction);
                return _openStorehouseListCommand;
            }
        }

        private void ExecuteOpenStorehouseListCommandAction()
        {
            new ListStorehouseItemsWindow().Show();
        }

        private RelayCommand _showAddStorehouseItemCommand;

        public RelayCommand ShowAddStorehouseItemCommand
        {
            get
            {
                if (_showAddStorehouseItemCommand == null)
                    _showAddStorehouseItemCommand = new RelayCommand(ExecuteShowAddStorehouseItemCommandAction);
                return _showAddStorehouseItemCommand;
            }
        }

        private void ExecuteShowAddStorehouseItemCommandAction()
        {
            new AddStorehouseItem().Show();
        }

        private RelayCommand _showStorehouseDictionariesCommand;

        public RelayCommand ShowStorehouseDictionariesCommand
        {
            get
            {
                if (_showStorehouseDictionariesCommand == null)
                    _showStorehouseDictionariesCommand = new RelayCommand(ExecuteShowStorehouseDictionariesCommandAction);
                return _showStorehouseDictionariesCommand;
            }
        }

        private void ExecuteShowStorehouseDictionariesCommandAction()
        {
            new DisplayDictionariesWindow().Show();
        }
    }
}
