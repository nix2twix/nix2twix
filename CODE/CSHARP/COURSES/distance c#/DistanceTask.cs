using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		//Ax + By + C = 0;

        public static double GetScalarMult (double ax, double ay, double bx, double by)
        {
            /// <summary>
            /// Возвращает скалярное произведение двух векторов, заданных своими координатами.
            /// </summary>

            return ax * bx + ay * by;
        }
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            double sideAC = Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
            double sideBC = Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by));
            double sideAB = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));

            //скалярное произведение векторов
            double multScalarAC_AB = GetScalarMult((x - ax),(y - ay),(bx - ax),(by - ay));
            double multScalarBC_AB = GetScalarMult((x - bx),(y - by),(ax - bx),(ay - by));
            if (sideAB == 0) return sideAC;

            else if (multScalarAC_AB >= 0 && multScalarBC_AB >= 0)
            {
                double p = (sideAC + sideBC + sideAB) / 2.0;
                double squareABC = Math.Sqrt
                                   (
                                      Math.Abs((p * (p - sideAC) * (p - sideBC) * (p - sideAB)))
                                   );

                return (2.0 * squareABC) / sideAB;
            }

            else if (multScalarAC_AB < 0 || multScalarBC_AB < 0)
            {
                return Math.Min(sideAC, sideBC);
            }

            else return 0;
        }
	}
}
/*			if (by != ay || bx != ax)
			{
				double kA = (by - ay);
				double kB = (ax - bx);
				double kC = (ay * bx - by * ax);
				distance = (Math.Abs(kA * x + kB * y + kC))
							/ (Math.Sqrt(kA * kA + kB * kB));
			}
*/