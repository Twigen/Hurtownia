using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Magazyn.ViewModels
{
   public class StorehouseViewModel :ViewModelBase
    {
        private const string _idPropertyName = "Id";
        private int? _id;

        public int? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged(_idPropertyName);
            }
        }

        private const string _znakPropertyName = "Znak";
        private string _znak;

        public string Znak
        {
            get { return _znak; }
            set
            {
                _znak = value;
                RaisePropertyChanged(_znakPropertyName);
            }
        }

        private const string _magazPropertyName = "Magaz";
        private string _magaz;

        public string Magaz
        {
            get { return _magaz; }
            set
            {
                _magaz = value;
                RaisePropertyChanged(_magazPropertyName);
            }
        }

        private const string _ktmPropertyName = "Ktm";
        private string _ktm;

        public string Ktm
        {
            get { return _ktm; }
            set
            {
                _ktm = value;
                RaisePropertyChanged(_ktmPropertyName);
            }
        }

        private const string _ckPropertyName = "Ck";
        private string _ck;

        public string Ck
        {
            get { return _ck; }
            set
            {
                _ck = value;
                RaisePropertyChanged(_ckPropertyName);
            }
        }

        private const string _nazwakPropertyName = "Nazwak";
        private string _nazwak;

        public string Nazwak
        {
            get { return _nazwak; }
            set
            {
                _nazwak = value;
                RaisePropertyChanged(_nazwakPropertyName);
            }
        }

        private const string _wielkPropertyName = "Wielk";
        private string _wielk;

        public string Wielk
        {
            get { return _wielk; }
            set
            {
                _wielk = value;
                RaisePropertyChanged(_wielkPropertyName);
            }
        }

        private const string _cenaPropertyName = "Cena";
        private double? _cena;

        public double? Cena
        {
            get { return _cena; }
            set
            {
                _cena = value;
                RaisePropertyChanged(_cenaPropertyName);
            }
        }

        private const string _cena2PropertyName = "Cena2";
        private double? _cena2;

        public double? Cena2
        {
            get { return _cena2; }
            set
            {
                _cena2 = value;
                RaisePropertyChanged(_cena2PropertyName);
            }
        }

        private const string _vatPropertyName = "Vat";
        private string _vat;

        public string Vat
        {
            get { return _vat; }
            set
            {
                _vat = value;
                RaisePropertyChanged(_vatPropertyName);
            }
        }

        private const string _jmePropertyName = "Jme";
        private string _jme;

        public string Jme
        {
            get { return _jme; }
            set
            {
                _jme = value;
                RaisePropertyChanged(_jmePropertyName);
            }
        }

        private const string _stanpiPropertyName = "Stanpi";
        private double? _stanpi;

        public double? Stanpi
        {
            get { return _stanpi; }
            set
            {
                _stanpi = value;
                RaisePropertyChanged(_stanpiPropertyName);
            }
        }

        private const string _pikPropertyName = "Pik";
        private double? _pik;

        public double? Pik
        {
            get { return _pik; }
            set
            {
                _pik = value;
                RaisePropertyChanged(_pikPropertyName);
            }
        }

        private const string _rikPropertyName = "Rik";
        private double? _rik;

        public double? Rik
        {
            get { return _rik; }
            set
            {
                _rik = value;
                RaisePropertyChanged(_rikPropertyName);
            }
        }

        private const string _stankiPropertyName = "Stanki";
        private double? _stanki;

        public double? Stanki
        {
            get { return _stanki; }
            set
            {
                _stanki = value;
                RaisePropertyChanged(_stankiPropertyName);
            }
        }

        private const string _stanogPropertyName = "Stanog";
        private double? _stanog;

        public double? Stanog
        {
            get { return _stanog; }
            set
            {
                _stanog = value;
                RaisePropertyChanged(_stanogPropertyName);
            }
        }

        private const string _stanpwPropertyName = "Stanpw";
        private double? _stanpw;

        public double? Stanpw
        {
            get { return _stanpw; }
            set
            {
                _stanpw = value;
                RaisePropertyChanged(_stanpwPropertyName);
            }
        }

        private const string _pwkPropertyName = "Pwk";
        private double? _pwk;

        public double? Pwk
        {
            get { return _pwk; }
            set
            {
                _pwk = value;
                RaisePropertyChanged(_pwkPropertyName);
            }
        }

        private const string _rwkPropertyName = "Rwk";
        private double? _rwk;

        public double? Rwk
        {
            get { return _rwk; }
            set
            {
                _rwk = value;
                RaisePropertyChanged(_rwkPropertyName);
            }
        }

        private const string _stankwPropertyName = "Stankw";
        private double? _stankw;

        public double? Stankw
        {
            get { return _stankw; }
            set
            {
                _stankw = value;
                RaisePropertyChanged(_stankwPropertyName);
            }
        }

        private const string _przecallPropertyName = "Przecall";
        private double? _przecall;

        public double? Przecall
        {
            get { return _przecall; }
            set
            {
                _przecall = value;
                RaisePropertyChanged(_przecallPropertyName);
            }
        }

        private const string _pimPropertyName = "Pim";
        private double? _pim;

        public double? Pim
        {
            get { return _pim; }
            set
            {
                _pim = value;
                RaisePropertyChanged(_pimPropertyName);
            }
        }

        private const string _rimPropertyName = "Rim";
        private double? _rim;

        public double? Rim
        {
            get { return _rim; }
            set
            {
                _rim = value;
                RaisePropertyChanged(_rimPropertyName);
            }
        }

        private const string _pwmPropertyName = "Pwm";
        private double? _pwm;

        public double? Pwm
        {
            get { return _pwm; }
            set
            {
                _pwm = value;
                RaisePropertyChanged(_pwmPropertyName);
            }
        }

        private const string _rwmPropertyName = "Rwm";
        private double? _rwm;

        public double? Rwm
        {
            get { return _rwm; }
            set
            {
                _rwm = value;
                RaisePropertyChanged(_rwmPropertyName);
            }
        }

        private const string _datapPropertyName = "Datap";
        private DateTime _datap;

        public DateTime Datap
        {
            get { return _datap; }
            set
            {
                _datap = value;
                RaisePropertyChanged(_datapPropertyName);
            }
        }

        private const string _datarPropertyName = "Datar";
        private DateTime _datar;

        public DateTime Datar
        {
            get { return _datar; }
            set
            {
                _datar = value;
                RaisePropertyChanged(_datarPropertyName);
            }
        }

        private const string _spisPropertyName = "Spis";
        private DateTime? _spis;

        public DateTime? Spis
        {
            get { return _spis; }
            set
            {
                _spis = value;
                RaisePropertyChanged(_spisPropertyName);
            }
        }

        private const string _staniiPropertyName = "StanII";
        private double? _stanii;

        public double? StanII
        {
            get { return _stanii; }
            set
            {
                _stanii = value;
                RaisePropertyChanged(_staniiPropertyName);
            }
        }

    }
}
