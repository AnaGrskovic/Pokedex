using PokeDex.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PokeDex.Data.Db.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(500)
                .IsRequired(true);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(500)
                .IsRequired(true);
        }
    }
}
