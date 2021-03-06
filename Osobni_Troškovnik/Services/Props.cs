﻿using System;

using Gtk;
namespace Osobni_Troškovnik
{
	public abstract class Props
	{

public static readonly Gdk.Color bgColor = Props.getColor("#B9CFDD");

		public static Gdk.Color getColor(string color)
		{
			var c = new Gdk.Color();
			Gdk.Color.Parse(color, ref c);
			return c;
		}
		public static EventBox add2EventBox(Widget w, Gdk.Color boxColor)
		{
			var e = new EventBox();
			e.Add(w);
			e.ModifyBg(StateType.Normal, boxColor);
			return e;
		}

		public static EventBox add2EventBox(Widget w, Gdk.Color boxColor, Gdk.Color textColor)
		{

			var e = new EventBox();
			e.Add(w);
			e.ModifyBg(StateType.Normal, boxColor);
			w.ModifyFg(StateType.Normal, textColor);
			return e;
		}



		public static EventBox add2EventBox(Widget w, Gdk.Color boxColor, Gdk.Color textColor, string font)
		{

			var e = new EventBox();
			e.Add(w);
			e.ModifyBg(StateType.Normal, boxColor);
			w.ModifyFg(StateType.Normal, textColor);
			w.ModifyFont(Pango.FontDescription.FromString(font));
			return e;
		}


		public static EventBox add2EventBox(Widget w, Gdk.Color textColor, string font)
		{

			var e = new EventBox();
			e.Add(w);
			w.ModifyFg(StateType.Normal, textColor);
			w.ModifyFont(Pango.FontDescription.FromString(font));
			return e;
		}


		public static EventBox add2EventBoxWithTextColor(Widget w, Gdk.Color textColor)
		{

			var e = new EventBox();
			e.Add(w);
			w.ModifyFg(StateType.Normal, textColor);
			return e;
		}

	}
}
