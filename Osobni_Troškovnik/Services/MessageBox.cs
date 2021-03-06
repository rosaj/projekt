﻿using System;
using Gtk;
namespace Osobni_Troškovnik
{
	public class MessageBox
	{


		private MessageBox() { }
		private static bool shown = false;
		public static void Show(Gtk.Window parent_window, DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg)
		{
			MessageDialog md = new MessageDialog(parent_window, flags, msgtype, btntype, msg);
			md.Run();
			md.Destroy();
		}

		public static void Show(string msg)
		{
			MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, msg);
			md.Run();
			md.Destroy();
		}
		public static void Popout(string text, int sekundePrikaza, Window parent)
		{
			if (!shown)
			{
				shown = true;
				var popout = new Window(WindowType.Popup);

				var w  = new Label(text);


				var bgColor = new Gdk.Color();
				Gdk.Color.Parse("#0017FF", ref bgColor);

				w.ModifyFg(StateType.Normal, bgColor);


				popout.Add(w);
				popout.SetSizeRequest(200, 100);
				popout.TransientFor = parent;

				popout.ParentWindow = parent.GdkWindow;

				popout.SetPosition(WindowPosition.CenterOnParent);

				popout.ShowAll();

				GLib.Timeout.Add((uint)(sekundePrikaza * 1000), delegate {
					popout.Destroy();
					shown = false;
					return false;
				});
			}
		}

	}

}
