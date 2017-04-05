using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurtowniaDB.Data;
using Magazyn.DictionariesViewModels;
using Magazyn.ViewModels;

namespace Magazyn.Mappers
{
    static public class StorehouseMappers
    {
        static public StorehouseViewModel ConvertToStorehouseItemViewModel(Storehouse storehouse)
        {
            return new StorehouseViewModel
            {
                Cena = storehouse.CENA,
                Cena2 = storehouse.CENA2,
                Ck = storehouse.CK,
                Datap = storehouse.DATAP,
                Datar = storehouse.DATAP,
                Id = storehouse.ID,
                Jme = storehouse.JME,
                Ktm = storehouse.KTM,
                Magaz = storehouse.MAGAZ,
                Nazwak = storehouse.NAZWAK,
                Pik = storehouse.PIK,
                Pim = storehouse.PIM,
                Przecall = storehouse.PRZECALL,
                Pwk = storehouse.PWK,
                Pwm = storehouse.PWM,
                Rik = storehouse.RIK,
                Rim = storehouse.RIM,
                Rwk = storehouse.RWK,
                Rwm = storehouse.RWM,
                Spis = storehouse.SPIS,
                StanII = storehouse.STANII,
                Stanki = storehouse.STANKI,
                Stankw = storehouse.STANKW,
                Stanog = storehouse.STANOG,
                Stanpi = storehouse.STANPI,
                Stanpw = storehouse.STANPW,
                Vat = storehouse.VAT,
                Wielk = storehouse.WIELK,
                Znak = storehouse.ZNAK
            };
        }

        public static Storehouse ConvertToStorehouseEntity(StorehouseViewModel storehouseViewModel)
        {
            return new Storehouse
            {
                CENA = storehouseViewModel.Cena,
                CENA2 = storehouseViewModel.Cena2,
                CK = storehouseViewModel.Ck,
                DATAP = storehouseViewModel.Datap,
                DATAR = storehouseViewModel.Datar,
                ID = storehouseViewModel.Id,
                JME = storehouseViewModel.Jme,
                KTM = storehouseViewModel.Ktm,
                MAGAZ = storehouseViewModel.Magaz,
                NAZWAK = storehouseViewModel.Nazwak,
                PIK = storehouseViewModel.Pik,
                PIM = storehouseViewModel.Pim,
                PRZECALL = storehouseViewModel.Przecall,
                PWK = storehouseViewModel.Pwk,
                PWM = storehouseViewModel.Pwm,
                RIK = storehouseViewModel.Rik,
                RIM = storehouseViewModel.Rim,
                RWK = storehouseViewModel.Rwk,
                RWM = storehouseViewModel.Rwm,
                SPIS = storehouseViewModel.Spis,
                STANII = storehouseViewModel.StanII,
                STANKI = storehouseViewModel.Stanki,
                STANKW = storehouseViewModel.Stankw,
                STANOG = storehouseViewModel.Stanog,
                STANPI = storehouseViewModel.Stanpi,
                STANPW = storehouseViewModel.Stanpw,
                VAT = storehouseViewModel.Vat,
                WIELK = storehouseViewModel.Wielk,
                ZNAK = storehouseViewModel.Znak
            };

        }

        public static VatViewModel ConvertToVatViewModel(VatDictionary vatDictionary)
        {
            return new VatViewModel
            {
                Vat = vatDictionary.Vat,
                Kod = vatDictionary.Kod
            };
        }

        public static VatDictionary ConvertToVatDictionary(VatViewModel vatViewModel)
        {
            return new VatDictionary
            {
                Kod = vatViewModel.Kod,
                Vat = vatViewModel.Vat

            };
        }

        public static JmeViewModel ConvertToVatViewModel(JmeDictionary jmeDictionary)
        {
            return new JmeViewModel
            {
                Jme = jmeDictionary.Jme,
                Kod = jmeDictionary.Kod
            };
        }
    }
   
}

