﻿// <auto-generated />
using GamesListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamesListing.Migrations
{
    [DbContext(typeof(GamesListingDbContext))]
    partial class GamesListingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GamesListing.Data.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bayonetta",
                            Rating = 8.9f
                        },
                        new
                        {
                            Id = 2,
                            Name = "Devil May Cry 5: Special Edition",
                            Rating = 8.4f
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tales of Arise",
                            Rating = 8.7f
                        });
                });

            modelBuilder.Entity("GamesListing.Data.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "https://store.steampowered.com/",
                            Name = "Steam"
                        },
                        new
                        {
                            Id = 2,
                            Address = "https://www.origin.com/en-us/store/",
                            Name = "Origin"
                        },
                        new
                        {
                            Id = 3,
                            Address = "https://www.uplay.com/en-us/",
                            Name = "Uplay"
                        },
                        new
                        {
                            Id = 4,
                            Address = "https://store.epicgames.com/en-US/",
                            Name = "Epic Games Store"
                        },
                        new
                        {
                            Id = 5,
                            Address = "https://www.xbox.com/pt-BR/games/all-games",
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("GameStore", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<int>("storesId")
                        .HasColumnType("int");

                    b.HasKey("GamesId", "storesId");

                    b.HasIndex("storesId");

                    b.ToTable("GameStore");
                });

            modelBuilder.Entity("GameStore", b =>
                {
                    b.HasOne("GamesListing.Data.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesListing.Data.Store", null)
                        .WithMany()
                        .HasForeignKey("storesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
