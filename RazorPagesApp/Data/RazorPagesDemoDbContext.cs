﻿using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models.Domain;
using System.Collections.Generic;

namespace RazorPagesDemoApp.Data
{
    public class RazorPagesDemoDbContext : DbContext
    {

        public RazorPagesDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
