using GalaSoft.MvvmLight.Command;
using Magazyn.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using Magazyn.Adapters;

namespace Magazyn.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly MagRepository _contractorRepository;

        public MainViewModel()
        {
            _contractorRepository = new MagRepository();
            Contractors =
                new ObservableCollection<ContractorViewModel>(
                    _contractorRepository.GetContractors());
        }

        private RelayCommand _addContractorCommand;

        public RelayCommand AddContractorCommand
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
            var addContractorViewModel = new AddContractorViewModel();
            var addContractorView = ViewService.CreateView(addContractorViewModel);
            addContractorView.ShowDialog();
        }

        private RelayCommand _removeContractorCommand;

        public RelayCommand RemoveContractorCommand
        {
            get
            {
                if (_removeContractorCommand == null)
                    _removeContractorCommand = new RelayCommand(ExecuteRemoveContractorCommandAction);
                return _removeContractorCommand;
            }
        }

        private void ExecuteRemoveContractorCommandAction()
        {
            if (SelectedContractor == null)
                return;

            var questionResult = MessageBox.Show("Czy na pewno usunąć kontrahenta?", "Pytanie", MessageBoxButton.YesNo);
            if (questionResult == MessageBoxResult.No)
                return;

            _contractorRepository.DeleteContractor(SelectedContractor.Id);
            Contractors.Remove(SelectedContractor);
        }

        private RelayCommand _editContractorCommand;

        public RelayCommand EditContractorCommand
        {
            get
            {
                if (_editContractorCommand == null)
                    _editContractorCommand = new RelayCommand(ExecuteEditContractorCommandAction);
                return _editContractorCommand;
            }
        }

        private void ExecuteEditContractorCommandAction()
        {
            if (SelectedContractor == null)
                return;

            var editContractorViewModel = new EditContractorViewModel(SelectedContractor);
            var editContractorView = ViewService.CreateView(editContractorViewModel);
            editContractorView.ShowDialog();
        }

        private const string _contractorsPropertyName = "Contractors";
        private ObservableCollection<ContractorViewModel> _contractors;

        public ObservableCollection<ContractorViewModel> Contractors
        {
            get { return _contractors; }
            set
            {
                _contractors = value;
                RaisePropertyChanged(_contractorsPropertyName);
            }
        }

        private const string _selectedContractorPropertyName = "SelectedContractor";
        private ContractorViewModel _selectedContractor;

        public ContractorViewModel SelectedContractor
        {
            get { return _selectedContractor; }
            set
            {
                _selectedContractor = value;
                RaisePropertyChanged(_selectedContractorPropertyName);
            }
        }
    }
}
