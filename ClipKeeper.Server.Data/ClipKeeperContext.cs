using ClipKeeper.Server.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ClipKeeper.Server.Data
{
    public class ClipKeeperContext : DbContext
    {
        public ClipKeeperContext(DbContextOptions<ClipKeeperContext> options)
            :base(options)
        {
        }

        public DbSet<Performer> Performers { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Dvd> Dvds { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dvd>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Dvd>()
                .Property(e => e.UpdateStamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Performer>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Performer>()
                .Property(e => e.UpdateStamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Studio>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Studio>()
                .Property(e => e.UpdateStamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Video>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Video>()
                .Property(e => e.UpdateStamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");


            modelBuilder.Entity<PerformerVideo>()
                .HasKey(x => new { x.PerformerId, x.VideoId });
            
            modelBuilder.Entity<VideoTag>()
                .HasKey(x => new { x.VideoId, x.TagId });

            modelBuilder.Entity<PerformerImage>()
                .HasKey(x => new { x.PerformerId, x.ImageId });

            //This will singularize all table names
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }
        }

    }
}
