
// This file has been generated by the GUI designer. Do not modify.
namespace Osobni_Troškovnik
{
	public partial class MainWindow
	{
		private global::Gtk.Notebook notebook;

		private global::Gtk.Table table1;

		private global::Gtk.Button izlazButton;

		private global::Gtk.Button izvjesceButton;

		private global::Gtk.Button noviTrosakButton;

		private global::Gtk.Button statistikaButton;

		private global::Gtk.Button sveukupniButton;

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
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child Osobni_Troškovnik.MainWindow.Gtk.Container+ContainerChild
			this.notebook = new global::Gtk.Notebook();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			this.notebook.ShowBorder = false;
			this.notebook.Scrollable = true;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.table1 = new global::Gtk.Table(((uint)(6)), ((uint)(1)), true);
			this.table1.CanDefault = true;
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(11));
			this.table1.ColumnSpacing = ((uint)(1));
			// Container child table1.Gtk.Table+TableChild
			this.izlazButton = new global::Gtk.Button();
			this.izlazButton.CanFocus = true;
			this.izlazButton.Name = "izlazButton";
			this.izlazButton.UseUnderline = true;
			this.izlazButton.Label = global::Mono.Unix.Catalog.GetString("Izlaz");
			this.table1.Add(this.izlazButton);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.izlazButton]));
			w1.TopAttach = ((uint)(5));
			w1.BottomAttach = ((uint)(6));
			w1.XPadding = ((uint)(120));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.izvjesceButton = new global::Gtk.Button();
			this.izvjesceButton.CanFocus = true;
			this.izvjesceButton.Name = "izvjesceButton";
			this.izvjesceButton.UseUnderline = true;
			this.izvjesceButton.Label = global::Mono.Unix.Catalog.GetString("Izvješće");
			this.table1.Add(this.izvjesceButton);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.izvjesceButton]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.XPadding = ((uint)(120));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.noviTrosakButton = new global::Gtk.Button();
			this.noviTrosakButton.HeightRequest = 40;
			this.noviTrosakButton.CanFocus = true;
			this.noviTrosakButton.Name = "noviTrosakButton";
			this.noviTrosakButton.UseUnderline = true;
			this.noviTrosakButton.Label = global::Mono.Unix.Catalog.GetString("Novi trošak");
			this.table1.Add(this.noviTrosakButton);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.noviTrosakButton]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XPadding = ((uint)(120));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.statistikaButton = new global::Gtk.Button();
			this.statistikaButton.CanFocus = true;
			this.statistikaButton.Name = "statistikaButton";
			this.statistikaButton.UseUnderline = true;
			this.statistikaButton.Label = global::Mono.Unix.Catalog.GetString("Statistika");
			this.table1.Add(this.statistikaButton);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.statistikaButton]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XPadding = ((uint)(120));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.sveukupniButton = new global::Gtk.Button();
			this.sveukupniButton.CanFocus = true;
			this.sveukupniButton.Name = "sveukupniButton";
			this.sveukupniButton.UseUnderline = true;
			this.sveukupniButton.Label = global::Mono.Unix.Catalog.GetString("Sveukupni trošak");
			this.table1.Add(this.sveukupniButton);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.sveukupniButton]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.XPadding = ((uint)(120));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook.Add(this.table1);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("page1");
			this.notebook.SetTabLabel(this.table1, this.label1);
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
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.colorselection2 = new global::Gtk.ColorSelection();
			this.colorselection2.Name = "colorselection2";
			this.colorselection2.HasOpacityControl = true;
			this.vbox3.Add(this.colorselection2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.colorselection2]));
			w8.Position = 1;
			this.notebook.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebook[this.vbox3]));
			w9.Position = 1;
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
			this.DefaultWidth = 483;
			this.DefaultHeight = 320;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.sveukupniButton.Clicked += new global::System.EventHandler(this.totalCostClicked);
			this.statistikaButton.Clicked += new global::System.EventHandler(this.statistikaClicked);
			this.noviTrosakButton.Clicked += new global::System.EventHandler(this.noviTrosakClicked);
			this.izvjesceButton.Clicked += new global::System.EventHandler(this.izvjesceClicked);
			this.izlazButton.Clicked += new global::System.EventHandler(this.izlazClicked);
		}
	}
}
