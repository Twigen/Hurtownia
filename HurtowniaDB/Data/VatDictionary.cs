using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaDB.Data
{
    [Table("VatDictionary")]
   public class VatDictionary
    {
        [Key]
        public int ID { get; set; }

        public int Kod { get; set; }
        public int Vat { get; set; }
    }
}
