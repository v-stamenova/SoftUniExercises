using System;
using System.Collections.Generic;
using System.Linq;
using Raiding.Heroes;

namespace Raiding
{
	class Program
	{
		static void Main(string[] args)
		{
			List<BaseHero> heroes = new List<BaseHero>();
			int heroesCount = int.Parse(Console.ReadLine());
			
			for(int i = 0; i < heroesCount; i++)
			{
				string heroName = Console.ReadLine();
				string heroType = Console.ReadLine();

				switch (heroType)
				{
					case "Druid":
						heroes.Add(new Druid(heroName));
						break;
					case "Paladin":
						heroes.Add(new Paladin(heroName));
						break;
					case "Rogue":
						heroes.Add(new Rogue(heroName));
						break;
					case "Warrior":
						heroes.Add(new Warrior(heroName));
						break;
					default:
						Console.WriteLine("Invalid hero!");
						break;
				}
			}

			int bossPower = int.Parse(Console.ReadLine());
			int teamPower = heroes.Sum(x => x.Power);

			heroes.ForEach(x => Console.WriteLine(x.CastAbility()));

			if(bossPower <= teamPower)
			{
				Console.WriteLine("Victory!");
			}
			else
			{
				Console.WriteLine("Defeat...");
			}
		}
	}
}
