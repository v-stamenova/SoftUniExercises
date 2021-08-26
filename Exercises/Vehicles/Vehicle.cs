using System;

namespace Vehicles
{
	abstract class Vehicle
	{
		private double fuelQuantity;

		public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
		{
			this.TankCapacity = tankCapacity;
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumptionPerKm = fuelConsumptionPerKm;
		}

		public double TankCapacity { get; set; }
		public double FuelQuantity
		{
			get
			{
				return this.fuelQuantity;
			}
			set
			{
				if (this.TankCapacity < value)
				{
					this.fuelQuantity = 0;
				}
				else
				{
					this.fuelQuantity = value;
				}
			}
		}
		public double FuelConsumptionPerKm { get; set; }

		public virtual void Refuel(double quantity)
		{
			if (quantity <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			else if (quantity + this.FuelQuantity > this.TankCapacity)
			{
				throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
			}
			else
			{
				this.FuelQuantity += quantity;
			}
		}

		public abstract string Drive(double distance);
	}
}
