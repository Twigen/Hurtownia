using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Helpers;
using Database.Data;
using Kontrachent.ViewModels;


namespace Kontrachent.Repositories
{
    class ContractorRepository
    {
        public void AddContractor(ContractorViewModel contractor)
        {
            
            using (var context = new EntityDataModel())
            {
                 
                if (ValidateContractor(contractor))
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
                    MessageBox.Show("Poprawnie dodano kontrachenta");
                }
                else
                {
                    MessageBox.Show("Pole SkrotK musi byc unikalne");
                }
            }
        }
        public void EditContractor(ContractorViewModel contractor)
        {
            using (var context = new EntityDataModel())
            {
                Contractor contractorToEdit = context.Contractor.FirstOrDefault(p => p.ID == contractor.Id);
                if (contractorToEdit != null && ValidateContractor(contractor))
                {
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
                    MessageBox.Show("Edycja zakonczona sukcesem");
                }
                else
                {
                    MessageBox.Show("Blad. Podaj unikalny SkrotK");
                }
            }
        }

        private bool ValidateContractor(ContractorViewModel contractor)
        {
            using (var context = new EntityDataModel())
            {
                if (context.Contractor.FirstOrDefault(p => p.SKROTK == contractor.SkrotK) == null)
                    return true;
                else return false;
            }
        }
    }
}
