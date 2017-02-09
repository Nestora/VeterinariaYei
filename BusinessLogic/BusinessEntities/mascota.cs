namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("veterinariayei.mascotas")]
    public partial class mascota
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Raza { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string Especie { get; set; }

        public float Peso { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string Genero { get; set; }

        public int Edad { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaSalida { get; set; }

        public int? Id_dueño { get; set; }
    }
}
