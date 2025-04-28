using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaluacionP1_BurgaMartin.Models;

namespace EvaluacionP1_BurgaMartin.Data
{
    public class EvaluacionP1_SQL_PlanRecompensas : DbContext
    {
        public EvaluacionP1_SQL_PlanRecompensas (DbContextOptions<EvaluacionP1_SQL_PlanRecompensas> options)
            : base(options)
        {
        }

        public DbSet<EvaluacionP1_BurgaMartin.Models.PlanRecompensas> PlanRecompensas { get; set; } = default!;
    }
}
