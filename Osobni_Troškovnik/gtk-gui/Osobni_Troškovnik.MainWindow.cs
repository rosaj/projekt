
// This file has been generated by the GUI designer. Do not modify.
namespace Osobni_Troškovnik
{
	public partial class MainWindow
	{
		private global::Gtk.Notebook notebook;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Image image1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.Button button2;

		private global::Gtk.Button button1;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Fixed fixed4;

		private global::Gtk.Button button3;

		private global::Gtk.Button button4;

		private global::Gtk.Fixed fixed3;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button button5;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label3;

		private global::Gtk.ColorSelection colorselection2;

		private global::Gtk.Label label2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Osobni_Troškovnik.MainWindow
			this.Name = "Osobni_Troškovnik.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Osobni Troškovnik");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			this.DefaultWidth = 719;
			this.DefaultHeight = 569;
			// Container child Osobni_Troškovnik.MainWindow.Gtk.Container+ContainerChild
			this.notebook = new global::Gtk.Notebook();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			this.notebook.ShowBorder = false;
			this.notebook.Scrollable = true;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.image1 = new global::Gtk.Image();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Osobni_Troškovnik.Pics.image.png");
			this.vbox1.Add(this.image1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.image1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 20;
			this.hbox1.BorderWidth = ((uint)(10));
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.hbox1.Add(this.fixed2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed2]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Osobni_Troškovnik.Pics.dodajTrosak.png");
			this.button2.Image = w3;
			this.hbox1.Add(this.button2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button2]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Osobni_Troškovnik.Pics.popisTroskova.png");
			this.button1.Image = w5;
			this.hbox1.Add(this.button1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox1.Add(this.fixed1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed1]));
			w7.Position = 3;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 20;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed4 = new global::Gtk.Fixed();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			this.hbox2.Add(this.fixed4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed4]));
			w9.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			global::Gtk.Image w10 = new global::Gtk.Image();
			w10.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Osobni_Troškovnik.Pics.ukupniTroskovi.png");
			this.button3.Image = w10;
			this.hbox2.Add(this.button3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button3]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button();
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			global::Gtk.Image w12 = new global::Gtk.Image();
			w12.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Osobni_Troškovnik.Pics.statistika.png");
			this.button4.Image = w12;
			this.hbox2.Add(this.button4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.button4]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.hbox2.Add(this.fixed3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed3]));
			w14.Position = 3;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button5 = new global::Gtk.Button();
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			global::Gtk.Image w17 = new global::Gtk.Image();
			w17.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Osobni_Troškovnik.Pics.izlaz.png");
			this.button5.Image = w17;
			this.hbox3.Add(this.button5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.button5]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.notebook.Add(this.vbox1);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("page1");
			this.notebook.SetTabLabel(this.vbox1, this.label1);
			this.label1.ShowAll();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.WidthRequest = 72;
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
			this.vbox3.Add(this.label3);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label3]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.colorselection2 = new global::Gtk.ColorSelection();
			this.colorselection2.Name = "colorselection2";
			this.colorselection2.HasOpacityControl = true;
			this.vbox3.Add(this.colorselection2);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.colorselection2]));
			w22.Position = 1;
			this.notebook.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w23 = ((global::Gtk.Notebook.NotebookChild)(this.notebook[this.vbox3]));
			w23.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("page2");
			this.notebook.SetTabLabel(this.vbox3, this.label2);
			this.label2.ShowAll();
			this.Add(this.notebook);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.button2.Clicked += new global::System.EventHandler(this.noviTrosakClicked);
			this.button1.Clicked += new global::System.EventHandler(this.popisClicked);
			this.button3.Clicked += new global::System.EventHandler(this.totalCostClicked);
			this.button4.Clicked += new global::System.EventHandler(this.statistikaClicked);
			this.button5.Clicked += new global::System.EventHandler(this.izlazClicked);
		}
	}
}
