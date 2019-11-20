using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MaxiKiosco.Models
{
    public class MaxiKioscoContext : DbContext
    {
        public MaxiKioscoContext (DbContextOptions<MaxiKioscoContext> options)
            : base(options)
        {
        }

        public DbSet<MaxiKiosco.Models.Categoria> Categoria { get; set; }
    }
}
