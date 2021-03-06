﻿using System;
using Gtk;
namespace Osobni_Troškovnik
{
	public partial class EditTrosakWindow : Gtk.Window
	{
		
		public TrosakNodeStore presenter;
		public TrosakNode trosakPresenter;
		public EditTrosakWindow(TrosakNode tp,TrosakNodeStore t,Window parent) : base(Gtk.WindowType.Toplevel)
		{
	
			this.TransientFor = parent;

			this.ParentWindow = parent.GdkWindow;

			this.Build();
			this.Icon = parent.Icon;
			eventBox.ModifyBg(StateType.Normal, MainWindow.bgColor);

			presenter = t;
			trosakPresenter = tp;
			cijena.Value = trosakPresenter.trosak.Cijena;
			opis.Buffer.Text = trosakPresenter.opis;
			kategorijaLabel.LabelProp = trosakPresenter.trosak.Kategorija;
			var datum = DateTime.ParseExact(trosakPresenter.datum, "dd.MM.yyyy", null);
			kalendar.SelectMonth((uint)datum.Month - 1, (uint)datum.Year);
			kalendar.SelectDay((uint)datum.Day);

		}

		protected void spremiClicked(object sender, EventArgs e)
		{

			try
			{
				presenter.azurirajTrosak(trosakPresenter, cijena.Value, kalendar.GetDate(), opis.Buffer.Text);
				MessageBox.Popout("Trošak spremljen", 1, TransientFor);

			

				OnDeleteEvent(sender, new Gtk.DeleteEventArgs());
			}
			catch (Exception ex)
			{
				MessageBox.Popout(ex.Message, 2, this);
			}

		}

		protected void odustaniClicked(object sender, EventArgs e)
		{
			OnDeleteEvent(sender, new Gtk.DeleteEventArgs());
		}

		protected void OnDeleteEvent(object sender, Gtk.DeleteEventArgs a)
		{
			Destroy();

		}

		protected void brisiClicked(object sender, EventArgs e)
		{
			Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite izbrisati trošak?");

			d.AddButton("Da", Gtk.ResponseType.Yes);
			d.AddButton("Ne", Gtk.ResponseType.No);

			var odgovor = (Gtk.ResponseType)d.Run();


			if (odgovor == Gtk.ResponseType.Yes)
			{

				presenter.brisiTrosak(trosakPresenter);

				d.Destroy();
				MessageBox.Popout("Trošak izbrisan", 1,TransientFor);
				Destroy();
			}
			else 
			{
				d.Destroy();
			}

		}

		protected void OnKeyPress(object o, KeyPressEventArgs args)
		{
			uint keyCode = args.Event.KeyValue;
			if (keyCode == 65307) OnDeleteEvent(o, null);
		}
	}
}
