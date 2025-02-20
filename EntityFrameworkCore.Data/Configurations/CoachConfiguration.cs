using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data.Configurations
{
    internal class CoachConfiguration :IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasData(
                new Coach
                {
                    Id = 1,
                    Name = "Jose Mourinho C",
                },
                new Coach
                {
                    Id = 2,
                    Name = "Pep Guardiola C",
                },
                new Coach
                {
                    Id = 3,
                    Name = "Sepehr Moonesi C",
                },
                new Coach
                {
                    Id = 4,
                    Name = "Soheil Moonesi ",
                }
            );

        }

    }
}
