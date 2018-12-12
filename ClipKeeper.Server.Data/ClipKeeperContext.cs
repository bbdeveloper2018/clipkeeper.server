using ClipKeeper.Server.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Data
{
    public class ClipKeeperContext : DbContext
    {
        public ClipKeeperContext(DbContextOptions<ClipKeeperContext> options)
            :base(options)
        {
        }
        public DbSet<Star> Stars { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StarVideo>()
                .HasKey(s => new { s.StarId, s.VideoId });
        }

    }
}
