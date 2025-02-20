using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Data.Configurations;

internal class LeagueConfiguration : IEntityTypeConfiguration<League>
{
    public void Configure(EntityTypeBuilder<League> builder)
    {
        builder.HasData(
            new League
            {
                Id = 1,
                Name = "Jamaica Premiere League L",
            },
            new League
            {
                Id = 2,
                Name = "English Premiere League L",
            },
            new League
            {
                Id = 3,
                Name = "La Liga L",
            },
        new League
            {
                Id = 4,
                Name = "Other",
            }
        );

    }


}