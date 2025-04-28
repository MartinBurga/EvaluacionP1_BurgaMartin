using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace EvaluacionP1_BurgaMartin.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [AllowNull]
        public bool PagoRealizado { get; set; }
        public DateOnly FechaPago { get; set; }
        [Required]
        public double Monto { get; set; }
       

    }
}
