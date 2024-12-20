using System;
using System.ComponentModel.DataAnnotations;

namespace Control.Data.Entidades
{
    public class Incidencias
    {
        [Key]
        [Required(ErrorMessage = "El id es obligatorio")]
        [Range(0, 99999, ErrorMessage = "El rango como máximo es de cinco dígitos")]
        public int IdIncidencias { get; set; }

        [StringLength(1000, ErrorMessage = "La descripción debe tener 1000 caracteres")]
        [MaxLength(1000)]
        public string DescInc { get; set; }

        [Required]
        public DateTime FechaReporte { get; set; }

        public DateTime FechaSolucion { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio")]
        public string Rol { get; set; }

        [Required(ErrorMessage = "La razón es obligatoria")]
        public string Razon { get; set; }

        // Constructor para inicializar la fecha de solución
        public Incidencias()
        {
            FechaReporte = DateTime.Now; // Fecha actual
            FechaSolucion = FechaReporte.AddDays(15); // Por defecto, 15 días después de FechaReporte
        }
    }

    public enum Rol
    {
        JorgeVega = 0,
        Kim  = 1,
        Carlitos = 2,
        Noa = 3,
    }

    public enum RazonIncidencia
    {
        ErrorSistema = 0,
        Mantenimiento = 1,
        SolicitudUsuario =2,
        Otro = 3
    }
}
