using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using HurtowniaDB.Repositories;
using Magazyn.Mappers;
using GalaSoft.MvvmLight.Command;
using Magazyn.MainWindow;

namespace Magazyn.ViewModels
{
    class ListStorehouseItemsViewModel :ViewModelBase
    {
        private StorehouseRepository _storehouseRepository;
        public ListStorehouseItemsViewModel()
        {
            _storehouseRepository = new StorehouseRepository();
            Storehouses =
                new ObservableCollection<StorehouseViewModel>(
                    _storehouseRepository.GetStorehouseItems().Select(p => StorehouseMappers.ConvertToStorehouseItemViewModel(p)));
        }

        private const string _storehousesPropertyName = "Storehouses";
        private ObservableCollection<StorehouseViewModel> _storehouses;

        public ObservableCollection<StorehouseViewModel> Storehouses
        {
            get { return _storehouses; }
            set
            {
                _storehouses = value;
                RaisePropertyChanged(_storehousesPropertyName);
            }
        }

        private const string _SelectedStorehouseItemPropertyName = "SelectedStorehouseItem";
        private StorehouseViewModel _SelectedStorehouseItem;

        public StorehouseViewModel SelectedStorehouseItem
        {
            get { return _SelectedStorehouseItem; }
            set
            {
                _SelectedStorehouseItem = value;
                RaisePropertyChanged(_SelectedStorehouseItemPropertyName);
            }
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

        private RelayCommand _showEditStorehouseItemCommand;

        public RelayCommand ShowEditStorehouseItemCommand
        {
            get
            {
                if (_showEditStorehouseItemCommand == null)
                    _showEditStorehouseItemCommand = new RelayCommand(ExecuteShowEditStorehouseItemCommandAction);
                return _showEditStorehouseItemCommand;
            }
        }

        private void ExecuteShowEditStorehouseItemCommandAction()
        {
            if (SelectedStorehouseItem == null)
                return;
            new EditStorehouseItemWindow().Show();
            MessengerInstance.Send<StorehouseViewModel>(SelectedStorehouseItem);
        }

        private RelayCommand _removeStorehouseItemCommand;

        public RelayCommand RemoveStorehouseItemCommand
        {
            get
            {
                if (_removeStorehouseItemCommand == null)
                    _removeStorehouseItemCommand = new RelayCommand(ExecuteRemoveStorehouseItemCommandAction);
                return _removeStorehouseItemCommand;
            }
        }

        private void ExecuteRemoveStorehouseItemCommandAction()
        {
            
            if (SelectedStorehouseItem == null)
                return;

            var questionResult = MessageBox.Show("Czy na pewno usunąć kontrahenta?", "Pytanie", MessageBoxButton.YesNo);
            if (questionResult == MessageBoxResult.No)
                return;

            _storehouseRepository.DeleteStorehouseItem(SelectedStorehouseItem.Magaz);
            Storehouses.Remove(SelectedStorehouseItem);
        
    }
    }
}
