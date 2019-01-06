﻿// <auto-generated />
using System;
using ClipKeeper.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClipKeeper.Server.Data.Migrations
{
    [DbContext(typeof(ClipKeeperContext))]
    partial class ClipKeeperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ClipKeeper.Server.Domain.Dvd", b =>
                {
                    b.Property<int>("DvdId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BackCoverPath");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("FrontCoverPath");

                    b.Property<string>("Notes");

                    b.Property<int>("Rating");

                    b.Property<int>("ReleaseYear");

                    b.Property<int?>("StudioId");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateStamp")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("DvdId");

                    b.HasIndex("StudioId");

                    b.ToTable("Dvd");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsPrimary");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Performer", b =>
                {
                    b.Property<int>("PerformerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<int>("Rating");

                    b.Property<DateTime>("UpdateStamp")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("PerformerId");

                    b.ToTable("Performer");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.PerformerImage", b =>
                {
                    b.Property<int>("PerformerId");

                    b.Property<int>("ImageId");

                    b.HasKey("PerformerId", "ImageId");

                    b.HasIndex("ImageId");

                    b.ToTable("PerformerImage");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.PerformerVideo", b =>
                {
                    b.Property<int>("PerformerId");

                    b.Property<int>("VideoId");

                    b.HasKey("PerformerId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("PerformerVideo");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Studio", b =>
                {
                    b.Property<int>("StudioId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateStamp")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("StudioId");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Video", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("DvdId");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("PosterImagePath");

                    b.Property<string>("PreviewPath");

                    b.Property<int>("Rating");

                    b.Property<DateTime>("UpdateStamp")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("WebsiteId");

                    b.HasKey("VideoId");

                    b.HasIndex("DvdId");

                    b.HasIndex("WebsiteId");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.VideoTag", b =>
                {
                    b.Property<int>("VideoId");

                    b.Property<int>("TagId");

                    b.HasKey("VideoId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("VideoTag");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Website", b =>
                {
                    b.Property<int>("WebsiteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("SiteUrl");

                    b.HasKey("WebsiteId");

                    b.ToTable("Website");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Dvd", b =>
                {
                    b.HasOne("ClipKeeper.Server.Domain.Studio", "Studio")
                        .WithMany()
                        .HasForeignKey("StudioId");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.PerformerImage", b =>
                {
                    b.HasOne("ClipKeeper.Server.Domain.Image", "Image")
                        .WithMany("PerformerImages")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClipKeeper.Server.Domain.Performer", "Performer")
                        .WithMany("PerformerImages")
                        .HasForeignKey("PerformerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.PerformerVideo", b =>
                {
                    b.HasOne("ClipKeeper.Server.Domain.Performer", "Performer")
                        .WithMany("PerformerVideos")
                        .HasForeignKey("PerformerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClipKeeper.Server.Domain.Video", "Video")
                        .WithMany("PerformerVideos")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Video", b =>
                {
                    b.HasOne("ClipKeeper.Server.Domain.Dvd", "Dvd")
                        .WithMany()
                        .HasForeignKey("DvdId");

                    b.HasOne("ClipKeeper.Server.Domain.Website", "Website")
                        .WithMany()
                        .HasForeignKey("WebsiteId");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.VideoTag", b =>
                {
                    b.HasOne("ClipKeeper.Server.Domain.Tag", "Tag")
                        .WithMany("VideoTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClipKeeper.Server.Domain.Video", "Video")
                        .WithMany("VideoTags")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
