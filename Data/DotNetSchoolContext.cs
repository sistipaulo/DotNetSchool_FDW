using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetSchool.Models;

namespace DotNetSchool.Data
{
    public class DotNetSchoolContext : DbContext
    {
        public DotNetSchoolContext (DbContextOptions<DotNetSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetSchool.Models.Student> Student { get; set; } = default!;

        public DbSet<DotNetSchool.Models.Teacher>? Teacher { get; set; }

        public DbSet<DotNetSchool.Models.Event>? Event { get; set; }

        public DbSet<DotNetSchool.Models.Class>? Class { get; set; }

        public DbSet<DotNetSchool.Models.Schedule>? Schedule { get; set; }
    }
}
