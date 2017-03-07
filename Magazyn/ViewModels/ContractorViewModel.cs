using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Magazyn.ViewModels
{
    public class ContractorViewModel : ViewModelBase
    {
        private const string _idPropertyName = "Id";
        private int _id;

        public int Id
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

        private const string _skrotKPropertyName = "SkrotK";
        private string _skrotK;

        public string SkrotK
        {
            get { return _skrotK; }
            set
            {
                _skrotK = value;
                RaisePropertyChanged(_skrotKPropertyName);
            }
        }

        private const string _regonPropertyName = "Regon";
        private string _regon;

        public string Regon
        {
            get { return _regon; }
            set
            {
                _regon = value;
                RaisePropertyChanged(_regonPropertyName);
            }
        }

        private const string _kodnipPropertyName = "Kodnip";
        private string _kodnip;

        public string Kodnip
        {
            get { return _kodnip; }
            set
            {
                _kodnip = value;
                RaisePropertyChanged(_kodnipPropertyName);
            }
        }

        private const string _nipPropertyName = "Nip";
        private string _nip;

        public string Nip
        {
            get { return _nip; }
            set
            {
                _nip = value;
                RaisePropertyChanged(_nipPropertyName);
            }
        }

        private const string _nazkPropertyName = "Nazk1";
        private string _nazk;

        public string Nazk1
        {
            get { return _nazk; }
            set
            {
                _nazk = value;
                RaisePropertyChanged(_nazkPropertyName);
            }
        }

        private const string _nazk2PropertyName = "Nazk2";
        private string _nazk2;

        public string Nazk2
        {
            get { return _nazk2; }
            set
            {
                _nazk2 = value;
                RaisePropertyChanged(_nazk2PropertyName);
            }
        }

        private const string _kodpoczKPropertyName = "KodpoczK";
        private string _kodpoczt;

        public string KodpoczK
        {
            get { return _kodpoczt; }
            set
            {
                _kodpoczt = value;
                RaisePropertyChanged(_kodpoczKPropertyName);
            }
        }

        private const string _miejsceKPropertyName = "MiejsceK";
        private string _miejsceK;

        public string MiejsceK
        {
            get { return _miejsceK; }
            set
            {
                _miejsceK = value;
                RaisePropertyChanged(_miejsceKPropertyName);
            }
        }

        private const string _ulicaKPropertyName = "UlicaK";
        private string _ulicaK;

        public string UlicaK
        {
            get { return _ulicaK; }
            set
            {
                _ulicaK = value;
                RaisePropertyChanged(_ulicaKPropertyName);
            }
        }

        private const string _NrmkPropertyName = "NrmK";
        private string _Nrmk;

        public string NrmK
        {
            get { return _Nrmk; }
            set
            {
                _Nrmk = value;
                RaisePropertyChanged(_NrmkPropertyName);
            }
        }

        private const string _telKPropertyName = "TelK";
        private string _telK;

        public string TelK
        {
            get { return _telK; }
            set
            {
                _telK = value;
                RaisePropertyChanged(_telKPropertyName);
            }
        }

        private const string _tlmKPropertyName = "TlmK";
        private string _tlmK;

        public string TlmK
        {
            get { return _tlmK; }
            set
            {
                _tlmK = value;
                RaisePropertyChanged(_tlmKPropertyName);
            }
        }
    }
}
