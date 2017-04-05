using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Data;
using GalaSoft.MvvmLight;
using HurtowniaDB.Repositories;
using Magazyn.Mappers;
using GalaSoft.MvvmLight.Command;
using HurtowniaDB.Data;
using Magazyn.DictionariesWindow;

namespace Magazyn.DictionariesViewModels
{
    class VatDictionaryViewModel :ViewModelBase
    {
        public DictionariesRepository _DictionariesRepository;
        public VatDictionaryViewModel()
        {
            _DictionariesRepository= new DictionariesRepository();
            Vats =
                new ObservableCollection<VatViewModel>(
                    _DictionariesRepository.GetVatDictionaryItems().Select(p => StorehouseMappers.ConvertToVatViewModel(p)));
        }

        private const string _vatsPropertyName = "Vats";
        private ObservableCollection<VatViewModel> _vats;

        public ObservableCollection<VatViewModel> Vats
        {
            get { return _vats; }
            set
            {
                _vats = value;
                RaisePropertyChanged(_vatsPropertyName);
            }
        }
        private RelayCommand _showEditVatCommand;

        public RelayCommand ShowEditVatCommand
        {
            get
            {
                if (_showEditVatCommand == null)
                    _showEditVatCommand = new RelayCommand(ExecuteShowEditVatCommandAction);
                return _showEditVatCommand;
            }
        }

        private void ExecuteShowEditVatCommandAction()
        {
            if (SelectedVatItem == null)
                return;
            new EditVatWindow().Show();
           
            MessengerInstance.Send<VatViewModel>(SelectedVatItem);
        }
        private const string _selectedVatItemPropertyName = "SelectedVatItem";
        private VatViewModel _selectedVatItem;

        public VatViewModel SelectedVatItem
        {
            get { return _selectedVatItem; }
            set
            {
                _selectedVatItem = value;
                RaisePropertyChanged(_selectedVatItemPropertyName);
            }
        }
    }
}
