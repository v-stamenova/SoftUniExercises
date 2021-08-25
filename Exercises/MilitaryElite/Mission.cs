namespace MilitaryElite
{
	class Mission : Interfaces.IMission
	{
		public Mission(string codeName, MissionStatus status)
		{
			this.CodeName = codeName;
			this.Status = status;
		}

		public string CodeName { get; set; }
		public MissionStatus Status { get; set; }

		public void CompleteMission()
		{
			this.Status = MissionStatus.finished;
		}

		public override string ToString()
		{
			return $"Code Name: {this.CodeName} State: {this.Status}";
		}
	}
}
