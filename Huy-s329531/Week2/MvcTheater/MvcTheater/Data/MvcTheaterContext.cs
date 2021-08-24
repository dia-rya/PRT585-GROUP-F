using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTheater.Models;

namespace MvcTheater.Data
{
    public class MvcTheaterContext : DbContext
    {
        public MvcTheaterContext (DbContextOptions<MvcTheaterContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTheater.Models.Movie> Movie { get; set; }
    }
}
