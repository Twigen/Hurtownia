using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Database.Data;

namespace HurtowniaDB.Repositories
{
    public class ContractorRepository
    {
        public List<Contractor> GetContractors()
        {
            using (var context = new EntityDataModel())
                return context.Contractor.ToList();
        }

    public bool AddContractor(Contractor contractor)
        {
            
            using (var context = new EntityDataModel())
            {
                 
                if (ValidateContractor(contractor))
                {
                    

                    context.Contractor.Add(contractor);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void EditContractor(Contractor contractor)
        {
            using (var context = new EntityDataModel())
            {
                Contractor contractorToEdit = context.Contractor.FirstOrDefault(p => p.ID == contractor.ID);
                if (contractorToEdit != null && ValidateContractor(contractor))
                {
                    {
                        contractorToEdit.ZNAK = contractor.ZNAK;
                        contractorToEdit.SKROTK = contractor.SKROTK;
                        contractorToEdit.REGON = contractor.REGON;
                        contractorToEdit.KODNIP = contractor.KODNIP;
                        contractorToEdit.NIP = contractor.NIP;
                        contractorToEdit.NAZK1 = contractor.NAZK1;
                        contractorToEdit.NAZK2 = contractor.NAZK2;
                        contractorToEdit.KODPOCZK = contractor.KODPOCZK;
                        contractorToEdit.MIEJSCEK = contractor.MIEJSCEK;
                        contractorToEdit.ULICAK = contractor.ULICAK;
                        contractorToEdit.NRMK = contractor.NRMK;
                        contractorToEdit.TELK = contractor.TELK;
                        contractorToEdit.TLMK = contractor.TLMK;
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

        private bool ValidateContractor(Contractor contractor)
        {
            using (var context = new EntityDataModel())
            {
                if (context.Contractor.FirstOrDefault(p => p.SKROTK == contractor.SKROTK) == null)
                    return true;
                else return false;
            }
        }
        public void DeleteContractor(int id)
        {
            using (var context = new EntityDataModel())
            {
                var contractorToDelete = context.Contractor.FirstOrDefault(p => p.ID == id);
                if (contractorToDelete == null)
                    return;

                context.Contractor.Remove(contractorToDelete);
                context.SaveChanges();
            }
        }
    }
}
