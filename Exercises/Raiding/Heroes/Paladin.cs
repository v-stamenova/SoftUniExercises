namespace Raiding.Heroes
{
	class Paladin : BaseHero
	{
		public Paladin(string name) : base(name, 100)
		{
		}

		public override string CastAbility()
		{
			return $"Paladin - {base.Name} healed for {base.Power}";
		}
	}
}
