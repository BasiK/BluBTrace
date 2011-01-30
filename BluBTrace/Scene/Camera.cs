using System;
using BluBTrace.Primitives;

namespace BluBTrace.Scene
{
	public class Camera
	{
		public Vector Location { get; set; }
		public Vector ViewDirection { get; set; }
		public Vector TopDirection { get; set; }
		
		public double DistanceToScreen { get; set; }
		public double ScreenXSize { get; set; }
		public double ScreenYSize { get; set; }
		
		public int XResolution { get; set; }
		public int YResolution { get; set; }
		
		public void Initialize()
		{
		}
		
		public Vector ScreenCenter { get; set; }
				
	}
}

