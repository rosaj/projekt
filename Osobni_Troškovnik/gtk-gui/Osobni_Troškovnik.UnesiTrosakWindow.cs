
// This file has been generated by the GUI designer. Do not modify.
namespace Osobni_Troškovnik
{
	public partial class UnesiTrosakWindow
	{
		private global::Gtk.VBox vbox14;

		private global::Gtk.Table table5;

		private global::Gtk.Calendar calendar3;

		private global::Gtk.Button dodajKategorijuButton;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview1;

		private global::Gtk.Label label18;

		private global::Gtk.Label label19;

		private global::Gtk.ComboBoxEntry listaKategorija;

		private global::Gtk.SpinButton spinbutton4;

		private global::Gtk.VBox vbox15;

		private global::Gtk.Label label20;

		private global::Gtk.VBox vbox16;

		private global::Gtk.Label label21;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button odustaniButton;

		private global::Gtk.Button spremiAndNovi;

		private global::Gtk.Button spremiButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Osobni_Troškovnik.UnesiTrosakWindow
			this.Name = "Osobni_Troškovnik.UnesiTrosakWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("UnesiTrosakWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Container child Osobni_Troškovnik.UnesiTrosakWindow.Gtk.Container+ContainerChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.table5 = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(6));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.calendar3 = new global::Gtk.Calendar();
			this.calendar3.CanFocus = true;
			this.calendar3.Name = "calendar3";
			this.calendar3.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.table5.Add(this.calendar3);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table5[this.calendar3]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YPadding = ((uint)(5));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.dodajKategorijuButton = new global::Gtk.Button();
			this.dodajKategorijuButton.CanFocus = true;
			this.dodajKategorijuButton.Name = "dodajKategorijuButton";
			this.dodajKategorijuButton.UseUnderline = true;
			this.dodajKategorijuButton.Label = global::Mono.Unix.Catalog.GetString("Dodaj");
			this.table5.Add(this.dodajKategorijuButton);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table5[this.dodajKategorijuButton]));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.GtkScrolledWindow.Add(this.textview1);
			this.table5.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table5[this.GtkScrolledWindow]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.Xpad = 10;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Kategorija:");
			this.table5.Add(this.label18);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table5[this.label18]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena:      ");
			this.table5.Add(this.label19);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table5[this.label19]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.listaKategorija = global::Gtk.ComboBoxEntry.NewText();
			this.listaKategorija.Name = "listaKategorija";
			this.table5.Add(this.listaKategorija);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table5[this.listaKategorija]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YPadding = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton4 = new global::Gtk.SpinButton(0D, 100D, 1D);
			this.spinbutton4.CanFocus = true;
			this.spinbutton4.Name = "spinbutton4";
			this.spinbutton4.Adjustment.PageIncrement = 10D;
			this.spinbutton4.ClimbRate = 1D;
			this.spinbutton4.Numeric = true;
			this.table5.Add(this.spinbutton4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton4]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YPadding = ((uint)(6));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("Datum:     ");
			this.vbox15.Add(this.label20);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label20]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			w9.Padding = ((uint)(8));
			this.table5.Add(this.vbox15);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table5[this.vbox15]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.vbox16 = new global::Gtk.VBox();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 6;
			// Container child vbox16.Gtk.Box+BoxChild
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:          ");
			this.vbox16.Add(this.label21);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.label21]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			this.table5.Add(this.vbox16);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table5[this.vbox16]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox14.Add(this.table5);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.table5]));
			w13.Position = 0;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox14.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hseparator2]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.odustaniButton = new global::Gtk.Button();
			this.odustaniButton.CanFocus = true;
			this.odustaniButton.Name = "odustaniButton";
			this.odustaniButton.UseUnderline = true;
			this.odustaniButton.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox6.Add(this.odustaniButton);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.odustaniButton]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.spremiAndNovi = new global::Gtk.Button();
			this.spremiAndNovi.CanFocus = true;
			this.spremiAndNovi.Name = "spremiAndNovi";
			this.spremiAndNovi.UseUnderline = true;
			this.spremiAndNovi.Label = global::Mono.Unix.Catalog.GetString("Spremi & Novi");
			this.hbox6.Add(this.spremiAndNovi);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.spremiAndNovi]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.spremiButton = new global::Gtk.Button();
			this.spremiButton.CanFocus = true;
			this.spremiButton.Name = "spremiButton";
			this.spremiButton.UseUnderline = true;
			this.spremiButton.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox6.Add(this.spremiButton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.spremiButton]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox14.Add(this.hbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox6]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.Add(this.vbox14);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 371;
			this.DefaultHeight = 457;
			this.Show();
			this.dodajKategorijuButton.Clicked += new global::System.EventHandler(this.novaKategorijaClicked);
			this.odustaniButton.Clicked += new global::System.EventHandler(this.odustaniClicked);
			this.spremiAndNovi.Clicked += new global::System.EventHandler(this.spremiAndNoviClicked);
			this.spremiButton.Clicked += new global::System.EventHandler(this.spremiClicked);
		}
	}
}
