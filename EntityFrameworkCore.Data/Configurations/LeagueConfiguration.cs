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
                Name = "Jamaica Premiere League",
            },
            new League
            {
                Id = 2,
                Name = "English Premiere League",
            },
            new League
            {
                Id = 3,
                Name = "La Liga",
            }
        );

    }

    public void Configure(EntityTypeBuilder<Coach> builder)
    {
        builder.HasData(
            new Coach
            {
                Id = 1,
                Name = "Jose Mourinho",
            },
            new Coach
            {
                Id = 2,
                Name = "Pep Guardiola",
            },
            new Coach
            {
                Id = 3,
                Name = "Sepehr Moonesi",
            }
        );

    }

}