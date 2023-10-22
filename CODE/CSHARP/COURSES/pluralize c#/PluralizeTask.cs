using System;
namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			if ((count > 10 && count < 20) || (count % 100 > 10 && count % 100 < 20)) return "рублей";
			switch (count % 10)
			{
				case 1: return "рубль";
				case 2: return "рубля";
				case 3: return "рубля";
				case 4: return "рубля";
				default: return "рублей";
			}
		}
	}
}