using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HurtowniaDB.Repositories;
using HurtowniaDB;
using Magazyn.Mappers;

namespace Kontrachent.ViewModels
{
    public class AddContractorViewModel : ViewModelBase
    {
        private readonly MagRepository _magRepository;
        private ContractorRepository _contractorRepository;

        public AddContractorViewModel()
        {
            Contractor = new ContractorViewModel();
            _magRepository = new MagRepository();
            _contractorRepository = new ContractorRepository();
        }

        private RelayCommand _addContractorCommand;

        public RelayCommand AddcontractorCommand
        {
            get
            {
                if (_addContractorCommand == null)
                    _addContractorCommand = new RelayCommand(ExecuteAddcontractorCommandAction);
                return _addContractorCommand;
            }
        }

        private void ExecuteAddcontractorCommandAction()
        {
            if(Contractor == null)
                return;
            Contractor contractorEntity = ContractorMapper.ConvertToEntity(Contractor);
            _contractorRepository.AddContractor(contractorEntity);

        }

        private const string _contractorPropertyName = "Contractor";
        private ContractorViewModel _contractor;

        public ContractorViewModel Contractor
        {
            get { return _contractor; }
            set
            {
                _contractor = value;
                RaisePropertyChanged(_contractorPropertyName);
            }
        }

    }
}
