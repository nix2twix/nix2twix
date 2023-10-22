using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		const double g = 9.8;
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{
			double sinAlfDouble = (g * distance) / (v * v);
			double alfRad = Math.Asin(sinAlfDouble)/2;
			if (alfRad >= 0 && alfRad < Math.PI / 2) return alfRad;
			else return double.NaN;
		}
	}
}