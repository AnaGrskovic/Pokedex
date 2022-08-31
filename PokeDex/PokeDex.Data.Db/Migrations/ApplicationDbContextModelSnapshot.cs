﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokeDex.Data.Db.Configurations;

#nullable disable

namespace PokeDex.Data.Db.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PokeDex.Contracts.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokemonId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EvolvesFromPokemonId")
                        .HasColumnType("int");

                    b.Property<int>("EvolvesToPokemonId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("PokemonId");

                    b.HasIndex("EvolvesToPokemonId");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.PokemonType", b =>
                {
                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("PokemonId", "TypeId");

                    b.HasIndex("TypeId");

                    b.ToTable("PokemonType");
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("TypeId");

                    b.ToTable("Type");

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            Name = "Normal"
                        },
                        new
                        {
                            TypeId = 2,
                            Name = "Fire"
                        },
                        new
                        {
                            TypeId = 3,
                            Name = "Water"
                        },
                        new
                        {
                            TypeId = 4,
                            Name = "Grass"
                        },
                        new
                        {
                            TypeId = 5,
                            Name = "Electric"
                        },
                        new
                        {
                            TypeId = 6,
                            Name = "Ice"
                        },
                        new
                        {
                            TypeId = 7,
                            Name = "Fighting"
                        },
                        new
                        {
                            TypeId = 8,
                            Name = "Poison"
                        },
                        new
                        {
                            TypeId = 9,
                            Name = "Ground"
                        },
                        new
                        {
                            TypeId = 10,
                            Name = "Flying"
                        },
                        new
                        {
                            TypeId = 11,
                            Name = "Psychic"
                        },
                        new
                        {
                            TypeId = 12,
                            Name = "Bug"
                        },
                        new
                        {
                            TypeId = 13,
                            Name = "Rock"
                        },
                        new
                        {
                            TypeId = 14,
                            Name = "Ghost"
                        },
                        new
                        {
                            TypeId = 15,
                            Name = "Dark"
                        },
                        new
                        {
                            TypeId = 16,
                            Name = "Dragon"
                        },
                        new
                        {
                            TypeId = 17,
                            Name = "Steel"
                        },
                        new
                        {
                            TypeId = 18,
                            Name = "Fairy"
                        });
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.Pokemon", b =>
                {
                    b.HasOne("PokeDex.Contracts.Models.Pokemon", "EvolvesFrom")
                        .WithMany("EvolvesTo")
                        .HasForeignKey("EvolvesToPokemonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EvolvesFrom");
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.PokemonType", b =>
                {
                    b.HasOne("PokeDex.Contracts.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonTypes")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeDex.Contracts.Models.Type", "Type")
                        .WithMany("PokemonTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.Pokemon", b =>
                {
                    b.Navigation("EvolvesTo");

                    b.Navigation("PokemonTypes");
                });

            modelBuilder.Entity("PokeDex.Contracts.Models.Type", b =>
                {
                    b.Navigation("PokemonTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
