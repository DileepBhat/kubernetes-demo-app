﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData.EFDAL
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public CompanyDbContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
