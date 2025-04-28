using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaluacionP1_BurgaMartin.Models;

namespace EvaluacionP1_BurgaMartin.Data
{
    public class EvaluacionP1_SQLserver : DbContext
    {
        public EvaluacionP1_SQLserver (DbContextOptions<EvaluacionP1_SQLserver> options)
            : base(options)
        {
        }

        public DbSet<EvaluacionP1_BurgaMartin.Models.Cliente> Cliente { get; set; } = default!;
    }
}
