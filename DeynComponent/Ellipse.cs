using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeynComponent
{
	public class Ellipse : Component
	{
		private Control _cntrl;

		private int _cornerRadius = 30;

		public Control TargetControl
		{
			get
			{
				return this._cntrl;
			}
			set
			{
				this._cntrl = value;
				this._cntrl.SizeChanged += delegate (object sender, EventArgs eventArgs)
				{
					this._cntrl.Region = Region.FromHrgn(Ellipse.CreateRoundRectRgn(0, 0, this._cntrl.Width, this._cntrl.Height, this._cornerRadius, this._cornerRadius));
				};
			}
		}

		public int cornerRadius
		{
			get
			{
				return this._cornerRadius;
			}
			set
			{
				this._cornerRadius = value;
				if (this._cntrl != null)
				{
					this._cntrl.Region = Region.FromHrgn(Ellipse.CreateRoundRectRgn(0, 0, this._cntrl.Width, this._cntrl.Height, this._cornerRadius, this._cornerRadius));
				}
			}
		}

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int TopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
	}
}

