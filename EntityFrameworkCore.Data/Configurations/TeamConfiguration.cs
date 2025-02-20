﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Data.Configurations
{
    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {

            builder.HasIndex(q => q.Name).IsUnique();
            builder.HasMany(q => q.HomeMatchs).WithOne(q => q.HomeTeam)
                .HasForeignKey(q => q.HomeTeamId)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(q => q.AwayMatchs).WithOne(q => q.AwayTeam)
                .HasForeignKey(q => q.AwayTeamId)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new Team
                {
                    Id = 1,
                    Name = "Tivoli Gardens F.C",
                    CreatedDate = new DateTime(2021, 02, 01),
                    LeagueId= 1,
                    CoachId = 1
                },
                new Team
                {
                    Id = 2,
                    Name = "Waterhouse F.C",
                    CreatedDate = new DateTime(2021, 02, 01),
                    LeagueId = 1,
                    CoachId = 2
                },
                new Team
                {
                    Id = 3,
                    Name = "Arsenal",
                    CreatedDate = new DateTime(2021, 02, 01),
                    LeagueId = 3,
                    CoachId = 3,
                    
                }
            );


        }
    }
}
