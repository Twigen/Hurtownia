using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Data;
using GalaSoft.MvvmLight;
using HurtowniaDB.Repositories;
using GalaSoft.MvvmLight.Command;
using HurtowniaDB.Data;
using Magazyn.Mappers;

namespace Magazyn.DictionariesViewModels
{
   public class EditVatViewModel :ViewModelBase
   {
       private VatDictionary selectedVatDictionary;
        private DictionariesRepository _dictionariesRepository;


        public EditVatViewModel()
        {
            MessengerInstance.Register<VatViewModel>(this, ReciveVat);
            
            //  _magRepository = new MagRepository();
            _dictionariesRepository = new DictionariesRepository();
        }

       private RelayCommand _editVatItemCommand;

       public RelayCommand EditVatItemCommand
       {
           get
           {
               if (_editVatItemCommand == null)
                   _editVatItemCommand = new RelayCommand(ExecuteEditVatItemCommandAction);
               return _editVatItemCommand;
           }
       }

       private void ExecuteEditVatItemCommandAction()
       {
            if (Vat == null)
                return;
            
           VatDictionary vatEntity = StorehouseMappers.ConvertToVatDictionary(Vat);
          
            _dictionariesRepository.EditVatItem(vatEntity);
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


       private void ReciveVat(VatViewModel vatViewModel)
       {
           Vat = vatViewModel;
            selectedVatDictionary = StorehouseMappers.ConvertToVatDictionary(vatViewModel);
        }

        
    }
}
