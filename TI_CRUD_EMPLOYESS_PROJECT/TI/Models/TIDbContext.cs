using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TI.Models
{
    public class TIDbContext: DbContext
    {
        public TIDbContext(DbContextOptions<TIDbContext> options) :
            base(options)
            {

        }
        public DbSet<Employee> Employees { get; set; }
    }
    
}
