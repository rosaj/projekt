
// This file has been generated by the GUI designer. Do not modify.
namespace Osobni_Troškovnik
{
	public partial class UnesiTrosakWindow
	{
		private global::Gtk.VBox vbox14;

		private global::Gtk.Table table5;

		private global::Gtk.SpinButton cijena;

		private global::Gtk.Button dodajKategorijuButton;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView opis;

		private global::Gtk.Calendar kalendar;

		private global::Gtk.Label label18;

		private global::Gtk.Label label19;

		private global::Gtk.ComboBox listaKategorija;

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
			this.cijena = new global::Gtk.SpinButton(0D, 999999999999D, 1D);
			global::Gtk.Tooltips w1 = new Gtk.Tooltips();
			w1.SetTip(this.cijena, "Unesite cijenu troška\n", "Unesite cijenu troška\n");
			this.cijena.CanFocus = true;
			this.cijena.Name = "cijena";
			this.cijena.Adjustment.PageIncrement = 10D;
			this.cijena.ClimbRate = 1D;
			this.cijena.Digits = ((uint)(2));
			this.cijena.Numeric = true;
			this.table5.Add(this.cijena);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table5[this.cijena]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YPadding = ((uint)(6));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.dodajKategorijuButton = new global::Gtk.Button();
			w1.SetTip(this.dodajKategorijuButton, "Dodavanje nove kategorije", "Dodavanje nove kategorije");
			this.dodajKategorijuButton.CanFocus = true;
			this.dodajKategorijuButton.Name = "dodajKategorijuButton";
			this.dodajKategorijuButton.UseUnderline = true;
			this.dodajKategorijuButton.Label = global::Mono.Unix.Catalog.GetString("Dodaj");
			this.table5.Add(this.dodajKategorijuButton);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table5[this.dodajKategorijuButton]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.opis = new global::Gtk.TextView();
			w1.SetTip(this.opis, "Kratak opis troška(pr. Kupnja mobitela IPhone 7) max 100 znakova.", "Kratak opis troška(pr. Kupnja mobitela IPhone 7) max 100 znakova.");
			this.opis.CanFocus = true;
			this.opis.Name = "opis";
			this.GtkScrolledWindow.Add(this.opis);
			this.table5.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table5[this.GtkScrolledWindow]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.kalendar = new global::Gtk.Calendar();
			w1.SetTip(this.kalendar, "Odaberite datum nastanka troška", "Odaberite datum nastanka troška");
			this.kalendar.CanFocus = true;
			this.kalendar.Name = "kalendar";
			this.kalendar.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.table5.Add(this.kalendar);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table5[this.kalendar]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YPadding = ((uint)(5));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.Xpad = 10;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Kategorija:");
			this.table5.Add(this.label18);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table5[this.label18]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena:      ");
			this.table5.Add(this.label19);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table5[this.label19]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.listaKategorija = global::Gtk.ComboBox.NewText();
			this.listaKategorija.Name = "listaKategorija";
			this.table5.Add(this.listaKategorija);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table5[this.listaKategorija]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YPadding = ((uint)(5));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("Datum:     ");
			this.vbox15.Add(this.label20);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label20]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(8));
			this.table5.Add(this.vbox15);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table5[this.vbox15]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.vbox16 = new global::Gtk.VBox();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 6;
			// Container child vbox16.Gtk.Box+BoxChild
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:          ");
			this.vbox16.Add(this.label21);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.label21]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			this.table5.Add(this.vbox16);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table5[this.vbox16]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox14.Add(this.table5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.table5]));
			w14.Position = 0;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox14.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hseparator2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.odustaniButton = new global::Gtk.Button();
			w1.SetTip(this.odustaniButton, "Odustani od upisivanja troška", "Odustani od upisivanja troška");
			this.odustaniButton.CanFocus = true;
			this.odustaniButton.Name = "odustaniButton";
			this.odustaniButton.UseUnderline = true;
			this.odustaniButton.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox6.Add(this.odustaniButton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.odustaniButton]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.spremiAndNovi = new global::Gtk.Button();
			w1.SetTip(this.spremiAndNovi, "Spremi trošak i unesi novi", "Spremi trošak i unesi novi");
			this.spremiAndNovi.CanFocus = true;
			this.spremiAndNovi.Name = "spremiAndNovi";
			this.spremiAndNovi.UseUnderline = true;
			this.spremiAndNovi.Label = global::Mono.Unix.Catalog.GetString("Spremi & Novi");
			this.hbox6.Add(this.spremiAndNovi);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.spremiAndNovi]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.spremiButton = new global::Gtk.Button();
			w1.SetTip(this.spremiButton, "Spremi trošak", "Spremi trošak");
			this.spremiButton.CanFocus = true;
			this.spremiButton.Name = "spremiButton";
			this.spremiButton.UseUnderline = true;
			this.spremiButton.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox6.Add(this.spremiButton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.spremiButton]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox14.Add(this.hbox6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox6]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox14);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 371;
			this.DefaultHeight = 457;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.dodajKategorijuButton.Clicked += new global::System.EventHandler(this.novaKategorijaClicked);
			this.odustaniButton.Clicked += new global::System.EventHandler(this.odustaniClicked);
			this.spremiAndNovi.Clicked += new global::System.EventHandler(this.spremiAndNoviClicked);
			this.spremiButton.Clicked += new global::System.EventHandler(this.spremiClicked);
		}
	}
}
