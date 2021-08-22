using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Soldier> soldiers = new List<Soldier>();

			string input = Console.ReadLine();
			while(input != "End")
			{
				List<string> data = input.Split(' ').ToList();
				switch (data[0])
				{
					case "Private":
						soldiers.Add(new Private(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4])));
						break;
					case "LieutenantGeneral":
						LieutenantGeneral general = new LieutenantGeneral(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]));
						data.RemoveRange(0, 5);
						foreach(Soldier soldier in soldiers)
						{
							if (data.Contains(soldier.Id.ToString()))
							{
								general.Privates.Add(soldier as Private);
							}
						}
						soldiers.Add(general);
						break;
					case "Engineer":
						Engineer engineer = new Engineer(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]), DefineCorps(data[5]));
						data.RemoveRange(0, 6);
						for(int i = 0; i < data.Count; i += 2)
						{
							Repair repair = new Repair(data[i], int.Parse(data[i + 1]));
							engineer.Repairs.Add(repair);
						}
						soldiers.Add(engineer);
						break;
					case "Commando":
						Commando commando = new Commando(int.Parse(data[1]), data[2], data[3], decimal.Parse(data[4]), DefineCorps(data[5]));
						data.RemoveRange(0, 6);
						for (int i = 0; i < data.Count; i += 2)
						{
							Mission mission = new Mission(data[i], DefineStatus(data[i + 1]));
							commando.Missions.Add(mission);
						}
						soldiers.Add(commando);
						break;
					case "Spy":
						soldiers.Add(new Spy(int.Parse(data[1]), data[2], data[3], int.Parse(data[4])));
						break;
				}
				input = Console.ReadLine();
			}

			foreach(Soldier soldier in soldiers)
			{
				Console.WriteLine(soldier.ToString());
			}
		}

		public static Corps DefineCorps(string corpsName)
		{
			Dictionary<string, Corps> mappingCorps = new Dictionary<string, Corps>()
			{
				{ "Airforces", Corps.Airforces },
				{ "Marines", Corps.Marines }
			};

			return mappingCorps[corpsName];
		}

		public static MissionStatus DefineStatus(string missionStatus)
		{
			Dictionary<string, MissionStatus> mappingStatus = new Dictionary<string, MissionStatus>()
			{
				{ "finished", MissionStatus.finished },
				{ "inProgress", MissionStatus.inProgress }
			};

			return mappingStatus[missionStatus];
		}
	}
}
