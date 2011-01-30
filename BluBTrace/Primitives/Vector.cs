using System;

namespace BluBTrace.Primitives
{
	public struct Vector
	{
		public double x, y, z;
		
		public double Norm
		{
			get
			{
				return Math.Sqrt(x*x + y*y + z*z);
			}
		}
		
		public void Normalize()
		{
			double n = this.Norm;
			x /= n;
			y /= n;
			z /= n;
		}
		
		public Vector GetDirectionTo(Vector v2)
		{
			return new Vector
			{
				x = v2.x - this.x,
				y = v2.y - this.y,
				z = v2.z - this.z
			};
		}
		
		public Vector GetDestination(Vector direction, double multiplier)
		{
			return new Vector
			{
				x = this.x + multiplier * direction.x,
				y = this.y + multiplier * direction.y,
				z = this.z + multiplier * direction.z
			};
		}
	}
}


