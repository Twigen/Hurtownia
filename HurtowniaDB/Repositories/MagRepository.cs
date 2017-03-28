using System.Collections.Generic;
using System.Linq;
using Database.Data;

namespace HurtowniaDB.Repositories
{
    public class MagRepository
    {
        
        public Contractor GetContractor(int id)
        {
            using (var context = new EntityDataModel())
            {
                var newPerson = context.Contractor.FirstOrDefault(p => p.ID == id);
                return newPerson ?? new Contractor();
            }
        }

       

        

       
    }
}
