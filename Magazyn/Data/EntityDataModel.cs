namespace Magazyn.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EntityDataModel")
        {
        }

        public virtual DbSet<Contractor> Contractor { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contractor>()
                .Property(e => e.ZNAK)
                .IsFixedLength();

            modelBuilder.Entity<Contractor>()
                .Property(e => e.REGON)
                .IsFixedLength();

            modelBuilder.Entity<Contractor>()
                .Property(e => e.KODNIP)
                .IsFixedLength();

            modelBuilder.Entity<Contractor>()
                .Property(e => e.NIP)
                .IsFixedLength();

            modelBuilder.Entity<Contractor>()
                .Property(e => e.KODPOCZK);

            modelBuilder.Entity<Contractor>()
                .Property(e => e.NRMK)
                .IsFixedLength();

            modelBuilder.Entity<Contractor>()
                .Property(e => e.TELK)
                .IsFixedLength();

            modelBuilder.Entity<Contractor>()
                .Property(e => e.TLMK)
                .IsFixedLength();

           
        }
    }
}
