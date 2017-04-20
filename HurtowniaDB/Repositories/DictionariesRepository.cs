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
       public bool AddJmeItem(JmeDictionary jmeDictionary)
       {
           using (var context = new EntityDataModel())
           {
               if (ValidateJmeItem(jmeDictionary))
               {
                   context.JmeDictionary.Add(jmeDictionary);
                   context.SaveChanges();
                   return true;
               }
               else
               {
                   return false;
               }
           }
       }

        public bool AddVatItem(VatDictionary vatDictionary)
        {
            try
            {
                using (var context = new EntityDataModel())
                {

                    if (ValidateVatItem(vatDictionary))
                    {

                        
                        context.VatDictionary.Add(vatDictionary);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
                (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

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

       public bool EditJmeItem(JmeDictionary jmeDictionary)
       {
           using (var contex = new EntityDataModel())
           {
               JmeDictionary jmeToEdit = contex.JmeDictionary.FirstOrDefault(p => p.ID == jmeDictionary.ID);
               if (jmeToEdit != null && ValidateJmeItem(jmeDictionary))
               {
                   jmeToEdit.Jme = jmeDictionary.Jme;
                   jmeToEdit.Kod = jmeDictionary.Kod;
                    contex.SaveChanges();
                    return true;
                }
               else
               {
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

       public bool ValidateJmeItem(JmeDictionary jmeDictionary)
       {
           using (var contex = new EntityDataModel())
           {
               if (contex.JmeDictionary.FirstOrDefault(p => p.Kod == jmeDictionary.Kod) == null)
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
