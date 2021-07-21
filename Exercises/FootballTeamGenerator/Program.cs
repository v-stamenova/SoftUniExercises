using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Team> teams = new List<Team>();
			string input = Console.ReadLine();
			while(input != "END")
			{
				List<string> data = input.Split(';').ToList();
				try
				{
					switch (data[0])
					{
						case "Team":
							teams.Add(new Team(data[1]));
							break;

						case "Add":
							if(teams.Any(x => x.Name == data[1]))
							{
								Team team = teams.Find(x => x.Name == data[1]);
								team.Players.Add(new Player(data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7])));
							}
							else
							{
								throw new Exception($"Team {data[1]} does not exist.");
							}
							break;

						case "Remove":
							teams.Find(x => x.Name == data[1]).RemovePlayer(data[2]);
							break;

						case "Rating":
							if (teams.Any(x => x.Name == data[1]))
							{
								Console.WriteLine($"{data[1]} - {teams.Find(x => x.Name == data[1]).Rating}");
							}
							else
							{
								throw new Exception($"Team {data[1]} does not exist.");
							}
							break;
					}
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
				input = Console.ReadLine();
			}
		}
	}
}
