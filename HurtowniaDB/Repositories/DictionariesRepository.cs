using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Database.Data;
using HurtowniaDB.Data;

namespace HurtowniaDB.Repositories
{
   public class DictionariesRepository
    {
        public List<VatDictionary> GetVatDictionaryItems()
        {
            using (var context = new EntityDataModel())
                return context.VatDictionary.ToList();
        }

        public List<JmeDictionary> GetJmeDictionaryItems()
        {
            using (var context = new EntityDataModel())
                return context.JmeDictionary.ToList();
        }

       public bool EditVatItem(VatDictionary vatDictionary)
       {
           using (var context = new EntityDataModel())
           {
               VatDictionary vatToEdit = context.VatDictionary.FirstOrDefault(p => p.ID == vatDictionary.ID);
               if (vatToEdit != null && ValidateVatItem(vatDictionary))
               {
                   {
                       vatToEdit.Kod = vatDictionary.Kod;
                       vatToEdit.Vat = vatDictionary.Vat;
                   }
                   
                   context.SaveChanges();
                   MessageBox.Show("Edycja zakonczona sukcesem");
                   return true;
               }
               else
               {
                   MessageBox.Show("Blad. Podaj unikalny Kod");
                   return false;

               }
           }
       }

       public bool ValidateVatItem(VatDictionary vatDictionary)
       {
           using (var context = new EntityDataModel())
           {
               if (context.VatDictionary.FirstOrDefault(p => p.Kod == vatDictionary.Kod) == null)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
       }
    }
}
