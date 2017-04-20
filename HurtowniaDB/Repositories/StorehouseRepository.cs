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
    public class StorehouseRepository
    {
        public bool AddStorehouseItem(Storehouse storehouse,int vat, string jme)
        {
            try
            {
                using (var context = new EntityDataModel())
                {

                    if (ValidateStorehouseItem(storehouse))
                    {

                        storehouse.VAT = vat.ToString();
                        storehouse.JME = jme;
                        context.Storehouse.Add(storehouse);
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw exception;
            }
        }


        public bool ValidateStorehouseItem(Storehouse storehouse)
        {
            using (var context = new EntityDataModel())
            {
                if (context.Storehouse.FirstOrDefault(p => p.MAGAZ == storehouse.MAGAZ) == null)
                    return true;
                else return false;
            }
        }

        public List<Storehouse> GetStorehouseItems()
        {
            using (var context = new EntityDataModel())
                return context.Storehouse.ToList();
        }

//bool powinien byc
        public void EditStorehouseItem(Storehouse storehouse)
        {
            using (var context = new EntityDataModel())
            {
                Storehouse storehouseToEdit = context.Storehouse.FirstOrDefault(p => p.ID == storehouse.ID);
                if (storehouseToEdit != null && ValidateStorehouseItem(storehouse))
                {
                    {
                        storehouseToEdit.ID = storehouse.ID;
                        storehouseToEdit.JME = storehouse.JME;
                        storehouseToEdit.KTM = storehouse.KTM;
                        storehouseToEdit.MAGAZ = storehouse.MAGAZ;
                        storehouseToEdit.NAZWAK = storehouse.NAZWAK;
                        storehouseToEdit.PIK = storehouse.PIK;
                        storehouseToEdit.PIM = storehouse.PIM;
                        storehouseToEdit.PRZECALL = storehouse.PRZECALL;
                        storehouseToEdit.PWK = storehouse.PWK;
                        storehouseToEdit.PWM = storehouse.PWM;
                        storehouseToEdit.RIK = storehouse.RIK;
                        storehouseToEdit.RIM = storehouse.RIM;
                        storehouseToEdit.RWK = storehouse.RWK;
                        storehouseToEdit.RWM = storehouse.RWM;
                        storehouseToEdit.SPIS = storehouse.SPIS;
                        storehouseToEdit.STANII = storehouse.STANII;
                        storehouseToEdit.STANKI = storehouse.STANKI;
                        storehouseToEdit.STANKW = storehouse.STANKW;
                        storehouseToEdit.STANOG = storehouse.STANOG;
                        storehouseToEdit.STANPI = storehouse.STANPI;
                        storehouseToEdit.STANPW = storehouse.STANPW;
                        storehouseToEdit.VAT = storehouse.VAT;
                        storehouseToEdit.WIELK = storehouse.WIELK;
                        storehouseToEdit.ZNAK = storehouse.ZNAK;
                        storehouseToEdit.CENA = storehouse.CENA;
                        storehouseToEdit.CENA2 = storehouse.CENA2;
                        storehouseToEdit.CK = storehouse.CK;
                        storehouseToEdit.DATAP = storehouse.DATAP;
                        storehouseToEdit.DATAR = storehouse.DATAR;
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

        public void DeleteStorehouseItem(string magaz)
        {
            using (var context = new EntityDataModel())
            {
                var storehouseItemToDelete = context.Storehouse.FirstOrDefault(p => p.MAGAZ == magaz);
                if (storehouseItemToDelete == null)
                    return;

                context.Storehouse.Remove(storehouseItemToDelete);
                context.SaveChanges();
            }
        }
    }
}
