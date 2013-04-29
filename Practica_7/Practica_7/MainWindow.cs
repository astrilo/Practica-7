using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnClicked (object sender, EventArgs e)
	{
		int puntos= 0;
		if (this.radp1b.Active)
		{
			puntos++;
		}
		if (this.spinp2.Text=="19")
		{
			puntos++;
		}
		if (this.checkp3a.Active)
		{
			puntos++;
		}
		if (this.checkp3c.Active)
		{
			puntos++;
		}

		DateTime Fecha= this.calendario.GetDate();
		string fechaselecc= Fecha.ToShortDateString();

		if(fechaselecc=="16/09/1810")
		{
			puntos++;
		}
		this.txtpuntos.Text= puntos.ToString();
	}
}
