
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label lblnom;
	private global::Gtk.Label lblcod;
	private global::Gtk.Entry entry2;
	private global::Gtk.Label lblp2;
	private global::Gtk.Label lblp1a;
	private global::Gtk.Label lblp1;
	private global::Gtk.SpinButton spinp2;
	private global::Gtk.Label lblp3;
	private global::Gtk.Label lblp3a;
	private global::Gtk.Label lblp4;
	private global::Gtk.Calendar calendario;
	private global::Gtk.Label lblgr;
	private global::Gtk.Entry entry5;
	private global::Gtk.Label lblp1b;
	private global::Gtk.RadioButton radp1b;
	private global::Gtk.RadioButton radp1d;
	private global::Gtk.Label lblp1c;
	private global::Gtk.RadioButton radp1c;
	private global::Gtk.Label lblp1d;
	private global::Gtk.CheckButton checkp3a;
	private global::Gtk.Label lblp3b;
	private global::Gtk.CheckButton checkp3b;
	private global::Gtk.Label lblp3c;
	private global::Gtk.CheckButton checkp3c;
	private global::Gtk.Label lblp3d;
	private global::Gtk.CheckButton checkp3d;
	private global::Gtk.RadioButton radp1a;
	private global::Gtk.ComboBox combogrup;
	private global::Gtk.Button btn;
	private global::Gtk.Entry txtpuntos;
	private global::Gtk.Label lblpuntos;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblnom = new global::Gtk.Label ();
		this.lblnom.Name = "lblnom";
		this.lblnom.LabelProp = global::Mono.Unix.Catalog.GetString ("NOMBRE");
		this.fixed1.Add (this.lblnom);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblnom]));
		w1.X = 30;
		w1.Y = 19;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblcod = new global::Gtk.Label ();
		this.lblcod.Name = "lblcod";
		this.lblcod.LabelProp = global::Mono.Unix.Catalog.GetString ("CODIGO");
		this.fixed1.Add (this.lblcod);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblcod]));
		w2.X = 31;
		w2.Y = 52;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w3.X = 83;
		w3.Y = 47;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp2 = new global::Gtk.Label ();
		this.lblp2.Name = "lblp2";
		this.lblp2.LabelProp = global::Mono.Unix.Catalog.GetString ("2-. ¿Cuanto es 23 + 15 / 2?");
		this.fixed1.Add (this.lblp2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp2]));
		w4.X = 26;
		w4.Y = 224;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp1a = new global::Gtk.Label ();
		this.lblp1a.Name = "lblp1a";
		this.lblp1a.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.lblp1a);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp1a]));
		w5.X = 27;
		w5.Y = 155;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp1 = new global::Gtk.Label ();
		this.lblp1.Name = "lblp1";
		this.lblp1.LabelProp = global::Mono.Unix.Catalog.GetString ("1-. ¿Cual es la capital del estado de Sinaloa?");
		this.fixed1.Add (this.lblp1);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp1]));
		w6.X = 27;
		w6.Y = 108;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.spinp2 = new global::Gtk.SpinButton (0D, 100D, 1D);
		this.spinp2.CanFocus = true;
		this.spinp2.Name = "spinp2";
		this.spinp2.Adjustment.PageIncrement = 10D;
		this.spinp2.ClimbRate = 1D;
		this.spinp2.Numeric = true;
		this.fixed1.Add (this.spinp2);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.spinp2]));
		w7.X = 217;
		w7.Y = 257;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp3 = new global::Gtk.Label ();
		this.lblp3.Name = "lblp3";
		this.lblp3.LabelProp = global::Mono.Unix.Catalog.GetString ("3-. ¿Cuales son paises Norteamericanos?");
		this.fixed1.Add (this.lblp3);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp3]));
		w8.X = 30;
		w8.Y = 309;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp3a = new global::Gtk.Label ();
		this.lblp3a.Name = "lblp3a";
		this.lblp3a.LabelProp = global::Mono.Unix.Catalog.GetString ("a)");
		this.fixed1.Add (this.lblp3a);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp3a]));
		w9.X = 28;
		w9.Y = 345;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp4 = new global::Gtk.Label ();
		this.lblp4.Name = "lblp4";
		this.lblp4.LabelProp = global::Mono.Unix.Catalog.GetString ("4-. Indica en el calendario cual es la fecha de la independencia de Mexico");
		this.fixed1.Add (this.lblp4);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp4]));
		w10.X = 28;
		w10.Y = 401;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calendario = new global::Gtk.Calendar ();
		this.calendario.CanFocus = true;
		this.calendario.Name = "calendario";
		this.calendario.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.fixed1.Add (this.calendario);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.calendario]));
		w11.X = 128;
		w11.Y = 452;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblgr = new global::Gtk.Label ();
		this.lblgr.Name = "lblgr";
		this.lblgr.LabelProp = global::Mono.Unix.Catalog.GetString ("GRUPO");
		this.fixed1.Add (this.lblgr);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblgr]));
		w12.X = 340;
		w12.Y = 19;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry5 = new global::Gtk.Entry ();
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '●';
		this.fixed1.Add (this.entry5);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry5]));
		w13.X = 84;
		w13.Y = 15;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp1b = new global::Gtk.Label ();
		this.lblp1b.Name = "lblp1b";
		this.lblp1b.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.lblp1b);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp1b]));
		w14.X = 164;
		w14.Y = 156;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radp1b = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Culiacan"));
		this.radp1b.CanFocus = true;
		this.radp1b.Name = "radp1b";
		this.radp1b.DrawIndicator = true;
		this.radp1b.UseUnderline = true;
		this.radp1b.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed1.Add (this.radp1b);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radp1b]));
		w15.X = 187;
		w15.Y = 155;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radp1d = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Cancun"));
		this.radp1d.CanFocus = true;
		this.radp1d.Name = "radp1d";
		this.radp1d.DrawIndicator = true;
		this.radp1d.UseUnderline = true;
		this.radp1d.Group = this.radp1b.Group;
		this.fixed1.Add (this.radp1d);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radp1d]));
		w16.X = 452;
		w16.Y = 157;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp1c = new global::Gtk.Label ();
		this.lblp1c.Name = "lblp1c";
		this.lblp1c.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.lblp1c);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp1c]));
		w17.X = 301;
		w17.Y = 156;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radp1c = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Mazatlan"));
		this.radp1c.CanFocus = true;
		this.radp1c.Name = "radp1c";
		this.radp1c.DrawIndicator = true;
		this.radp1c.UseUnderline = true;
		this.radp1c.Group = this.radp1b.Group;
		this.fixed1.Add (this.radp1c);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radp1c]));
		w18.X = 320;
		w18.Y = 157;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp1d = new global::Gtk.Label ();
		this.lblp1d.Name = "lblp1d";
		this.lblp1d.LabelProp = global::Mono.Unix.Catalog.GetString ("d)");
		this.fixed1.Add (this.lblp1d);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp1d]));
		w19.X = 433;
		w19.Y = 158;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkp3a = new global::Gtk.CheckButton ();
		this.checkp3a.CanFocus = true;
		this.checkp3a.Name = "checkp3a";
		this.checkp3a.Label = global::Mono.Unix.Catalog.GetString ("Mexico");
		this.checkp3a.DrawIndicator = true;
		this.checkp3a.UseUnderline = true;
		this.fixed1.Add (this.checkp3a);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkp3a]));
		w20.X = 44;
		w20.Y = 344;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp3b = new global::Gtk.Label ();
		this.lblp3b.Name = "lblp3b";
		this.lblp3b.LabelProp = global::Mono.Unix.Catalog.GetString ("b)");
		this.fixed1.Add (this.lblp3b);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp3b]));
		w21.X = 138;
		w21.Y = 346;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkp3b = new global::Gtk.CheckButton ();
		this.checkp3b.CanFocus = true;
		this.checkp3b.Name = "checkp3b";
		this.checkp3b.Label = global::Mono.Unix.Catalog.GetString ("Honduras");
		this.checkp3b.DrawIndicator = true;
		this.checkp3b.UseUnderline = true;
		this.fixed1.Add (this.checkp3b);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkp3b]));
		w22.X = 155;
		w22.Y = 345;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp3c = new global::Gtk.Label ();
		this.lblp3c.Name = "lblp3c";
		this.lblp3c.LabelProp = global::Mono.Unix.Catalog.GetString ("c)");
		this.fixed1.Add (this.lblp3c);
		global::Gtk.Fixed.FixedChild w23 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp3c]));
		w23.X = 284;
		w23.Y = 348;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkp3c = new global::Gtk.CheckButton ();
		this.checkp3c.CanFocus = true;
		this.checkp3c.Name = "checkp3c";
		this.checkp3c.Label = global::Mono.Unix.Catalog.GetString ("Canada");
		this.checkp3c.DrawIndicator = true;
		this.checkp3c.UseUnderline = true;
		this.fixed1.Add (this.checkp3c);
		global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkp3c]));
		w24.X = 297;
		w24.Y = 347;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp3d = new global::Gtk.Label ();
		this.lblp3d.Name = "lblp3d";
		this.lblp3d.LabelProp = global::Mono.Unix.Catalog.GetString ("d)");
		this.fixed1.Add (this.lblp3d);
		global::Gtk.Fixed.FixedChild w25 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp3d]));
		w25.X = 399;
		w25.Y = 348;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkp3d = new global::Gtk.CheckButton ();
		this.checkp3d.CanFocus = true;
		this.checkp3d.Name = "checkp3d";
		this.checkp3d.Label = global::Mono.Unix.Catalog.GetString ("Cuba");
		this.checkp3d.DrawIndicator = true;
		this.checkp3d.UseUnderline = true;
		this.fixed1.Add (this.checkp3d);
		global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.checkp3d]));
		w26.X = 418;
		w26.Y = 348;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.radp1a = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Torreon"));
		this.radp1a.CanFocus = true;
		this.radp1a.Name = "radp1a";
		this.radp1a.DrawIndicator = true;
		this.radp1a.UseUnderline = true;
		this.radp1a.Group = this.radp1b.Group;
		this.fixed1.Add (this.radp1a);
		global::Gtk.Fixed.FixedChild w27 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.radp1a]));
		w27.X = 43;
		w27.Y = 155;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.combogrup = global::Gtk.ComboBox.NewText ();
		this.combogrup.Name = "combogrup";
		this.fixed1.Add (this.combogrup);
		global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.combogrup]));
		w28.X = 395;
		w28.Y = 19;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btn = new global::Gtk.Button ();
		this.btn.CanFocus = true;
		this.btn.Name = "btn";
		this.btn.UseUnderline = true;
		this.btn.Label = global::Mono.Unix.Catalog.GetString ("Terminar");
		this.fixed1.Add (this.btn);
		global::Gtk.Fixed.FixedChild w29 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btn]));
		w29.X = 258;
		w29.Y = 671;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtpuntos = new global::Gtk.Entry ();
		this.txtpuntos.CanFocus = true;
		this.txtpuntos.Name = "txtpuntos";
		this.txtpuntos.IsEditable = true;
		this.txtpuntos.InvisibleChar = '●';
		this.fixed1.Add (this.txtpuntos);
		global::Gtk.Fixed.FixedChild w30 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtpuntos]));
		w30.X = 457;
		w30.Y = 672;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblpuntos = new global::Gtk.Label ();
		this.lblpuntos.Name = "lblpuntos";
		this.lblpuntos.LabelProp = global::Mono.Unix.Catalog.GetString ("Puntos");
		this.fixed1.Add (this.lblpuntos);
		global::Gtk.Fixed.FixedChild w31 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblpuntos]));
		w31.X = 417;
		w31.Y = 674;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 639;
		this.DefaultHeight = 779;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btn.Clicked += new global::System.EventHandler (this.OnBtnClicked);
	}
}
