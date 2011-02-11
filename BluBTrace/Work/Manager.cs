using System;
using BluBTrace.Scene;
using BluBTrace.Primitives;

namespace BluBTrace.Work
{
	public class Manager
	{
		
		private int _nbProcessors;
		
		public Manager ( int nbP )
		{
			this._nbProcessors = nbP;
		}
		
		public delegate void DrawingComputed(byte[] screen);
		public void Compute(Camera cam, Sphere sphere, DrawingComputed dc)
		{
			byte[] screen = new byte[3 * cam.XResolution * cam.YResolution];
			for(int i = 0; i < cam.YResolution; i++)
			{
				for(int j = 0; j < cam.XResolution; j++)
				{
					screen[ i*cam.XResolution*3 + j*3 ] = 255;
					screen[ i*cam.XResolution*3 + j*3 + 1] = 0;
					screen[ i*cam.XResolution*3 + j*3 + 2] = 0;
				}
			}
			dc(screen);
		}
	}
}

