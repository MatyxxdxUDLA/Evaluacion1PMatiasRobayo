using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Evaluacion1PMatiasRobayo.Models;

namespace Evaluacion1PMatiasRobayo.Data
{
    public class Evaluacion1PMatiasRobayoContext : DbContext
    {
        public Evaluacion1PMatiasRobayoContext (DbContextOptions<Evaluacion1PMatiasRobayoContext> options)
            : base(options)
        {
        }

        public DbSet<Evaluacion1PMatiasRobayo.Models.MRobayo> MRobayo { get; set; } = default!;
        public DbSet<Evaluacion1PMatiasRobayo.Models.Carrera> Carrera { get; set; } = default!;
    }
}
