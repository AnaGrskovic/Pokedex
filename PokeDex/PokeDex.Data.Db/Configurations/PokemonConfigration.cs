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
                .HasMany(p => p.Type)
                .WithMany(t => t.Pokemon)
                .HasForeignKey("typeId");   // todo: PokemonType for many to many 
            builder
                .Property(a => a.Description)
                .HasMaxLength(5000)
                .IsRequired(true);
            builder
                .HasOne(p2 => p2.EvolvesFrom)
                .WithMany(p1 => p1.EvolvesTo)
                .HasForeignKey("evolvesFromPokemonId");
            builder
                .HasMany(p2 => p2.EvolvesTo)
                .WithOne(p3 => p3.EvolvesFrom)
                .HasForeignKey("evolvesToPokemonId");
        }
    }
}
