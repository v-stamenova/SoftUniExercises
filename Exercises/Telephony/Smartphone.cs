using System.Linq;

namespace Telephony
{
	public class Smartphone : ISmart, IPhone
	{
		public string Browsing(string site)
		{
			if (site.Any(char.IsDigit))
			{
				return $"Invalid URL!";
			}
			return $"Browsing: {site}!";
		}

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
