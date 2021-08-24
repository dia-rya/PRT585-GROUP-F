using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

    public class MvcCategoryContext : DbContext
    {
        public MvcCategoryContext (DbContextOptions<MvcCategoryContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie.Models.Category> Category { get; set; }
    }
