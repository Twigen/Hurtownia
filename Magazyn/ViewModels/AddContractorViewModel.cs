using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Magazyn.Repositories;

namespace Magazyn.ViewModels
{
    public class AddContractorViewModel : ViewModelBase
    {
        private readonly MagRepository _magRepository;

        public AddContractorViewModel()
        {
            Contractor = new ContractorViewModel();
            _magRepository = new MagRepository();
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

            _magRepository.AddContractor(Contractor);

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
