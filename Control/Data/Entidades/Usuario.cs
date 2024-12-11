using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string CorreoUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string TipoUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string RolUsuario { get; set; }

        public ICollection<Incidencias> Incidencias { get; set; }

    }
}
