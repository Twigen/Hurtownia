using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using HurtowniaDB.Repositories;
using Magazyn.Mappers;
using Magazyn.ViewModels;
using GalaSoft.MvvmLight.Command;
using HurtowniaDB.Data;

namespace Magazyn.DictionariesViewModels
{
   public class AddVatViewModel :ViewModelBase
    {
        private DictionariesRepository _dictionariesRepository;
        public AddVatViewModel()
        {
            Vat = new VatViewModel();
            _dictionariesRepository = new DictionariesRepository();
        }

       private const string _vatPropertyName = "Vat";
       private VatViewModel _vat;

       public VatViewModel Vat
       {
           get { return _vat; }
           set
           {
               _vat = value;
               RaisePropertyChanged(_vatPropertyName);
           }
       }

       private RelayCommand _addVatCommand;

       public RelayCommand AddVatCommand
       {
           get
           {
               if (_addVatCommand == null)
                   _addVatCommand = new RelayCommand(ExecuteAddVatCommandAction);
               return _addVatCommand;
           }
       }

       private void ExecuteAddVatCommandAction()
       {
            if (Vat == null)
                return;

            VatDictionary vatEntity = StorehouseMappers.ConvertToVatDictionary(Vat);
            _dictionariesRepository.AddVatItem(vatEntity);
        }

        
    }
}
