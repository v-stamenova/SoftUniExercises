﻿namespace Raiding.Heroes
{
	class Warrior : BaseHero
	{
		public Warrior(string name) : base(name, 100)
		{
		}

		public override string CastAbility()
		{
			return $"Warrior - {base.Name} hit for {base.Power} damage";
		}
	}
}
