namespace BusinessEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VetModel : DbContext
    {
        public VetModel()
            : base("name=VetModel")
        {
        }

        public virtual DbSet<mascota> mascotas { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mascota>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<mascota>()
                .Property(e => e.Raza)
                .IsUnicode(false);

            modelBuilder.Entity<mascota>()
                .Property(e => e.Especie)
                .IsUnicode(false);

            modelBuilder.Entity<mascota>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);
        }
    }
}
