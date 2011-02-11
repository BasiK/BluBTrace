using System;
namespace BluBTrace.Primitives
{
	public abstract class PrimitiveObject
	{
		public abstract double GetIntersection(Ray r);
	}
		
	public class Sphere : PrimitiveObject
	{
		public Vector Center { get; set; }
		public double Radius { get; set; }
		
		public override double GetIntersection (Ray r)
		{
			Vector d = r.Direction;
			
			Vector o = r.Origin;
			Vector c = this.Center;
			
			double oxCx = o.x - c.x;
			double oyCy = o.y - c.y;
			double ozCz = o.z - c.z;
			
			double equ_b = 2 * (d.x * oxCx + d.y * oyCy + d.z * ozCz);
			double equ_c = oxCx * oxCx + oyCy * oyCy + ozCz * ozCz - this.Radius * this.Radius;
			
			double disc = equ_b * equ_b - 4 * equ_c;
			if (disc < 0)
				return -1;
			
			double t0 = (- equ_b + Math.Sqrt(equ_b * equ_b - 4 * equ_c) ) / 2;
			if (t0 > 0)
				return t0;
			
			if (disc == 0)
				return -1;
			
			double t1 = (- equ_b - Math.Sqrt(equ_b * equ_b - 4 * equ_c) ) / 2;
			if (t1 > 0)
				return t1;
			
			return -1;
		}
	}
}

