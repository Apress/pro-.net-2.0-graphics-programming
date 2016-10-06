using System;
using System.Collections.Generic;
using System.Text;
using System.Design;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleLineControl
{
	public partial class SimpleLineControlDesigner :
	  System.Windows.Forms.Design.ControlDesigner
	{
		private bool dragging = false;
		private int lastXPos = -1;
		bool mouseInAdornment = false;

		private const int WM_MOUSEMOVE = 0x0200;
		private const int WM_LBUTTONDOWN = 0x0201;
		private const int WM_LBUTTONUP = 0x0202;
		private const int WM_LBUTTONDBLCLK = 0x0203;
		private const int WM_RBUTTONDOWN = 0x0204;
		private const int WM_RBUTTONUP = 0x0205;
		private const int WM_RBUTTONDBLCLK = 0x0206;

		private Rectangle calcAdornmentRect()
		{
			int XPos = ((SimpleLineControl)(this.Control)).LinePosition;
			return new Rectangle(XPos - 4, 5, 8, 12);
		}

		protected override void OnPaintAdornments(PaintEventArgs pe)
		{
			Graphics g = pe.Graphics;
			Rectangle r = calcAdornmentRect();
			g.FillRectangle(Brushes.White, r);
			g.DrawRectangle(Pens.Black, r);
		}

		protected override void OnSetCursor()
		{
			if (mouseInAdornment == false || !dragging)
				base.OnSetCursor();
		}

		protected override void WndProc(ref Message m)
		{
			Point p;
			Rectangle r;
			SimpleLineControl dl;

			switch (m.Msg)
			{
				case WM_LBUTTONDOWN:
					r = calcAdornmentRect();
					p = new Point(m.LParam.ToInt32());
					if (r.Contains(p))
					{
						dragging = true;
						this.Control.Parent.Cursor = Cursors.Arrow;
					}
					else
					{
						base.WndProc(ref m);
					}
					break;

				case WM_MOUSEMOVE:
					p = new Point(m.LParam.ToInt32());
					dl = (SimpleLineControl)(this.Control);
					if (dragging)
					{
						int XPos = p.X;
						XPos = Math.Max(5, XPos);
						XPos = Math.Min(dl.ClientRectangle.Width - 5, XPos);
						if (lastXPos != XPos)
						{
							PropertyDescriptorCollection properties =
							  TypeDescriptor.GetProperties(this.Control.GetType());
							PropertyDescriptor sizeProp = properties["LinePosition"];
							sizeProp.SetValue(this.Control, XPos);
							lastXPos = XPos;
							dl.Invalidate();
							dl.Update();
						}
						this.Control.Parent.Cursor = Cursors.Arrow;
						return;
					}
					else
					{
						r = calcAdornmentRect();
						p = new Point(m.LParam.ToInt32());
						if (r.Contains(p))
						{
							mouseInAdornment = true;
							this.Control.Parent.Cursor = Cursors.Arrow;
						}
						else
						{
							mouseInAdornment = false;
						}
						base.WndProc(ref m);
					}
					break;

				case WM_LBUTTONUP:
					if (dragging)
					{
						dl = (SimpleLineControl)(this.Control);
						p = new Point(m.LParam.ToInt32());
						int XPos = p.X;
						XPos = Math.Max(5, XPos);
						XPos = Math.Min(dl.ClientRectangle.Width - 5, XPos);
						PropertyDescriptorCollection properties =
						  TypeDescriptor.GetProperties(this.Control.GetType());
						PropertyDescriptor sizeProp = properties["LinePosition"];
						sizeProp.SetValue(this.Control, XPos);
						lastXPos = -1;
						dl.Invalidate();
						dl.Update();
						dragging = false;
					}
					base.WndProc(ref m);
					break;

				default:
					base.WndProc(ref m);
					break;
			}
		}
	}
}
