﻿using PokeDex.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokeDex.Data.Db.Configurations
{
    public class PokemonConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(p => p.PokemonId);
            builder
                .Property(p => p.Name)
                .HasMaxLength(500)
                .IsRequired(true);
            builder
                .HasMany(p => p.PokemonTypes)
                .WithOne(pt => pt.Pokemon);
            builder
                .Property(a => a.Description)
                .HasMaxLength(5000)
                .IsRequired(true);
            builder
                .HasOne(p2 => p2.EvolvesFrom)
                .WithMany(p1 => p1.EvolvesTo)
                .HasForeignKey("EvolvesFromPokemonId")
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(p2 => p2.EvolvesTo)
                .WithOne(p3 => p3.EvolvesFrom)
                .HasForeignKey("EvolvesToPokemonId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
