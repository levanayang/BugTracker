using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BugTracker.Models;

namespace BugTracker.Data
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Ticket>(entity =>
        //    {
        //        entity.Property(e => e.TicketStatus)
        //            .HasConversion(x => (int)x, x => (Status)x);

        //        entity.Property(e => e.TicketPriority)
        //            .HasConversion(x => (int)x, x => (Priority)x);
        //    });
        //}

        public DbSet<Ticket> Ticket { get; set; }
    }
}
