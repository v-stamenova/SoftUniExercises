namespace Raiding.Heroes
{
	class Druid : BaseHero
	{
		public Druid(string name) : base(name, 80)
		{
		}

		public override string CastAbility()
		{
			return $"Druid - {base.Name} healed for {base.Power}";
		}
	}
}
