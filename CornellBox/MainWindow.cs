using System;
using Gtk;
using Gdk;

using BluBTrace.Scene;
using BluBTrace.Work;
using BluBTrace.Primitives;

public partial class MainWindow : Gtk.Window
{
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	public delegate void DrawingComputed(byte[] screen);
	protected virtual void buttonPressed (object o, EventArgs e)
	{
		this.button3.Label = "zomfg";
		
		Camera cam = new Camera();
		cam.DistanceToScreen = 100;
		cam.ScreenCenter = new Vector( 0, 0, 0);
		cam.ScreenXSize = 10;
		cam.ScreenYSize = 10;
		cam.XResolution = 640;
		cam.YResolution = 480;
		cam.Location = new Vector( 0, 0, -100);
		cam.ViewDirection = new Vector ( 0, 0, 1);
		cam.TopDirection = new Vector ( 0, 1, 0);
		
		Sphere sp = new Sphere();
		sp.Center = new Vector( 0, 0, 5);
		sp.Radius = 2;
		
		Manager man = new Manager(2);
		this.button3.Label = "tsjing";
		man.Compute(cam, sp, new Manager.DrawingComputed(ComputationEnded));
		this.button3.Label = "genegerd";
		
	}
	
	public void ComputationEnded(byte[] image)
	{
		GdkWindow gw = image1.GdkWindow;
		GC g = new GC(gw);
		
		image1.GdkWindow.DrawPoint(g, 
		
		image1.QueueDraw();
	}
	
	
}

