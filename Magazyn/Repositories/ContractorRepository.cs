﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn.ViewModels;
using  Magazyn.Data;

namespace Magazyn.Repositories
{
    class ContractorRepository
    {
        public void AddContractor(ContractorViewModel contractor)
        {
            using (var context = new EntityDataModel())
            {
                var contractorToAdd = new Contractor
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
                context.Contractor.Add(contractorToAdd);
                context.SaveChanges();
            }
        }
        public void EditContractor(ContractorViewModel contractor)
        {
            using (var context = new EntityDataModel())
            {
                Contractor contractorToEdit = context.Contractor.FirstOrDefault(p => p.ID == contractor.Id);
                if (contractorToEdit != null)
                {
                    contractorToEdit.ZNAK = contractor.Znak;
                    contractorToEdit.SKROTK = contractor.SkrotK;
                    contractorToEdit.REGON = contractor.Regon;
                    contractorToEdit.KODNIP = contractor.Kodnip;
                    contractorToEdit.NIP = contractor.Nip;
                    contractorToEdit.NAZK1 = contractor.Nazk1;
                    contractorToEdit.NAZK2 = contractor.Nazk2;
                    contractorToEdit.KODPOCZK = contractor.KodpoczK;
                    contractorToEdit.MIEJSCEK = contractor.MiejsceK;
                    contractorToEdit.ULICAK = contractor.UlicaK;
                    contractorToEdit.NRMK = contractor.NrmK;
                    contractorToEdit.TELK = contractor.TelK;
                    contractorToEdit.TLMK = contractor.TlmK;
                }
                context.SaveChanges();
            }
        }
    }
}