﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Match :BaseDomainModel
    {
        public decimal TicketPrice { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        
        public Team HomeTeam { get; set; } 
        public int HomeTeamId { get; set; }

        public Team AwayTeam { get; set; }
        public int AwayTeamId { get; set; }

    }
}
