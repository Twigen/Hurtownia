using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Magazyn.DictionariesViewModels
{
   public class JmeViewModel:ViewModelBase
    {
       private const string _JmePropertyName = "Jme";
       private string _Jme;

       public string Jme
       {
           get { return _Jme; }
           set
           {
               _Jme = value;
               RaisePropertyChanged(_JmePropertyName);
           }
       }

       private const string _kodPropertyName = "Kod";
       private int _kod;

       public int Kod
       {
           get { return _kod; }
           set
           {
               _kod = value;
               RaisePropertyChanged(_kodPropertyName);
           }
       }

       private const string _IDPropertyName = "ID";
       private int _ID;

       public int ID
       {
           get { return _ID; }
           set
           {
               _ID = value;
               RaisePropertyChanged(_IDPropertyName);
           }
       }
    }
}
