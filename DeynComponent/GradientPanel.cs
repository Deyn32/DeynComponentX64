using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DeynComponent
{
	public class GradientPanel : Panel
	{
		public Color colorTop { get; set; }

		public Color colorBottom { get; set; }

		protected override void OnPaint(PaintEventArgs e)
		{
			LinearGradientBrush brush = new LinearGradientBrush(base.ClientRectangle, this.colorTop, this.colorBottom, 90f);
			e.Graphics.FillRectangle(brush, base.ClientRectangle);
			base.OnPaint(e);
			e.Dispose();
		}
	}
}
