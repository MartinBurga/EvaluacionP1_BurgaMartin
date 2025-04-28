using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionP1_BurgaMartin.Models
{
    public class PlanRecompensas
    {
        [Key]
        [Required]
        public int IdPlan { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        public DateOnly fechaInicio { get; set; }
        public int pntos { get; set; }
        public String Recompensa
        {
            get
            {
                if (pntos < 500)
                    return "SILVER";
                else
                    return "GOLD";
            }
        }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente cliente { get; set; }
    }
}
