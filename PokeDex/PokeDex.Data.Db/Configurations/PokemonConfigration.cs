using PokeDex.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokeDex.Data.Db.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(a => a.PersonId);
            builder
                .HasOne(a => a.Person)
                .WithOne(p => p.Address)
                .HasForeignKey<Person>(p => p.Id);
            builder
                .Property(a => a.Street)
                .HasMaxLength(500)
                .IsRequired(true);
            builder
                .Property(a => a.City)
                .HasMaxLength(500)
                .IsRequired(true);
            builder
                .Property(a => a.Country)
                .HasMaxLength(500)
                .IsRequired(true);
        }
    }
}
