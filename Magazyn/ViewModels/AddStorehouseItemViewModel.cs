using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HurtowniaDB.Repositories;
using HurtowniaDB.Data;
using Magazyn.Mappers;

namespace Magazyn.ViewModels
{
    public class AddStorehouseItemViewModel :ViewModelBase
    {
        private StorehouseRepository _storehouseRepository;
        public AddStorehouseItemViewModel()
        {
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
            _storehouseRepository.AddStorehouseItem(storehouseEntity);
        }
    }
}
