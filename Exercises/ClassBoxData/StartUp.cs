using System;

namespace ClassBoxData
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			try
			{
				Box box = new Box(length, width, height);
				Console.WriteLine(box.SurfaceArea());
				Console.WriteLine(box.LateralSurfaceArea());
				Console.WriteLine(box.Volume());
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}

	public class Box
	{
		private double length;
		private double width;
		private double height;

		public Box(double length, double width, double height)
		{
			this.Length = length;
			this.Width = width;
			this.Height = height;
		}

		public double Length
		{
			get
			{
				return this.length;
			}
			private set
			{
				if(value <= 0)
				{
					throw new Exception("Length cannot be zero or negative.");
				}
				else
				{
					this.length = value;
				}
			}
		}

		public double Width
		{
			get
			{
				return this.width;
			}
			private set
			{
				if(value <= 0)
				{
					throw new Exception("Width cannot be zero or negative.");
				}
				else
				{
					this.width = value;
				}
			}
		}

		public double Height
		{
			get
			{
				return this.height;
			}
			private set
			{
				if(value <= 0)
				{
					throw new Exception("Height cannot be zero or negative.");
				}
				else
				{
					this.height = value;
				}
			}
		}

		public string Volume()
		{
			return $"Volume - {string.Format("{0:N2}", this.height * this.length * this.width)}";
		}

		public string LateralSurfaceArea()
		{
			return $"Lateral Surface Area - {string.Format("{0:N2}", 2 * this.height * (this.length + this.width))}";
		}

		public string SurfaceArea()
		{
			return $"Surface Area - {string.Format("{0:N2}", 2 * (this.height * this.length + this.height * this.width + this.width * this.length))}";
		}
	}
}
