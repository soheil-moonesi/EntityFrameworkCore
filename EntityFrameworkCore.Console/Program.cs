using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.VisualBasic;

var context = new FootballLeagueDbContext();
await context.Database.MigrateAsync();



//GetAllTeams();
async Task GetAllTeams()
{
    var teams = await context.Teams.ToListAsync();

    foreach (var t in teams)
    {
        Console.WriteLine(t.Name);
    }
}

//var teamOne = await context.Teams.FirstAsync();
//var teamTwo = await context.Teams.FirstAsync(q => q.Id == 1);
//var teamTwo = await context.Teams.FirstOrDefaultAsync(q => q.Id == 1);

//var teamThree = await context.Teams.SingleAsync(team=>team.Id==2);
//var teamThree = await context.Teams.SingleOrDefaultAsync(team => team.Id == 2);

//var teamBasedOnId = await context.Teams.FindAsync(3);

//if (teamBasedOnId!=null)
//{ 
//    Console.WriteLine(teamBasedOnId.Name);
//}


//GetFilteredTeams();
//async Task GetFilteredTeams()
//{
//    Console.WriteLine("Enter Desired Team");
//    var searchTerm = Console.ReadLine();
//    var teamsFiltered = await context.Teams.Where(q => q.Name == searchTerm).ToListAsync();
//    foreach (var team in teamsFiltered)
//    {
//        Console.WriteLine(team.Name); 
//    }

//    var partialMatches = await context.Teams.Where(q => q.Name.Contains(searchTerm)).ToListAsync();



//    foreach (var item in partialMatches)
//    {
//        Console.WriteLine(item.Name);
//    }

//    var partialMatchesEf = await context.Teams.
//        Where(q => EF.Functions.Like(q.Name,
//            $"%{searchTerm}%"))
//        .ToListAsync();

//    foreach (var item in partialMatchesEf)
//    {
//        Console.WriteLine(item.Name);
//    }
//}

//GetAllTeamsQuerySyntax();
async Task GetAllTeamsQuerySyntax()
{
    Console.WriteLine("Enter Desired Team");
    var searchTerm = Console.ReadLine();

    var teams = await (from team in context.Teams where EF.Functions.Like(team.Name, $"%{searchTerm}%")
       select team ).ToListAsync();
    foreach (var t in teams)
    {
        Console.WriteLine(t.Name);
    }
}

// var numberOfTeams = await context.Teams.CountAsync();
//Console.WriteLine(numberOfTeams);

//var numberOfTeamsWithCondition= await context.Teams.CountAsync(q=>q.Id== 1);
//Console.WriteLine(numberOfTeamsWithCondition);

//var maxTeams = await context.Teams.MaxAsync(q=>q.Id);

//var minTeams = await context.Teams.MinAsync(q=>q.Id);

//var avgTeams = await context.Teams.AverageAsync(q=>q.Id);

//var sumTeams = await context.Teams.SumAsync(q=>q.Id);

  //var groupTeams  = context.Teams.GroupBy(q=>new {q.CreatedDate.Date});
  //foreach (var group in groupTeams)
  //{
      
  //    Console.WriteLine(group.Key);
  //    Console.WriteLine(group.Sum(q => q.Id));

  //  foreach (var team in group)
  //    {
  //      Console.WriteLine(team.Name);
  //  }
  //}

  //var orderedTeams =await context.Teams.OrderByDescending(q=>q.Name).ToListAsync();
  //foreach (var team in orderedTeams)
  //{
  //    Console.WriteLine(team.Name);
  //}

  //var orderedTeamsResult = context.Teams.ToListAsync().Result
  //    .OrderByDescending(q=>q.Name);

  //foreach (var team in orderedTeamsResult)
  //{
  //    Console.WriteLine(team.Name);
  //}

  //var recordCount = 3;
  //var page = 0;
  //var next = true;
  //while (next)
  //{
  //  var teams =await context.Teams.Skip(page *recordCount)
  //      .Take(recordCount).ToListAsync();
  //  foreach (var team in teams)
  //  {
  //  Console.WriteLine(team.Name);
  //  }
  //  Console.WriteLine("true or false");
  //  next = Convert.ToBoolean(Console.ReadLine()); 
  //  if (!next) break;
  //  page+=1;
  //}

//var teams = await context.Teams
//    .Select(q=>new TeamInfo{ Name = q.Name, Id = q.Id})
//    .ToListAsync();

//foreach (var t in teams)
//{
//    Console.WriteLine($"{t.Name} {t.Id}");
//}

//class TeamInfo
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}

 // var teams =await context.Teams.AsNoTracking().ToListAsync();


//// IQuerybales vs List types
//Console.WriteLine("enter 1 for team with id or 2 for teams that contain 'F.C.' ");
//var option =Convert.ToInt32( Console.ReadLine());
//List<Team> teamsAsList = new List<Team>();

//teamsAsList = await context.Teams.ToListAsync();
//if (option==1)
//{
//    teamsAsList = teamsAsList.Where(q => q.Id == 1).ToList();
//}
//else if (option == 2)
//{
//    teamsAsList = teamsAsList.Where(q=>q.Name.Contains("F.C.")).ToList();
//}

//foreach (var t in teamsAsList)
//{
//    Console.WriteLine(t.Name);
//}

//var teamsAsQueryable =  context.Teams.AsQueryable();
//if (option == 1)
//{
//   teamsAsQueryable = teamsAsQueryable.Where(q => q.Id == 1);
//}

//if (option==2)
//{
//    teamsAsQueryable = teamsAsQueryable.Where(q => q.Name.Contains("F.C."));
//}
//foreach (var t in teamsAsQueryable)
//{
//    Console.WriteLine(t.Name);
//}

//insert data

//simple insert
var newCoach = new Coach()
{
    Name = "Jose Mourinho",
    CreatedDate = DateTime.Now,
};
//await context.Coaches.AddAsync(newCoach);  
//await context.SaveChangesAsync(); 

var newCoach1 = new Coach()
{
    Name = "Theodore Whitmore",
    CreatedDate = DateTime.Now,
};

List<Coach> Coaches = new List<Coach>
{
    newCoach,
    newCoach1
};

//foreach (var coach in Coaches)
//{
//   await context.Coaches.AddAsync(coach);
//}
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//await context.SaveChangesAsync();
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//await context.Coaches.AddRangeAsync(Coaches);
//await context.SaveChangesAsync();

//var coach =await context.Coaches.FindAsync(3);
//coach.Name = "Soheil Moonesi";
//await context.SaveChangesAsync();

//var coach1 = await context.Coaches.AsNoTracking()
//    .FirstOrDefaultAsync(q=>q.Id==2);
//coach1.Name= "testing No Tracking Behavior";
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//context.Update(coach1);
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//await context.SaveChangesAsync();
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//var coach =await context.Coaches.FindAsync( 2);
//context.Entry(coach).State= EntityState.Deleted;
////context.Remove(coach);
//context.SaveChangesAsync();

// await context.Coaches.Where(q=>q.Id==3)
//     .ExecuteUpdateAsync(set=>set
//         .SetProperty(q=>q.Name,"sepehr moonesi")
//         .SetProperty(q=>q.CreatedDate, DateTime.Now));

//await context.Coaches.Where(q=>q.Id==3).ExecuteDeleteAsync();


