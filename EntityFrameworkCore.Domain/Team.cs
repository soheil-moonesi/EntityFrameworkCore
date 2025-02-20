namespace EntityFrameworkCore.Domain;

public class Team : BaseDomainModel
{
    public string? Name { get; set; }

    public League? League { get; set; }
    public int? LeagueId { get; set; }

    public Coach Coach { get; set; }
    public int CoachId { get; set; }

    public List<Match> HomeMatchs { get; set; } = new List<Match>() { };
    public List<Match> AwayMatchs { get; set; } = new List<Match>() { };

} 