using System;
using System.Collections.Generic;
using BluBTrace.Primitives;
using BluBTrace.Scene;

namespace BluBTrace.Work
{
	public class Bucket
	{
		private Camera _camera;
		public Bucket (Camera cam )
		{
			this._camera = cam;
		}
		
		private List<Vector> _vectors = new List<Vector>();
		public void Add(Vector v)
		{
			_vectors.Add(v);
		}
	}
}

