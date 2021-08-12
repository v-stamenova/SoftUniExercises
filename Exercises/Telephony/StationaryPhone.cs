using System.Linq;

namespace Telephony
{
	public class StationaryPhone : IPhone
	{
		public string Calling(string number)
		{
			if (number.All(char.IsDigit))
			{
				return $"Calling... {number}";
			}
			return $"Invalid number!";
		}
	}
}
