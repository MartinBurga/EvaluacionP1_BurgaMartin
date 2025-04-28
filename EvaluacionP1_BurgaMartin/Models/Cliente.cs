using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionP1_BurgaMartin.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength]
        public string Nombre { get; set; }
        public bool PagoRealizado { get; set; }
        public DateOnly FechaPago { get; set; }
        public double Monto { get; set; }
       

    }
}
