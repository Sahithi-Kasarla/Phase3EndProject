using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase3EndProject.Models;

namespace Phase3EndProject.Data
{
    public class Project3Context : DbContext
    {
        public Project3Context (DbContextOptions<Project3Context> options)
            : base(options)
        {
        }

        public DbSet<Phase3EndProject.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<Phase3EndProject.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
