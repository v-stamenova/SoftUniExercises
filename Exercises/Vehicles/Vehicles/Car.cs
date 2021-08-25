namespace Vehicles.Vehicles
{
	class Car : Vehicle
	{
		public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm + 0.9, tankCapacity)
		{
		}

		public override string Drive(double distance)
		{
			if (this.FuelQuantity >= this.FuelConsumptionPerKm * distance)
			{
				this.FuelQuantity -= distance * this.FuelConsumptionPerKm;
				return $"Car travelled {distance} km";
			}

			return "Car needs refueling";
		}
	}
}
