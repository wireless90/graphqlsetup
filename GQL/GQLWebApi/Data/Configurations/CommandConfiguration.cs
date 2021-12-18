using GQLWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GQLWebApi.Data.Configurations
{
    public class CommandConfiguration : IEntityTypeConfiguration<Command>
    {
        public void Configure(EntityTypeBuilder<Command> builder)
        {
            builder
                .ToTable("Commands");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.HowTo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.CommandLine)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Property(x => x.PlatformId)
                .IsRequired();

        }
    }
}
