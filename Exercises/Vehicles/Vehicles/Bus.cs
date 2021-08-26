namespace Vehicles.Vehicles
{
	class Bus : Vehicle
	{
		public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
		{
			this.HasPeople = false;
		}

		public bool HasPeople { get; set; }

		public override string Drive(double distance)
		{
			double partialConsumption = this.FuelConsumptionPerKm;

			if (HasPeople)
			{
				partialConsumption += 1.4;
			}

			if (this.FuelQuantity >= partialConsumption * distance)
			{
				this.FuelQuantity -= distance * partialConsumption;
				return $"Bus travelled {distance} km";
			}

			return "Bus needs refueling";
		}
	}
}
