using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using HurtowniaDB.Data;
using HurtowniaDB.Repositories;
using Magazyn.Mappers;
using GalaSoft.MvvmLight.Command;

namespace Magazyn.DictionariesViewModels
{
    public class EditJmeViewModel:ViewModelBase
    {
        private VatDictionary selectedVatDictionary;
        private DictionariesRepository _dictionariesRepository;


        public EditJmeViewModel()
        {
            MessengerInstance.Register<JmeViewModel>(this, ReciveJme);
            _dictionariesRepository = new DictionariesRepository();
        }

        private RelayCommand _editJmeItemCommand;

        public RelayCommand EditJmeItemCommand
        {
            get
            {
                if (_editJmeItemCommand == null)
                    _editJmeItemCommand = new RelayCommand(ExecuteEditJmeItemCommandAction);
                return _editJmeItemCommand;
            }
        }

        private void ExecuteEditJmeItemCommandAction()
        {
            if (Jme == null)
                return;

            JmeDictionary jmeEntity = StorehouseMappers.ConvertToJmeDictionary(Jme);

            _dictionariesRepository.EditJmeItem(jmeEntity);
        }

        private RelayCommand _editVatItemCommand;

        private const string _jmePropertyName = "Jme";
        private JmeViewModel _jme;

        public JmeViewModel Jme
        {
            get { return _jme; }
            set
            {
                _jme = value;
                RaisePropertyChanged(_jmePropertyName);
            }
        }

        private void ReciveJme(JmeViewModel jmeViewModel)
        {
            Jme = jmeViewModel = jmeViewModel;
        }
    }
}
