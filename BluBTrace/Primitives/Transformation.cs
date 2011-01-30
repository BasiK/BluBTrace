using System;
using System.Collections.Generic;

namespace BluBTrace.Primitives
{
	public class Transformation
	{
		public Transformation ()
		{
		}
	}
	
	public class Translation : Transformation
	{
		public Vector Vector { get; set; }
	}
	
	public class Rotation : Transformation
	{
		public Vector Vector { get; set; }
		public double Degree { get; set; }
	}
	
	public class TransformationSequence
	{
		private List<Transformation> _sequence = new List<Transformation>();
		public void AddTransformation(Transformation t)
		{
			_sequence.Add(t);
		}
		
		
	}
}

