namespace MilitaryElite.Interfaces
{
	interface IMission
	{
		public string CodeName { get; set; }
		public MissionStatus Status { get; set; }

		public void CompleteMission();
	}
}
