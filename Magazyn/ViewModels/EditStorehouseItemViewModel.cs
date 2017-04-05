using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using HurtowniaDB.Repositories;
using GalaSoft.MvvmLight.Command;
using Magazyn.Mappers;

namespace Magazyn.ViewModels
{
    class EditStorehouseItemViewModel :ViewModelBase
    {
        private StorehouseRepository _storehouseRepository;



        public EditStorehouseItemViewModel()
        {
            MessengerInstance.Register<StorehouseViewModel>(this, ReciveContractor);

          //  _magRepository = new MagRepository();
            _storehouseRepository = new StorehouseRepository();
        }

        private RelayCommand _editStorehouseIteCommand;

        public RelayCommand EditStorehouseItemCommand
        {
            get
            {
                if (_editStorehouseIteCommand == null)
                    _editStorehouseIteCommand = new RelayCommand(ExecuteEditStorehouseItemCommandAction);
                return _editStorehouseIteCommand;
            }
        }

        private void ExecuteEditStorehouseItemCommandAction()
        {
            if (Storehouse == null)
                return;
            var storehouseEntity = StorehouseMappers.ConvertToStorehouseEntity(Storehouse);
            _storehouseRepository.EditStorehouseItem(storehouseEntity);
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

        private void ReciveContractor(StorehouseViewModel storehouseViewModel)
        {
            Storehouse = storehouseViewModel;
        }
    }
}
