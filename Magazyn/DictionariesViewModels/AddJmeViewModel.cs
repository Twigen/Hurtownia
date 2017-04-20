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
   public class AddJmeViewModel:ViewModelBase
    {
        private DictionariesRepository _dictionariesRepository;
        public AddJmeViewModel()
        {
            Jme = new JmeViewModel();
            _dictionariesRepository = new DictionariesRepository();
        }

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

       private RelayCommand _addJmeCommand;

       public RelayCommand AddJmeCommand
       {
           get
           {
               if (_addJmeCommand == null)
                   _addJmeCommand = new RelayCommand(ExecuteAddJmeCommandAction);
               return _addJmeCommand;
           }
       }

       private void ExecuteAddJmeCommandAction()
       {
            if (Jme == null)
                return;

            JmeDictionary jmeEntity = StorehouseMappers.ConvertToJmeDictionary(Jme);
            _dictionariesRepository.AddJmeItem(jmeEntity);
        }

        

    }
}
