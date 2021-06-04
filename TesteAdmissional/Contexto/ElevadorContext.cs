using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAdmissional.Models;

namespace TesteAdmissional.Contexto
{
    public class ElevadorContext:DbContext
    {
        public ElevadorContext(DbContextOptions<ElevadorContext> options) : base(options)
        {
        }
        public DbSet<Elevador> Elevadores { get; set; }


    }
}
