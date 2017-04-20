using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using HurtowniaDB.Repositories;
using Magazyn.Mappers;
using GalaSoft.MvvmLight.Command;
using Magazyn.DictionariesWindow;

namespace Magazyn.DictionariesViewModels
{
    public class JmeDictionaryViewModel :ViewModelBase
    {
        public DictionariesRepository _DictionariesRepository;

        public JmeDictionaryViewModel()
        {
            _DictionariesRepository = new DictionariesRepository();
            Jmes =
                new ObservableCollection<JmeViewModel>(
                    _DictionariesRepository.GetJmeDictionaryItems().Select(p => StorehouseMappers.ConvertToVatViewModel(p)));
        }

        private const string _jmesPropertyName = "Jmes";
        private ObservableCollection<JmeViewModel> _jmes;

        public ObservableCollection<JmeViewModel> Jmes
        {
            get { return _jmes; }
            set
            {
                _jmes = value;
                RaisePropertyChanged(_jmesPropertyName);
            }
        }

        private const string _selectedItemPropertyName = "SelectedItem";
        private JmeViewModel _selectedItem;

        public JmeViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged(_selectedItemPropertyName);
            }
        }

        private RelayCommand _showEditJmeCommand;

        public RelayCommand ShowEditJmeCommand
        {
            get
            {
                if (_showEditJmeCommand == null)
                    _showEditJmeCommand = new RelayCommand(ExecuteShowEditJmeCommandAction);
                return _showEditJmeCommand;
            }
        }

        private void ExecuteShowEditJmeCommandAction()
        {
            new EditJmeWindow().Show();
            MessengerInstance.Send<JmeViewModel>(SelectedItem);
        }

        private RelayCommand _showAddJmeCommand;

        public RelayCommand ShowAddJmeCommand
        {
            get
            {
                if (_showAddJmeCommand == null)
                    _showAddJmeCommand = new RelayCommand(ExecuteShowAddJmeCommandAction);
                return _showAddJmeCommand;
            }
        }

        private void ExecuteShowAddJmeCommandAction()
        {
            new AddJmeWindow().Show();
        }
    }
}
