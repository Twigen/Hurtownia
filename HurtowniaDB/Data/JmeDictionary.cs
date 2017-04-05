using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaDB.Data
{
    [Table("JmeDictionary")]
   public class JmeDictionary
    {
        [Key]
        public int ID { get; set; }

        public int Kod { get; set; }
        public string Jme { get; set; }
    }
}
