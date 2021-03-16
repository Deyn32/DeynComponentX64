using System;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DeynComponent
{
	public class CircularButton : Button
	{
		protected override void OnPaint(PaintEventArgs pevent)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(0, 0, base.ClientSize.Width, base.ClientSize.Height);
			base.Region = new Region(graphicsPath);
			base.OnPaint(pevent);
		}
	}
}
