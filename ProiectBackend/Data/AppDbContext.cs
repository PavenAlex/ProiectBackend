﻿using Microsoft.EntityFrameworkCore;
using ProiectBackend.Models;

namespace ProiectBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
    }
}