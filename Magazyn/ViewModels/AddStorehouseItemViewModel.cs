using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Database.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HurtowniaDB.Repositories;
using HurtowniaDB.Data;
using Magazyn.DictionariesViewModels;
using Magazyn.Mappers;

namespace Magazyn.ViewModels
{
    public class AddStorehouseItemViewModel :ViewModelBase
    {
        private StorehouseRepository _storehouseRepository;
        public DictionariesRepository _DictionariesRepository;
        public AddStorehouseItemViewModel()
        {
            _DictionariesRepository = new DictionariesRepository();
            JmeList =
                _DictionariesRepository.GetJmeDictionaryItems()
                    .Select(p => StorehouseMappers.ConvertToJmeViewModel(p))
                    .Select(p => p.Jme)
                    .ToList();
            VatList = _DictionariesRepository.GetVatDictionaryItems().Select(p => StorehouseMappers.ConvertToVatViewModel(p)).Select(p => p.Vat).ToList();
            Storehouse = new StorehouseViewModel();
            _storehouseRepository= new StorehouseRepository();
        }

        private const string _storehousePropertyName = "Storehouse";
        private StorehouseViewModel _storehouse;

        public StorehouseViewModel Storehouse
        {
            get { return _storehouse; }
            set
            {
                _storehouse = value;
                RaisePropertyChanged(_storehousePropertyName);
            }
        }

        private RelayCommand addStorehouseIteCommand;

        public RelayCommand AddStorehouseItemCommand
        {
            get
            {
                if (addStorehouseIteCommand == null)
                    addStorehouseIteCommand = new RelayCommand(ExecuteAddStorehouseItemCommandAction);
                return addStorehouseIteCommand;
            }
        }

        private void ExecuteAddStorehouseItemCommandAction()
        {
            if (Storehouse == null)
                return;
            
            Storehouse storehouseEntity = StorehouseMappers.ConvertToStorehouseEntity(Storehouse);
            _storehouseRepository.AddStorehouseItem(storehouseEntity,SelectedVatItem,SelectedJmeItem);
        }

        private const string _selectedVatItemPropertyName = "SelectedVatItem";
        private int _selectedVatItem;

        public int SelectedVatItem
        {
            get { return _selectedVatItem; }
            set
            {
                _selectedVatItem = value;
                RaisePropertyChanged(_selectedVatItemPropertyName);
            }
        }

        
        private const string _vatListPropertyName = "VatList";
        private List<int> _vatList;

        public List<int> VatList
        {
            get { return _vatList; }
            set
            {
                _vatList = value;
                RaisePropertyChanged(_vatListPropertyName);
            }
        }

        private const string _selectedJmeItemPropertyName = "SelectedJmeItem";
        private string _selectedJmeItem;

        public string SelectedJmeItem
        {
            get { return _selectedJmeItem; }
            set
            {
                _selectedJmeItem = value;
                RaisePropertyChanged(_selectedJmeItemPropertyName);
            }
        }

        private const string _jmeListPropertyName = "JmeList";
        private List<string> _jmeList;

        public List<string> JmeList
        {
            get { return _jmeList; }
            set
            {
                _jmeList = value;
                RaisePropertyChanged(_jmeListPropertyName);
            }
        }
    }
}
