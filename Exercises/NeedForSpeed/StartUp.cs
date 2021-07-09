namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
        }

        public class Vehicle
		{
			public Vehicle(int horsePower, double fuel)
			{
                this.HorsePower = horsePower;
                this.Fuel = fuel;
                this.DefaultFuelConsumption = 1.25;
			}

            public double Fuel { get; set; }
            public int HorsePower { get; set; }
            public double DefaultFuelConsumption { get; set; }
            public virtual double FuelConsumption { get; set; }

            public virtual void Drive(double kilometers)
			{
                this.Fuel -= kilometers * this.DefaultFuelConsumption;
			}
		}

		public class Motorcycle : Vehicle
		{
			public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
			{
			}
		}

		public class RaceMotorcycle : Motorcycle
		{
			public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
			{
				this.DefaultFuelConsumption = 8;
			}
		}

		public class CrossMotorcycle : Motorcycle
		{
			public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
			{
			}
		}

		public class Car : Vehicle
		{
			public Car(int horsePower, double fuel) : base(horsePower, fuel)
			{
				this.DefaultFuelConsumption = 3;
			}
		}

		public class FamilyCar : Car
		{
			public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
			{
			}
		}

		public class SportCar : Car
		{
			public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
			{
				this.DefaultFuelConsumption = 10;
			}
		}
	}
}
