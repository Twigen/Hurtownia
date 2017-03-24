using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Kontrachent.Repositories;
using Kontrachent.Adapters;


namespace Kontrachent.ViewModels
{
    public class EditContractorViewModel : ViewModelBase
    {
        private readonly MagRepository _magRepository;
        private ContractorRepository _contractorRepository;
        
        

        public EditContractorViewModel()
        {
            MessengerInstance.Register<ContractorViewModel>(this, ReciveContractor);
            
           _magRepository = new MagRepository();
            _contractorRepository = new ContractorRepository();
        }

        

        private RelayCommand _addContractorCommand;

        public RelayCommand EditContractorCommand
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
            if (Contractor == null)
                return;

            _contractorRepository.EditContractor(Contractor);
            
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

        private void ReciveContractor(ContractorViewModel contractorViewModel)
        {
            Contractor = contractorViewModel;
        }
    }
}
