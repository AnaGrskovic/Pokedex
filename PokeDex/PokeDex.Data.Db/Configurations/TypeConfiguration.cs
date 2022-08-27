using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeDex.Contracts.Mocks;

namespace PokeDex.Data.Db.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Contracts.Models.Type>
    {
        public void Configure(EntityTypeBuilder<Contracts.Models.Type> builder)
        {
            builder.HasKey(a => a.TypeId);
            builder
                .Property(a => a.Name)
                .HasMaxLength(500)
                .IsRequired(true);
            builder
                .HasMany(p => p.PokemonTypes)
                .WithOne(pt => pt.Type);
            builder.HasData(TypeMocks.Types);
        }
    }
}