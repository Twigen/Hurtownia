using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Database.Data;
using Kontrachent.ViewModels;

namespace Kontrachent.Mappers
{
    static public class ContractorMapper
    {
        public static ContractorViewModel ConvertToViewModel(Contractor contractor)
        {
            return new ContractorViewModel
            {
                Id = contractor.ID,
                Znak = contractor.ZNAK,
                SkrotK = contractor.SKROTK,
                Regon = contractor.REGON,
                Kodnip = contractor.KODNIP,
                Nip = contractor.NIP,
                Nazk1 = contractor.NAZK1,
                Nazk2 = contractor.NAZK2,
                KodpoczK = contractor.KODPOCZK,
                MiejsceK = contractor.MIEJSCEK,
                UlicaK = contractor.ULICAK,
                NrmK = contractor.NRMK,
                TelK = contractor.TELK,
                TlmK = contractor.TLMK
            };

        }

        public static Contractor ConvertToEntity(ContractorViewModel contractor)
        {
            return new Contractor
            {
                ZNAK = contractor.Znak,
                SKROTK = contractor.SkrotK,
                REGON = contractor.Regon,
                KODNIP = contractor.Kodnip,
                NIP = contractor.Nip,
                NAZK1 = contractor.Nazk1,
                NAZK2 = contractor.Nazk2,
                KODPOCZK = contractor.KodpoczK,
                MIEJSCEK = contractor.MiejsceK,
                ULICAK = contractor.UlicaK,
                NRMK = contractor.NrmK,
                TELK = contractor.TelK,
                TLMK = contractor.TlmK
            };
        }
    }
}
