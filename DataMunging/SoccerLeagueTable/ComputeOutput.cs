using System;
using System.Collections.Generic;
using System.Linq;
using DryFusion.interfaces;

namespace SoccerLeagueTable
{
     class ComputeOutput: IComputeOutput<Team>
    {
        public  void Compute(IEnumerable<Team> teams)
        {
            var chosenTeamDifference = 9999;
            Team chosenTeam = null;
            foreach (var team in teams.Where(team => Math.Abs(team.GoalsFor - team.GoalsAgainst) < chosenTeamDifference))
            {
                chosenTeam = team;
                chosenTeamDifference = Math.Abs(team.GoalsFor - team.GoalsAgainst);
            }

            if(chosenTeam != null)
            {
                Console.WriteLine("Team " + chosenTeam.Name + " is the team with the smallest difference between 'for' " +
                                  "and 'against' number of goals (" + chosenTeamDifference + ").");
            }
            else
            {
                Console.WriteLine("No teams found in football.dat");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}