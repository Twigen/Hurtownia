using Magazyn.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn.ViewModels;

namespace Magazyn.Repositories
{
    public class MagRepository
    {
        public List<ContractorViewModel> GetContractors()
        {
            using (var context = new EntityDataModel())
                return context.Contractor.Select(x => new ContractorViewModel
                {
                    Id = x.ID,
                    Znak = x.ZNAK,
                    SkrotK = x.SKROTK,
                    Regon = x.REGON,
                    Kodnip = x.KODNIP,
                    Nip = x.NIP,
                    Nazk1 = x.NAZK1,
                    Nazk2 = x.NAZK2,
                    KodpoczK = x.KODPOCZK,
                    MiejsceK = x.MIEJSCEK,
                    UlicaK = x.ULICAK,
                    NrmK = x.NRMK,
                    TelK = x.TELK,
                    TlmK = x.TLMK
                }).ToList();
        }
        public Contractor GetContractor(int id)
        {
            using (var context = new EntityDataModel())
            {
                var newPerson = context.Contractor.FirstOrDefault(p => p.ID == id);
                return newPerson ?? new Contractor();
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
