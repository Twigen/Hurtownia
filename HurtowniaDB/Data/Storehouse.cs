using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaDB.Data
{
    [Table("Storehouse")]
   public class Storehouse
    {
        public int? ID { get; set; }

        
        [StringLength(1)]
        public string ZNAK { get; set; }

        [StringLength(2)]
        public string MAGAZ { get; set; }

        [StringLength(12)]
        public string KTM { get; set; }

        [StringLength(1)]
        public string CK { get; set; }

        [StringLength(20)]
        public string NAZWAK { get; set; }

        [StringLength(15)]
        public string WIELK { get; set; }

        public double? CENA { get; set; }

        public double? CENA2 { get; set; }

        [StringLength(2)]
        public string VAT { get; set; }

        [StringLength(4)]
        public string JME { get; set; }

        public double? STANPI { get; set; }

        public double? PIK { get; set; }

        public double? RIK { get; set; }

        public double? STANKI { get; set; }

        public double? STANOG { get; set; }

        public double? STANPW { get; set; }

        public double? PWK { get; set; }

        public double? RWK { get; set; }

        public double? STANKW { get; set; }

        public double? PRZECALL { get; set; }

        public double? PIM { get; set; }

        public double? RIM { get; set; }

        public double? PWM { get; set; }

        public double? RWM { get; set; }

        public DateTime DATAP {get; set; }

        public DateTime DATAR { get; set; }

        public DateTime? SPIS { get; set; }

        public double? STANII { get; set; }
    }
}
