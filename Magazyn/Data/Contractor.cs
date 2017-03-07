namespace Magazyn.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contractor")]
    public partial class Contractor
    {
        public int ID { get; set; }

        [Required]
        [StringLength(1)]
        public string ZNAK { get; set; }

        [StringLength(15)]
        public string SKROTK { get; set; }

        [StringLength(10)]
        public string REGON { get; set; }

        [StringLength(1)]
        public string KODNIP { get; set; }

        [StringLength(11)]
        public string NIP { get; set; }

        [StringLength(30)]
        public string NAZK1 { get; set; }

        [StringLength(30)]
        public string NAZK2 { get; set; }

        [StringLength(6)]
        public string KODPOCZK { get; set; }

        [StringLength(25)]
        public string MIEJSCEK { get; set; }

        [StringLength(20)]
        public string ULICAK { get; set; }

        [StringLength(6)]
        public string NRMK { get; set; }

        [StringLength(11)]
        public string TELK { get; set; }

        [StringLength(11)]
        public string TLMK { get; set; }
    }
}
