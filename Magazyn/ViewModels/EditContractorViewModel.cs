using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Magazyn.Adapters;
using Magazyn.Repositories;




namespace Magazyn.ViewModels
{
    public class EditContractorViewModel : ViewModelBase
    {
        private readonly MagRepository _magRepository;
        private ContractorRepository _contractorRepository;
        public static ContractorViewModel _Contractor;
       // MessengerInstance.Register(this, ReciveContractor);

        public EditContractorViewModel()
        {
            Contractor = _Contractor;
           _magRepository = new MagRepository();
            _contractorRepository = new ContractorRepository();
        }

        public EditContractorViewModel(ContractorViewModel contractor)
        {
            Contractor = contractor;
            _magRepository = new MagRepository();
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
    }
}
