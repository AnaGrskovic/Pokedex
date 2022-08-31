using PokeDex.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.AnaGrskovic.Data.Db.Configurations
{
    public class PokemonTypeConfiguration : IEntityTypeConfiguration<PokemonType>
    {
        public void Configure(EntityTypeBuilder<PokemonType> builder)
        {
            builder
                .HasKey(pt => new { PokemonId = pt.PokemonId, TypeId = pt.TypeId });

            builder
                .HasOne(pt => pt.Pokemon)
                .WithMany(p => p.PokemonTypes)
                .HasForeignKey("PokemonId");

            builder
                .HasOne(pt => pt.Type)
                .WithMany(t => t.PokemonTypes)
                .HasForeignKey("TypeId");
        }
    }
}
