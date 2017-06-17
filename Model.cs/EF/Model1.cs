namespace Model.cs.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<genPromoRight> genPromoRights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.ImageURL)
                .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.AltText)
                .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.OfferTag)
                .IsUnicode(false);

            modelBuilder.Entity<genPromoRight>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}
