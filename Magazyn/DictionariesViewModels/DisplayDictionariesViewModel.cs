using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Magazyn.DictionariesWindow;

namespace Magazyn.DictionariesViewModels
{
   public class DisplayDictionariesViewModel :ViewModelBase
    {
       private RelayCommand _showVatDictionaryCommand;

       public RelayCommand ShowVatDictionaryCommand
       {
           get
           {
               if (_showVatDictionaryCommand == null)
                   _showVatDictionaryCommand = new RelayCommand(ExecuteShowVatDictionaryCommandAction);
               return _showVatDictionaryCommand;
           }
       }

       private void ExecuteShowVatDictionaryCommandAction()
       {
           new VatDictionaryWindow().Show();
       }

       private RelayCommand _showJmeDictionaryCommand;

       public RelayCommand ShowJmeDictionaryCommand
       {
           get
           {
               if (_showJmeDictionaryCommand == null)
                   _showJmeDictionaryCommand = new RelayCommand(ExecuteShowJmeDictionaryCommandAction);
               return _showJmeDictionaryCommand;
           }
       }

       private void ExecuteShowJmeDictionaryCommandAction()
       {
           new JmeDictionaryWindow().Show();
       }

      
    }
}
