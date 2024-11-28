using Microsoft.EntityFrameworkCore;
using System;
using TP3.Models;

namespace TP3.Data
{
    public class ConcertContext : DbContext
    {
        public ConcertContext(DbContextOptions<ConcertContext> options)
        : base(options)
        {
        }

        public DbSet<Concert> Concerts { get; set; }
    }
}
