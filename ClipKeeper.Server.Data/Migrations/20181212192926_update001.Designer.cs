﻿// <auto-generated />
using System;
using ClipKeeper.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClipKeeper.Server.Data.Migrations
{
    [DbContext(typeof(ClipKeeperContext))]
    [Migration("20181212192926_update001")]
    partial class update001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("ClipKeeper.Server.Domain.Star", b =>
                {
                    b.Property<int>("StarId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.HasKey("StarId");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.StarVideo", b =>
                {
                    b.Property<int>("StarId");

                    b.Property<int>("VideoId");

                    b.HasKey("StarId", "VideoId");

                    b.HasIndex("VideoId");

                    b.ToTable("StarVideo");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.Video", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.HasKey("VideoId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ClipKeeper.Server.Domain.StarVideo", b =>
                {
                    b.HasOne("ClipKeeper.Server.Domain.Star", "Star")
                        .WithMany("StarVideos")
                        .HasForeignKey("StarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClipKeeper.Server.Domain.Video", "Video")
                        .WithMany("StarVideos")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
