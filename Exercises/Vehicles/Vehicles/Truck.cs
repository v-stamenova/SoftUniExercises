using System;

namespace Vehicles.Vehicles
{
	class Truck : Vehicle
	{
		public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm + 1.6, tankCapacity)
		{
		}

		public override string Drive(double distance)
		{
			if (this.FuelQuantity >= this.FuelConsumptionPerKm * distance)
			{
				this.FuelQuantity -= distance * this.FuelConsumptionPerKm;
				return $"Truck travelled {distance} km";
			}

			return "Truck needs refueling";
		}

		public override void Refuel(double quantity)
		{
			if (quantity <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			else if (quantity * 0.95 + this.FuelQuantity > this.TankCapacity)
			{
				throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
			}
			else
			{
				this.FuelQuantity += quantity * 0.95;
			}
		}
	}
}
