using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PIN.Models
{
    public class PINContext : DbContext
    {
        public PINContext (DbContextOptions<PINContext> options)
            : base(options)
        {
        }

        public DbSet<PIN.Models.Movie> Movie { get; set; }
    }
}
