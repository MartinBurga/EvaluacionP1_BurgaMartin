using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionP1_BurgaMartin.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        [Required]
        public int ValorPago { get; set; }
        public DateOnly FechaEntrada { get; set; }
        public DateOnly FechaSalida { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente cliente { get; set; }
    }
}
